using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Bingo_DesktopApp
{
    public partial class Form1 : Form
    {
        public class BingoCard
        {
            string Name { get; set; }
            string[,] bingoCardAddresses { get; set; }
            bool[,] bingoCardProgress { get; set; }
            Dictionary<string, List<string[]>> winCollection { get; set; }

            public BingoCard(string name, string[,] bingoCardAddresses)
            {
                this.Name = name;
                bool bingoCardHasCorrectHeight = bingoCardAddresses.GetLength(0) == 5;
                bool bingoCardHasCorrectWidth = bingoCardAddresses.GetLength(1) == 5;

                if (!bingoCardHasCorrectHeight || !bingoCardHasCorrectWidth)
                {
                    throw new ArgumentException("The 2D Array for the BingoCard constructor was not 5x5");
                }
                this.bingoCardAddresses = bingoCardAddresses;

                //Initialize progress card, and set free space
                this.bingoCardProgress = new bool[5, 5];
                this.bingoCardProgress[2, 2] = true;

                //Initialize Win Collection
                this.winCollection = new Dictionary<string, List<string[]>>();

            }

            internal Dictionary<string, List<string[]>> CollectWins()
            {
                return this.winCollection;
            }
            internal string GetName()
            {
                return this.Name;
            }

            internal void TestAddress(string address)
            {
                //When an address is called, you test if it is in the card
                for (int i = 0; i < bingoCardAddresses.GetLength(0); i++)
                {
                    for (int j = 0; j < bingoCardAddresses.GetLength(1); j++)
                    {
                        if (bingoCardAddresses[i, j] == address)
                        {
                            //Address is called, this slot is now true on the progress card
                            bingoCardProgress[i, j] = true;
                        }
                    }
                }
            }
            internal int detectWins(string winType, List<bool[,]> winningPatterns = null)
            {
                //Returns the number of wins for the card
                switch (winType)
                {
                    case "Regular":
                        //Regular game, check 5-in-a-row
                        return FiveInARow(bingoCardProgress);

                    case "Custom":
                        //Custom game, check patterns
                        return CustomPatternMatches(bingoCardProgress);

                    default:
                        break;
                }
                return -1;


                //Defining the various win types
                int FiveInARow(bool[,] bingoCard)
                {
                    string[] currentAddresses = new string[5];
                    //This function counts the number of 5-in-a-rows are present on a card
                    int totalWins = 0;

                    //Test Horizontal 5 in a rows
                    for (int i = 0; i < bingoCard.GetLength(0); i++)
                    {

                        currentAddresses = GetRow(bingoCardAddresses, i);
                        bool currentRowWin = bingoCard[i, 0] & bingoCard[i, 1] & bingoCard[i, 2] & bingoCard[i, 3] & bingoCard[i, 4];
                        if (currentRowWin)
                        {
                            //Add Row Win to Collection
                            AddWinToCollection("Row", currentAddresses);
                            totalWins++;
                        }
                    }

                    //Test Vertical 5 in a rows
                    for (int j = 0; j < bingoCard.GetLength(1); j++)
                    {
                        currentAddresses = GetColumn(bingoCardAddresses, j);
                        bool currentColWin = bingoCard[0, j] & bingoCard[1, j] & bingoCard[2, j] & bingoCard[3, j] & bingoCard[4, j];
                        if (currentColWin)
                        {
                            //Add Col Win to Collection
                            AddWinToCollection("Column", currentAddresses);
                            totalWins++;
                        }
                    }

                    //Test 2 Diagonals
                    currentAddresses = new string[] { bingoCardAddresses[0, 0], bingoCardAddresses[1, 1], bingoCardAddresses[2, 2], bingoCardAddresses[3, 3], bingoCardAddresses[4, 4] };
                    bool TLtoBRDiagonalWin = bingoCard[0, 0] & bingoCard[1, 1] & bingoCard[2, 2] & bingoCard[3, 3] & bingoCard[4, 4];
                    if (TLtoBRDiagonalWin)
                    {
                        //Add Diagonal Win to Collection
                        AddWinToCollection("Diagonal", currentAddresses);
                        totalWins++;
                    }
                    currentAddresses = new string[] { bingoCardAddresses[0, 4], bingoCardAddresses[1, 3], bingoCardAddresses[2, 2], bingoCardAddresses[3, 1], bingoCardAddresses[4, 0] };
                    bool TRtoBLDiagonalWin = bingoCard[0, 4] & bingoCard[1, 3] & bingoCard[2, 2] & bingoCard[3, 1] & bingoCard[4, 0];
                    if (TRtoBLDiagonalWin)
                    {
                        //Add Diagonal Win to Collection
                        AddWinToCollection("Diagonal", currentAddresses);
                        totalWins++;
                    }

                    return totalWins;

                    string[] GetColumn(string[,] matrix, int columnNumber)
                    {
                        return Enumerable.Range(0, matrix.GetLength(0))
                                .Select(x => matrix[x, columnNumber])
                                .ToArray();
                    }

                    string[] GetRow(string[,] matrix, int rowNumber)
                    {
                        return Enumerable.Range(0, matrix.GetLength(1))
                                .Select(x => matrix[rowNumber, x])
                                .ToArray();
                    }
                }

                int CustomPatternMatches(bool[,] bingoCard)
                {
                    //Gives the number of winning patterns on a given bingo card
                    int numberOfMatchingPatterns = 0;
                    foreach (bool[,] wp in winningPatterns)
                    {
                        if (patternsEqual(wp, bingoCard))
                        {
                            //Patterns are equal, we need to collect the winning pattern and record a win
                            string[] winningPatternAddresses = new string[25];
                            int k = 0; //Counter to iterate through winning pattern addresses
                            for (int i = 0; i < wp.GetLength(0); i++)
                            {
                                for (int j = 0; j < wp.GetLength(1); j++)
                                {
                                    if (wp[i, j] == true)
                                    {
                                        winningPatternAddresses[k] = bingoCardAddresses[i, j];
                                        k++;
                                    }
                                }
                            }
                            AddWinToCollection("Custom", winningPatternAddresses);
                            numberOfMatchingPatterns++;
                        }
                    }

                    return numberOfMatchingPatterns;
                }

                void AddWinToCollection(string name, string[] inputAddresses)
                {
                    //Add Win to Collection
                    if (!winCollection.ContainsKey(name))
                    {
                        winCollection.Add(name, new List<string[]>());
                    }
                    //Test if the win has already been captured
                    bool winAlreadyExists = false;
                    foreach (string[] winAddress in winCollection[name])
                    {
                        int numIndeciesSame = 0;
                        for (int i = 0; i < winAddress.Length; i++)
                        {
                            if (winAddress[i] == inputAddresses[i])
                            {
                                numIndeciesSame++;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        if (numIndeciesSame == winAddress.Length)
                        {
                            //Win has already been counted
                            winAlreadyExists = true;
                        }
                    }
                    if (!winAlreadyExists)
                    {
                        //Win has not been added yet
                        winCollection[name].Add(inputAddresses);
                    }

                }
            }
            internal void ClearCard()
            {
                //Clear card if the game resets
                winCollection.Clear();
                this.bingoCardProgress = new bool[5,5];
                //For freespace
                this.bingoCardProgress[2, 2] = true;
            }
            internal void ClearCustomWins()
            {
                if (winCollection.ContainsKey("Custom"))
                {
                    winCollection.Remove("Custom");
                }
            }
        }

        List<int> ballsRequiredToWin = new List<int>();
        List<string> winningStrings = new List<string>();
        List<bool[,]> winningPatterns = new List<bool[,]>();
        List<string> bingoBallsCalled = new List<string>();
        Dictionary<string, List<BingoCard>> MajorBingoCardSet = new Dictionary<string, List<BingoCard>>();
        int winningPatternQuantity = 0;
        bool letsPlay = false;
        string executablePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            InitializeSettings();

            string pathToCardData = executablePath + @"\BINGO Inputs\CardData";
            string pathToCardPDF = executablePath + @"\BINGO Inputs\CardPictures";
            //Collect card data in to 2D arrays
            foreach (string cardData in Directory.GetFiles(pathToCardData))
            {
                string minorCardName = Path.GetFileName(cardData).Replace(".txt", "");

                string majorCardName = minorCardName.Substring(0, minorCardName.IndexOf("_"));
                string majorCardFullPath = pathToCardPDF + @"\" + majorCardName + ".pdf";
                
                if (!MajorBingoCardSet.ContainsKey(majorCardFullPath))
                {
                    List<BingoCard> bingoCardSet = new List<BingoCard>();
                    MajorBingoCardSet.Add(majorCardFullPath, bingoCardSet);
                }

                //Extract card data into 2D string array
                string[,] bingoCardData = new string[5, 5];
                string[] dataLines = File.ReadAllLines(cardData);
                for (int i = 0; i < dataLines.Length; i++)
                {
                    string currentRow = dataLines[i];
                    string[] currentRowData = currentRow.Split('\t');

                    for (int j = 0; j < currentRowData.Length; j++)
                    {
                        bingoCardData[i, j] = currentRowData[j];
                    }
                }
                BingoCard tmpBingoCard = new BingoCard(minorCardName, bingoCardData);
                MajorBingoCardSet[majorCardFullPath].Add(tmpBingoCard);
            }
            void InitializeSettings()
            {
                patternQuantityToWin.Text = Properties.Settings.Default.numberOfWinsReqInt.ToString();
                OnePatternPerCardCheckbox.Checked = Properties.Settings.Default.OnlyOnePerBoard;
                RegularBingoRadioButton.Checked = Properties.Settings.Default.RegularGameRadioToggled;
                CustomBingoGameRadioButton.Checked = Properties.Settings.Default.CustomGameRadioToggled;
                autoReplayCheck.Checked = Properties.Settings.Default.AutoReplay;
                AutoDealCheckbox.Checked = Properties.Settings.Default.AutoDealChecked;
            }
        }
        private void playGame(bool sim = false)
        {
            SetSettings();
            if (!letsPlay)
            {
                letsPlay = true;
                bool win = false;
                string gameType = RegularBingoRadioButton.Checked ? "Regular" : "Custom";
                int quantityToWin = Convert.ToInt32(patternQuantityToWin.Text);
                bool onlyOneWinPerCard = OnePatternPerCardCheckbox.Checked;

                List<string> winningCards = new List<string>();
                while (!win)
                {
                    int xcoord = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                    int ycoord = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                    string input = "";
                    if (AutoDealCheckbox.Checked)
                    {
                        //Balls will automatically be played
                        input = GenerateBingoBall();
                    }
                    else
                    {
                        //User-prompted input for balls
                        input = Interaction.InputBox("Input BINGO addresses as they come!\nHit Cancel to exit the game.\nType CLEAR to clear cards", "Bingo Time!", "", xcoord, ycoord);
                    }
                    if (input == "")
                    {
                        //User wants to get out of the game
                        break;
                    }
                    if (input == "CLEAR")
                    {
                        //User wants to clear all bingo cards
                        ClearAllCards();
                        continue;
                    }
                    bingoBallsCalled.Add(input);
                    foreach (KeyValuePair<string, List<BingoCard>> MajorSet in MajorBingoCardSet)
                    {
                        int numberOfWinsForMajor = 0;
                        foreach (BingoCard bc in MajorSet.Value)
                        {
                            bc.TestAddress(input);
                            int numberOfWinsOnCard = bc.detectWins(gameType, winningPatterns);
                            if (numberOfWinsOnCard > 0)
                            {
                                //Some wins detected, allow all or just one per card
                                numberOfWinsOnCard = onlyOneWinPerCard ? 1 : numberOfWinsOnCard;
                            }
                            numberOfWinsForMajor += numberOfWinsOnCard;
                        }
                        if (numberOfWinsForMajor >= quantityToWin)
                        {
                            //BINGO!!
                            winningCards.Add(MajorSet.Key);
                            win = true;
                        }
                    }
                }
                if (win)
                {
                    //Winner found!
                    bool newWinDetected = false;
                    foreach (string winningCardAddress in winningCards)
                    {
                        foreach (BingoCard bc in MajorBingoCardSet[winningCardAddress])
                        {

                            Dictionary<string, List<string[]>> winDic = bc.CollectWins();
                            if (winDic.Count > 0)
                            {
                                foreach (KeyValuePair<string, List<string[]>> entry in winDic)
                                {
                                    string typeOfWin = entry.Key;
                                    foreach (string[] winAddresses in entry.Value)
                                    {
                                        string winString = bc.GetName() + ": " + typeOfWin + " win found at " + string.Join(" ", winAddresses);
                                        if (!winningStrings.Contains(winString))
                                        {
                                            //New type of win found, add it to winning strings
                                            newWinDetected = true;
                                            winningStrings.Add(winString);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (newWinDetected == true)
                    {
                        foreach (string winningCardAddress in winningCards)
                        {
                            //New win found, update UI if it is not a sim
                            if (!sim)
                            {
                                System.Diagnostics.Process.Start(winningCardAddress);
                            }
                            foreach (string str in winningStrings)
                            {
                                bool valAlreadyInData = false;
                                if (winningView.Rows.Count == 0)
                                {
                                    //Very first win, add the balls required.
                                    ballsRequiredToWin.Add(bingoBallsCalled.Count());
                                    if (sim)
                                    {
                                        //Simulation, we are just collecting balls required to win
                                        letsPlay = false;
                                        return;
                                    }
                                }
                                foreach (DataGridViewRow r in winningView.Rows)
                                {
                                    if (r.Cells[0].Value.ToString() == str)
                                    {
                                        //Value is already added
                                        valAlreadyInData = true;
                                    }
                                }
                                if (!valAlreadyInData)
                                {
                                    winningView.Rows.Add(str, bingoBallsCalled.Count);
                                }
                            }
                        }
                    }
                    if (autoReplayCheck.Checked == true)
                    {
                        letsPlay = false;
                        playGame();
                        if (bingoBallsCalled.Count == 75)
                        {
                            //All balls have been called
                            return;
                        }
                    }
                
                }
                else
                {
                    //Game has ended
                    letsPlay = false;
                }
            }
            else
            {
                MessageBox.Show("Game is in progress!");
            }

            void SetSettings()
            {
                int result;
                bool canParseInt = int.TryParse(patternQuantityToWin.Text, out result);
                if (canParseInt)
                {
                    Properties.Settings.Default.numberOfWinsReqInt = Convert.ToInt32(result);
                }
                Properties.Settings.Default.OnlyOnePerBoard = OnePatternPerCardCheckbox.Checked;
                Properties.Settings.Default.RegularGameRadioToggled = RegularBingoRadioButton.Checked;
                Properties.Settings.Default.CustomGameRadioToggled = !RegularBingoRadioButton.Checked;
                Properties.Settings.Default.AutoReplay = autoReplayCheck.Checked;
                Properties.Settings.Default.AutoDealChecked = AutoDealCheckbox.Checked;
                Properties.Settings.Default.Save();
            }
            string GenerateBingoBall()
            {
                string[] bingoLetters = new string[] { "B", "I", "N", "G", "O" };
                string bingoNumber = "";
                var rand = new Random();
                for (int i = 0; i < 10000; i++)
                {
                    //Try to find new bingo combo in 10000 iterations
                    string bingoLetter = bingoLetters[rand.Next(5)];
                    switch (bingoLetter)
                    {
                        case "B":
                            bingoNumber = rand.Next(1, 16).ToString();
                            break;
                        case "I":
                            bingoNumber = rand.Next(16, 31).ToString();
                            break;
                        case "N":
                            bingoNumber = rand.Next(31, 46).ToString();
                            break;
                        case "G":
                            bingoNumber = rand.Next(46, 61).ToString();
                            break;
                        case "O":
                            bingoNumber = rand.Next(61, 76).ToString();
                            break;
                        default:
                            break;
                    }
                    string bingoBall = bingoLetter + bingoNumber;
                    if (!bingoBallsCalled.Contains(bingoBall))
                    {
                        return bingoBall;
                    }
                }
                //All balls assumedly have been called
                return "";
            }

        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            int numberOfGamesToPlay = 1;
            if (AutoDealCheckbox.Checked)
            {
                //User-prompted input for balls
                string input = Interaction.InputBox("How many games do you want to simulate?", "Bingo Sim!", "", 300, 300);
                bool inputIsNumber = int.TryParse(input, out numberOfGamesToPlay);
                if (!inputIsNumber)
                {
                    numberOfGamesToPlay = 1;
                }
            }
            bool simulation = numberOfGamesToPlay > 1 ? true : false;
            for (int i = 0; i < numberOfGamesToPlay; i++)
            {
                ClearAllCards();
                winningView.Rows.Clear();
                bingoBallsCalled.Clear();
                winningStrings.Clear();
                playGame(simulation);
            }
            if (ballsRequiredToWin.Count > 0)
            {
                MessageBox.Show("Average Balls to win: " + ballsRequiredToWin.Average() + "\r\nNumber of games total played: " + numberOfGamesToPlay);
            }
        }

        private void AddNewPattern_Click(object sender, EventArgs e)
        {
            bool[,] winningPattern = new bool[5, 5];
            //First Row
            winningPattern[0, 0] = B0.Checked;
            winningPattern[0, 1] = I0.Checked;
            winningPattern[0, 2] = N0.Checked;
            winningPattern[0, 3] = G0.Checked;
            winningPattern[0, 4] = O0.Checked;

            //Second Row
            winningPattern[1, 0] = B1.Checked;
            winningPattern[1, 1] = I1.Checked;
            winningPattern[1, 2] = N1.Checked;
            winningPattern[1, 3] = G1.Checked;
            winningPattern[1, 4] = O1.Checked;

            //Third Row
            winningPattern[2, 0] = B2.Checked;
            winningPattern[2, 1] = I2.Checked;
            winningPattern[2, 2] = N2.Checked;
            winningPattern[2, 3] = G2.Checked;
            winningPattern[2, 4] = O2.Checked;

            //Fourth Row
            winningPattern[3, 0] = B3.Checked;
            winningPattern[3, 1] = I3.Checked;
            winningPattern[3, 2] = N3.Checked;
            winningPattern[3, 3] = G3.Checked;
            winningPattern[3, 4] = O3.Checked;

            //Fifth Row
            winningPattern[4, 0] = B4.Checked;
            winningPattern[4, 1] = I4.Checked;
            winningPattern[4, 2] = N4.Checked;
            winningPattern[4, 3] = G4.Checked;
            winningPattern[4, 4] = O4.Checked;

            //See if we already saved the pattern
            foreach (bool[,] p in winningPatterns)
            {
                if (patternsEqual(p, winningPattern, true))
                {
                    return;
                }
            }
            
            //If the pattern is new, save it
            winningPatterns.Add(winningPattern);
            winningPatternQuantity++;
            winningPatternQuantityLabel.Text = winningPatternQuantity.ToString();
        }
       
        private void ClearAllCards()
        {
            foreach (List<BingoCard> bcSet in MajorBingoCardSet.Values)
            {
                foreach (BingoCard bc in bcSet)
                {
                    bc.ClearCard();
                }
            }
        }
        private static bool patternsEqual(bool[,] masterPattern, bool[,] testPattern, bool exactMatch = false)
        {
            bool patternsSame = false;

            bool pattern1LengthIs5 = masterPattern.GetLength(0) == 5;
            bool pattern1WidthIs5 = masterPattern.GetLength(1) == 5;
            bool masterPatternIsValid = pattern1LengthIs5 & pattern1WidthIs5;

            bool pattern2LengthIs5 = testPattern.GetLength(0) == 5;
            bool pattern2WidthIs5 = testPattern.GetLength(1) == 5;
            bool testPatternIsValid = pattern2LengthIs5 & pattern2WidthIs5;

            if (!masterPatternIsValid || !testPatternIsValid)
            {
                return false;
            }


            //Patterns are valid 5x5's, compare their sequences
            if (!exactMatch)
            {
                //Check if the test matches the master
                for (int i = 0; i < masterPattern.GetLength(0); i++)
                {
                    for (int j = 0; j < masterPattern.GetLength(1); j++)
                    {
                        if (masterPattern[i, j])
                        {
                            //The Cell Must Be The Same
                            if (!testPattern[i,j])
                            {
                                //testPatternFailed
                                patternsSame = false;
                                return patternsSame;
                            }
                        }
                    }
                }
                patternsSame = true;
                return patternsSame;
            }
            else
            {
                //Compare the sequences exactly
                patternsSame = masterPattern.Cast<bool>().SequenceEqual(testPattern.Cast<bool>());
                return patternsSame;
            }
        }

        private void clearPatternsButton_Click(object sender, EventArgs e)
        {
            winningPatternQuantity = 0;
            winningPatternQuantityLabel.Text = "0";
            winningPatterns.Clear();
            foreach (List<BingoCard> bcList in MajorBingoCardSet.Values)
            {
                foreach (BingoCard bc in bcList)
                {
                    bc.ClearCustomWins();
                }
            }
        }

        private void N2_ClickOnFreeSpaceLikeAnIdiot(object sender, EventArgs e)
        {
            MessageBox.Show("Are you crazy?? Are you out of your mind???");
        }
    }
}
