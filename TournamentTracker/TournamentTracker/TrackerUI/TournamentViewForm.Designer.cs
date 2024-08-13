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
            TournamentName = new Label();
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
            headerLabel.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(64, 0, 0);
            headerLabel.Location = new Point(268, 30);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(225, 42);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold);
            TournamentName.ForeColor = Color.FromArgb(64, 0, 0);
            TournamentName.Location = new Point(496, 30);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(136, 42);
            TournamentName.TabIndex = 1;
            TournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            roundLabel.ForeColor = Color.Tomato;
            roundLabel.Location = new Point(214, 117);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(97, 32);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(323, 119);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(409, 35);
            roundDropDown.TabIndex = 3;
            roundDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
            // 
            // unplayedOnlyCkeckbox
            // 
            unplayedOnlyCkeckbox.AutoSize = true;
            unplayedOnlyCkeckbox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCkeckbox.Font = new Font("Times New Roman", 20.25F);
            unplayedOnlyCkeckbox.ForeColor = Color.DarkOrange;
            unplayedOnlyCkeckbox.Location = new Point(451, 197);
            unplayedOnlyCkeckbox.Name = "unplayedOnlyCkeckbox";
            unplayedOnlyCkeckbox.Size = new Size(197, 35);
            unplayedOnlyCkeckbox.TabIndex = 4;
            unplayedOnlyCkeckbox.Text = "Unplayed Only";
            unplayedOnlyCkeckbox.UseVisualStyleBackColor = true;
            unplayedOnlyCkeckbox.CheckedChanged += unplayedOnlyCkeckbox_CheckedChanged;
            // 
            // MatchupListBox
            // 
            MatchupListBox.BorderStyle = BorderStyle.FixedSingle;
            MatchupListBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MatchupListBox.FormattingEnabled = true;
            MatchupListBox.ItemHeight = 23;
            MatchupListBox.Location = new Point(68, 197);
            MatchupListBox.Name = "MatchupListBox";
            MatchupListBox.Size = new Size(344, 301);
            MatchupListBox.TabIndex = 5;
            MatchupListBox.SelectedIndexChanged += MatchupListBox_SelectedIndexChanged;
            // 
            // TeamOneName
            // 
            TeamOneName.AutoSize = true;
            TeamOneName.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            TeamOneName.ForeColor = Color.Tomato;
            TeamOneName.Location = new Point(451, 292);
            TeamOneName.Name = "TeamOneName";
            TeamOneName.Size = new Size(159, 32);
            TeamOneName.TabIndex = 6;
            TeamOneName.Text = "<team one>";
            // 
            // TeamOneScoreLabel
            // 
            TeamOneScoreLabel.AutoSize = true;
            TeamOneScoreLabel.Font = new Font("Times New Roman", 20.25F);
            TeamOneScoreLabel.ForeColor = Color.DarkOrange;
            TeamOneScoreLabel.Location = new Point(451, 334);
            TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            TeamOneScoreLabel.Size = new Size(76, 31);
            TeamOneScoreLabel.TabIndex = 8;
            TeamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(542, 337);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(85, 35);
            teamOneScoreValue.TabIndex = 9;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(859, 337);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(85, 35);
            teamTwoScoreValue.TabIndex = 12;
            // 
            // TeamTwoScoreLabel
            // 
            TeamTwoScoreLabel.AutoSize = true;
            TeamTwoScoreLabel.Font = new Font("Times New Roman", 20.25F);
            TeamTwoScoreLabel.ForeColor = Color.DarkOrange;
            TeamTwoScoreLabel.Location = new Point(768, 334);
            TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            TeamTwoScoreLabel.Size = new Size(76, 31);
            TeamTwoScoreLabel.TabIndex = 11;
            TeamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            teamTwoName.ForeColor = Color.Tomato;
            teamTwoName.Location = new Point(766, 292);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(160, 32);
            teamTwoName.TabIndex = 10;
            teamTwoName.Text = "<team two>";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = Color.Maroon;
            scoreButton.Location = new Point(605, 444);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(187, 54);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            scoreButton.Click += scoreButton_Click;
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            versusLabel.ForeColor = Color.Tomato;
            versusLabel.Location = new Point(665, 321);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(74, 31);
            versusLabel.TabIndex = 14;
            versusLabel.Text = "-V/S-";
            versusLabel.Click += versusLabel_Click;
            // 
            // TournamentViewForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(984, 561);
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
            Controls.Add(TournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "TournamentViewForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label TournamentName;
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
