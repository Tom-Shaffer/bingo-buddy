
namespace Bingo_DesktopApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patternQuantityToWin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegularBingoRadioButton = new System.Windows.Forms.RadioButton();
            this.CustomBingoGameRadioButton = new System.Windows.Forms.RadioButton();
            this.OnePatternPerCardCheckbox = new System.Windows.Forms.CheckBox();
            this.AddNewPattern = new System.Windows.Forms.Button();
            this.PALabel = new System.Windows.Forms.Label();
            this.winningPatternQuantityLabel = new System.Windows.Forms.Label();
            this.clearPatternsButton = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.CheckBox();
            this.I0 = new System.Windows.Forms.CheckBox();
            this.N0 = new System.Windows.Forms.CheckBox();
            this.G0 = new System.Windows.Forms.CheckBox();
            this.O0 = new System.Windows.Forms.CheckBox();
            this.O1 = new System.Windows.Forms.CheckBox();
            this.G1 = new System.Windows.Forms.CheckBox();
            this.N1 = new System.Windows.Forms.CheckBox();
            this.I1 = new System.Windows.Forms.CheckBox();
            this.B1 = new System.Windows.Forms.CheckBox();
            this.O2 = new System.Windows.Forms.CheckBox();
            this.G2 = new System.Windows.Forms.CheckBox();
            this.N2 = new System.Windows.Forms.CheckBox();
            this.I2 = new System.Windows.Forms.CheckBox();
            this.B2 = new System.Windows.Forms.CheckBox();
            this.O3 = new System.Windows.Forms.CheckBox();
            this.G3 = new System.Windows.Forms.CheckBox();
            this.N3 = new System.Windows.Forms.CheckBox();
            this.I3 = new System.Windows.Forms.CheckBox();
            this.B3 = new System.Windows.Forms.CheckBox();
            this.O4 = new System.Windows.Forms.CheckBox();
            this.G4 = new System.Windows.Forms.CheckBox();
            this.N4 = new System.Windows.Forms.CheckBox();
            this.I4 = new System.Windows.Forms.CheckBox();
            this.B4 = new System.Windows.Forms.CheckBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.autoReplayCheck = new System.Windows.Forms.CheckBox();
            this.winningView = new System.Windows.Forms.DataGridView();
            this.WinsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfTurnsToAchieve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoDealCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.winningView)).BeginInit();
            this.SuspendLayout();
            // 
            // patternQuantityToWin
            // 
            this.patternQuantityToWin.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.patternQuantityToWin.Location = new System.Drawing.Point(13, 27);
            this.patternQuantityToWin.Name = "patternQuantityToWin";
            this.patternQuantityToWin.Size = new System.Drawing.Size(28, 20);
            this.patternQuantityToWin.TabIndex = 0;
            this.patternQuantityToWin.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pattern Quantity to Win";
            // 
            // RegularBingoRadioButton
            // 
            this.RegularBingoRadioButton.AutoSize = true;
            this.RegularBingoRadioButton.Checked = true;
            this.RegularBingoRadioButton.Location = new System.Drawing.Point(12, 79);
            this.RegularBingoRadioButton.Name = "RegularBingoRadioButton";
            this.RegularBingoRadioButton.Size = new System.Drawing.Size(99, 17);
            this.RegularBingoRadioButton.TabIndex = 2;
            this.RegularBingoRadioButton.TabStop = true;
            this.RegularBingoRadioButton.Text = "Regular Pattern";
            this.RegularBingoRadioButton.UseVisualStyleBackColor = true;
            // 
            // CustomBingoGameRadioButton
            // 
            this.CustomBingoGameRadioButton.AutoSize = true;
            this.CustomBingoGameRadioButton.Location = new System.Drawing.Point(12, 101);
            this.CustomBingoGameRadioButton.Name = "CustomBingoGameRadioButton";
            this.CustomBingoGameRadioButton.Size = new System.Drawing.Size(102, 17);
            this.CustomBingoGameRadioButton.TabIndex = 3;
            this.CustomBingoGameRadioButton.Text = "Custom Patterns";
            this.CustomBingoGameRadioButton.UseVisualStyleBackColor = true;
            // 
            // OnePatternPerCardCheckbox
            // 
            this.OnePatternPerCardCheckbox.AutoSize = true;
            this.OnePatternPerCardCheckbox.Location = new System.Drawing.Point(12, 52);
            this.OnePatternPerCardCheckbox.Name = "OnePatternPerCardCheckbox";
            this.OnePatternPerCardCheckbox.Size = new System.Drawing.Size(151, 17);
            this.OnePatternPerCardCheckbox.TabIndex = 4;
            this.OnePatternPerCardCheckbox.Text = "Only One Pattern-Per-Card";
            this.OnePatternPerCardCheckbox.UseVisualStyleBackColor = true;
            // 
            // AddNewPattern
            // 
            this.AddNewPattern.Location = new System.Drawing.Point(12, 124);
            this.AddNewPattern.Name = "AddNewPattern";
            this.AddNewPattern.Size = new System.Drawing.Size(75, 23);
            this.AddNewPattern.TabIndex = 5;
            this.AddNewPattern.Text = "Add Pattern";
            this.AddNewPattern.UseVisualStyleBackColor = true;
            this.AddNewPattern.Click += new System.EventHandler(this.AddNewPattern_Click);
            // 
            // PALabel
            // 
            this.PALabel.AutoSize = true;
            this.PALabel.Location = new System.Drawing.Point(21, 192);
            this.PALabel.Name = "PALabel";
            this.PALabel.Size = new System.Drawing.Size(80, 13);
            this.PALabel.TabIndex = 6;
            this.PALabel.Text = "Patterns Added";
            // 
            // winningPatternQuantityLabel
            // 
            this.winningPatternQuantityLabel.AutoSize = true;
            this.winningPatternQuantityLabel.Location = new System.Drawing.Point(12, 192);
            this.winningPatternQuantityLabel.Name = "winningPatternQuantityLabel";
            this.winningPatternQuantityLabel.Size = new System.Drawing.Size(13, 13);
            this.winningPatternQuantityLabel.TabIndex = 7;
            this.winningPatternQuantityLabel.Text = "0";
            // 
            // clearPatternsButton
            // 
            this.clearPatternsButton.Location = new System.Drawing.Point(13, 153);
            this.clearPatternsButton.Name = "clearPatternsButton";
            this.clearPatternsButton.Size = new System.Drawing.Size(67, 36);
            this.clearPatternsButton.TabIndex = 8;
            this.clearPatternsButton.Text = "Clear Patterns";
            this.clearPatternsButton.UseVisualStyleBackColor = true;
            this.clearPatternsButton.Click += new System.EventHandler(this.clearPatternsButton_Click);
            // 
            // B0
            // 
            this.B0.AutoSize = true;
            this.B0.Location = new System.Drawing.Point(122, 124);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(15, 14);
            this.B0.TabIndex = 9;
            this.B0.UseVisualStyleBackColor = true;
            // 
            // I0
            // 
            this.I0.AutoSize = true;
            this.I0.Location = new System.Drawing.Point(143, 124);
            this.I0.Name = "I0";
            this.I0.Size = new System.Drawing.Size(15, 14);
            this.I0.TabIndex = 10;
            this.I0.UseVisualStyleBackColor = true;
            // 
            // N0
            // 
            this.N0.AutoSize = true;
            this.N0.Location = new System.Drawing.Point(164, 124);
            this.N0.Name = "N0";
            this.N0.Size = new System.Drawing.Size(15, 14);
            this.N0.TabIndex = 11;
            this.N0.UseVisualStyleBackColor = true;
            // 
            // G0
            // 
            this.G0.AutoSize = true;
            this.G0.Location = new System.Drawing.Point(185, 124);
            this.G0.Name = "G0";
            this.G0.Size = new System.Drawing.Size(15, 14);
            this.G0.TabIndex = 12;
            this.G0.UseVisualStyleBackColor = true;
            // 
            // O0
            // 
            this.O0.AutoSize = true;
            this.O0.Location = new System.Drawing.Point(206, 124);
            this.O0.Name = "O0";
            this.O0.Size = new System.Drawing.Size(15, 14);
            this.O0.TabIndex = 13;
            this.O0.UseVisualStyleBackColor = true;
            // 
            // O1
            // 
            this.O1.AutoSize = true;
            this.O1.Location = new System.Drawing.Point(206, 144);
            this.O1.Name = "O1";
            this.O1.Size = new System.Drawing.Size(15, 14);
            this.O1.TabIndex = 18;
            this.O1.UseVisualStyleBackColor = true;
            // 
            // G1
            // 
            this.G1.AutoSize = true;
            this.G1.Location = new System.Drawing.Point(185, 144);
            this.G1.Name = "G1";
            this.G1.Size = new System.Drawing.Size(15, 14);
            this.G1.TabIndex = 17;
            this.G1.UseVisualStyleBackColor = true;
            // 
            // N1
            // 
            this.N1.AutoSize = true;
            this.N1.Location = new System.Drawing.Point(164, 144);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(15, 14);
            this.N1.TabIndex = 16;
            this.N1.UseVisualStyleBackColor = true;
            // 
            // I1
            // 
            this.I1.AutoSize = true;
            this.I1.Location = new System.Drawing.Point(143, 144);
            this.I1.Name = "I1";
            this.I1.Size = new System.Drawing.Size(15, 14);
            this.I1.TabIndex = 15;
            this.I1.UseVisualStyleBackColor = true;
            // 
            // B1
            // 
            this.B1.AutoSize = true;
            this.B1.Location = new System.Drawing.Point(122, 144);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(15, 14);
            this.B1.TabIndex = 14;
            this.B1.UseVisualStyleBackColor = true;
            // 
            // O2
            // 
            this.O2.AutoSize = true;
            this.O2.Location = new System.Drawing.Point(206, 164);
            this.O2.Name = "O2";
            this.O2.Size = new System.Drawing.Size(15, 14);
            this.O2.TabIndex = 23;
            this.O2.UseVisualStyleBackColor = true;
            // 
            // G2
            // 
            this.G2.AutoSize = true;
            this.G2.Location = new System.Drawing.Point(185, 165);
            this.G2.Name = "G2";
            this.G2.Size = new System.Drawing.Size(15, 14);
            this.G2.TabIndex = 22;
            this.G2.UseVisualStyleBackColor = true;
            // 
            // N2
            // 
            this.N2.AutoCheck = false;
            this.N2.AutoSize = true;
            this.N2.Checked = true;
            this.N2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.N2.Location = new System.Drawing.Point(164, 164);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(15, 14);
            this.N2.TabIndex = 21;
            this.N2.UseVisualStyleBackColor = true;
            this.N2.Click += new System.EventHandler(this.N2_ClickOnFreeSpaceLikeAnIdiot);
            // 
            // I2
            // 
            this.I2.AutoSize = true;
            this.I2.Location = new System.Drawing.Point(143, 164);
            this.I2.Name = "I2";
            this.I2.Size = new System.Drawing.Size(15, 14);
            this.I2.TabIndex = 20;
            this.I2.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            this.B2.AutoSize = true;
            this.B2.Location = new System.Drawing.Point(122, 164);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(15, 14);
            this.B2.TabIndex = 19;
            this.B2.UseVisualStyleBackColor = true;
            // 
            // O3
            // 
            this.O3.AutoSize = true;
            this.O3.Location = new System.Drawing.Point(206, 184);
            this.O3.Name = "O3";
            this.O3.Size = new System.Drawing.Size(15, 14);
            this.O3.TabIndex = 28;
            this.O3.UseVisualStyleBackColor = true;
            // 
            // G3
            // 
            this.G3.AutoSize = true;
            this.G3.Location = new System.Drawing.Point(185, 184);
            this.G3.Name = "G3";
            this.G3.Size = new System.Drawing.Size(15, 14);
            this.G3.TabIndex = 27;
            this.G3.UseVisualStyleBackColor = true;
            // 
            // N3
            // 
            this.N3.AutoSize = true;
            this.N3.Location = new System.Drawing.Point(164, 184);
            this.N3.Name = "N3";
            this.N3.Size = new System.Drawing.Size(15, 14);
            this.N3.TabIndex = 26;
            this.N3.UseVisualStyleBackColor = true;
            // 
            // I3
            // 
            this.I3.AutoSize = true;
            this.I3.Location = new System.Drawing.Point(143, 184);
            this.I3.Name = "I3";
            this.I3.Size = new System.Drawing.Size(15, 14);
            this.I3.TabIndex = 25;
            this.I3.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            this.B3.AutoSize = true;
            this.B3.Location = new System.Drawing.Point(122, 184);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(15, 14);
            this.B3.TabIndex = 24;
            this.B3.UseVisualStyleBackColor = true;
            // 
            // O4
            // 
            this.O4.AutoSize = true;
            this.O4.Location = new System.Drawing.Point(206, 204);
            this.O4.Name = "O4";
            this.O4.Size = new System.Drawing.Size(15, 14);
            this.O4.TabIndex = 33;
            this.O4.UseVisualStyleBackColor = true;
            // 
            // G4
            // 
            this.G4.AutoSize = true;
            this.G4.Location = new System.Drawing.Point(185, 204);
            this.G4.Name = "G4";
            this.G4.Size = new System.Drawing.Size(15, 14);
            this.G4.TabIndex = 32;
            this.G4.UseVisualStyleBackColor = true;
            // 
            // N4
            // 
            this.N4.AutoSize = true;
            this.N4.Location = new System.Drawing.Point(164, 204);
            this.N4.Name = "N4";
            this.N4.Size = new System.Drawing.Size(15, 14);
            this.N4.TabIndex = 31;
            this.N4.UseVisualStyleBackColor = true;
            // 
            // I4
            // 
            this.I4.AutoSize = true;
            this.I4.Location = new System.Drawing.Point(143, 204);
            this.I4.Name = "I4";
            this.I4.Size = new System.Drawing.Size(15, 14);
            this.I4.TabIndex = 30;
            this.I4.UseVisualStyleBackColor = true;
            // 
            // B4
            // 
            this.B4.AutoSize = true;
            this.B4.Location = new System.Drawing.Point(122, 204);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(15, 14);
            this.B4.TabIndex = 29;
            this.B4.UseVisualStyleBackColor = true;
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(152, 6);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 34;
            this.PlayButton.Text = "Let\'s Play!";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // autoReplayCheck
            // 
            this.autoReplayCheck.AutoSize = true;
            this.autoReplayCheck.Location = new System.Drawing.Point(152, 30);
            this.autoReplayCheck.Name = "autoReplayCheck";
            this.autoReplayCheck.Size = new System.Drawing.Size(84, 17);
            this.autoReplayCheck.TabIndex = 35;
            this.autoReplayCheck.Text = "Auto-Replay";
            this.autoReplayCheck.UseVisualStyleBackColor = true;
            // 
            // winningView
            // 
            this.winningView.AllowUserToAddRows = false;
            this.winningView.AllowUserToDeleteRows = false;
            this.winningView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winningView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.winningView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WinsColumn,
            this.numberOfTurnsToAchieve});
            this.winningView.Location = new System.Drawing.Point(231, 6);
            this.winningView.Name = "winningView";
            this.winningView.Size = new System.Drawing.Size(637, 212);
            this.winningView.TabIndex = 36;
            // 
            // WinsColumn
            // 
            this.WinsColumn.HeaderText = "Winning Combos";
            this.WinsColumn.Name = "WinsColumn";
            this.WinsColumn.Width = 400;
            // 
            // numberOfTurnsToAchieve
            // 
            this.numberOfTurnsToAchieve.HeaderText = "Ball#";
            this.numberOfTurnsToAchieve.Name = "numberOfTurnsToAchieve";
            // 
            // AutoDealCheckbox
            // 
            this.AutoDealCheckbox.AutoSize = true;
            this.AutoDealCheckbox.Location = new System.Drawing.Point(152, 80);
            this.AutoDealCheckbox.Name = "AutoDealCheckbox";
            this.AutoDealCheckbox.Size = new System.Drawing.Size(73, 17);
            this.AutoDealCheckbox.TabIndex = 37;
            this.AutoDealCheckbox.Text = "Auto-Deal";
            this.AutoDealCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 234);
            this.Controls.Add(this.AutoDealCheckbox);
            this.Controls.Add(this.winningView);
            this.Controls.Add(this.autoReplayCheck);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.O4);
            this.Controls.Add(this.G4);
            this.Controls.Add(this.N4);
            this.Controls.Add(this.I4);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.O3);
            this.Controls.Add(this.G3);
            this.Controls.Add(this.N3);
            this.Controls.Add(this.I3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.O2);
            this.Controls.Add(this.G2);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.I2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.O1);
            this.Controls.Add(this.G1);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.I1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.O0);
            this.Controls.Add(this.G0);
            this.Controls.Add(this.N0);
            this.Controls.Add(this.I0);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.clearPatternsButton);
            this.Controls.Add(this.winningPatternQuantityLabel);
            this.Controls.Add(this.PALabel);
            this.Controls.Add(this.AddNewPattern);
            this.Controls.Add(this.OnePatternPerCardCheckbox);
            this.Controls.Add(this.CustomBingoGameRadioButton);
            this.Controls.Add(this.RegularBingoRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patternQuantityToWin);
            this.MinimumSize = new System.Drawing.Size(255, 266);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BINGO App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.winningView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patternQuantityToWin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RegularBingoRadioButton;
        private System.Windows.Forms.RadioButton CustomBingoGameRadioButton;
        private System.Windows.Forms.CheckBox OnePatternPerCardCheckbox;
        private System.Windows.Forms.Button AddNewPattern;
        private System.Windows.Forms.Label PALabel;
        private System.Windows.Forms.Label winningPatternQuantityLabel;
        private System.Windows.Forms.Button clearPatternsButton;
        private System.Windows.Forms.CheckBox B0;
        private System.Windows.Forms.CheckBox I0;
        private System.Windows.Forms.CheckBox N0;
        private System.Windows.Forms.CheckBox G0;
        private System.Windows.Forms.CheckBox O0;
        private System.Windows.Forms.CheckBox O1;
        private System.Windows.Forms.CheckBox G1;
        private System.Windows.Forms.CheckBox N1;
        private System.Windows.Forms.CheckBox I1;
        private System.Windows.Forms.CheckBox B1;
        private System.Windows.Forms.CheckBox O2;
        private System.Windows.Forms.CheckBox G2;
        private System.Windows.Forms.CheckBox N2;
        private System.Windows.Forms.CheckBox I2;
        private System.Windows.Forms.CheckBox B2;
        private System.Windows.Forms.CheckBox O3;
        private System.Windows.Forms.CheckBox G3;
        private System.Windows.Forms.CheckBox N3;
        private System.Windows.Forms.CheckBox I3;
        private System.Windows.Forms.CheckBox B3;
        private System.Windows.Forms.CheckBox O4;
        private System.Windows.Forms.CheckBox G4;
        private System.Windows.Forms.CheckBox N4;
        private System.Windows.Forms.CheckBox I4;
        private System.Windows.Forms.CheckBox B4;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.CheckBox autoReplayCheck;
        private System.Windows.Forms.DataGridView winningView;
        private System.Windows.Forms.CheckBox AutoDealCheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfTurnsToAchieve;
    }
}

