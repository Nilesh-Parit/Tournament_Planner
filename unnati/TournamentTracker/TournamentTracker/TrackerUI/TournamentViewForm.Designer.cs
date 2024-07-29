namespace TrackerUI
{
    partial class TournamentViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            label1 = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCkeckbox = new CheckBox();
            MatchupListBox = new ListBox();
            TeamOneName = new Label();
            TeamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            TeamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            scoreButton = new Button();
            versusLabel = new Label();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 19);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(214, 50);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(222, 19);
            label1.Name = "label1";
            label1.Size = new Size(150, 50);
            label1.TabIndex = 1;
            label1.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundLabel.ForeColor = SystemColors.MenuHighlight;
            roundLabel.Location = new Point(39, 80);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(90, 37);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(148, 83);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(200, 38);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCkeckbox
            // 
            unplayedOnlyCkeckbox.AutoSize = true;
            unplayedOnlyCkeckbox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCkeckbox.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unplayedOnlyCkeckbox.ForeColor = SystemColors.MenuHighlight;
            unplayedOnlyCkeckbox.Location = new Point(148, 127);
            unplayedOnlyCkeckbox.Name = "unplayedOnlyCkeckbox";
            unplayedOnlyCkeckbox.Size = new Size(199, 41);
            unplayedOnlyCkeckbox.TabIndex = 4;
            unplayedOnlyCkeckbox.Text = "Unplayed Only";
            unplayedOnlyCkeckbox.UseVisualStyleBackColor = true;
            // 
            // MatchupListBox
            // 
            MatchupListBox.BorderStyle = BorderStyle.FixedSingle;
            MatchupListBox.FormattingEnabled = true;
            MatchupListBox.ItemHeight = 30;
            MatchupListBox.Location = new Point(30, 186);
            MatchupListBox.Name = "MatchupListBox";
            MatchupListBox.Size = new Size(318, 272);
            MatchupListBox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            TeamOneName.AutoSize = true;
            TeamOneName.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneName.ForeColor = SystemColors.MenuHighlight;
            TeamOneName.Location = new Point(382, 191);
            TeamOneName.Name = "TeamOneName";
            TeamOneName.Size = new Size(160, 37);
            TeamOneName.TabIndex = 6;
            TeamOneName.Text = "<team one>";
            // 
            // TeamOneScoreLabel
            // 
            TeamOneScoreLabel.AutoSize = true;
            TeamOneScoreLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            TeamOneScoreLabel.Location = new Point(382, 238);
            TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            TeamOneScoreLabel.Size = new Size(79, 37);
            TeamOneScoreLabel.TabIndex = 8;
            TeamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(466, 241);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(122, 35);
            teamOneScoreValue.TabIndex = 9;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(468, 395);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(122, 35);
            teamTwoScoreValue.TabIndex = 12;
            // 
            // TeamTwoScoreLabel
            // 
            TeamTwoScoreLabel.AutoSize = true;
            TeamTwoScoreLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamTwoScoreLabel.ForeColor = SystemColors.MenuHighlight;
            TeamTwoScoreLabel.Location = new Point(384, 392);
            TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            TeamTwoScoreLabel.Size = new Size(79, 37);
            TeamTwoScoreLabel.TabIndex = 11;
            TeamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamTwoName.ForeColor = SystemColors.MenuHighlight;
            teamTwoName.Location = new Point(382, 346);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(158, 37);
            teamTwoName.TabIndex = 10;
            teamTwoName.Text = "<team two>";
            teamTwoName.Click += teamTwoName_Click;
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = SystemColors.MenuHighlight;
            scoreButton.Location = new Point(616, 298);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(119, 37);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            versusLabel.ForeColor = SystemColors.MenuHighlight;
            versusLabel.Location = new Point(445, 295);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(67, 37);
            versusLabel.TabIndex = 14;
            versusLabel.Text = "-VS-";
            // 
            // TournamentViewForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 515);
            Controls.Add(versusLabel);
            Controls.Add(scoreButton);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(TeamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(TeamOneScoreLabel);
            Controls.Add(TeamOneName);
            Controls.Add(MatchupListBox);
            Controls.Add(unplayedOnlyCkeckbox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(label1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewForm";
            Text = "Tournament Viewer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label label1;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCkeckbox;
        private ListBox MatchupListBox;
        private Label TeamOneName;
        private Label TeamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label TeamTwoScoreLabel;
        private Label teamTwoName;
        private Button scoreButton;
        private Label versusLabel;
    }
}
