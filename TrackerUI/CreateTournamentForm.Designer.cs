namespace TrackerUI
{
    partial class CreateTournamentForm
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
            createTournamentLabel = new Label();
            tournamentNameValue = new TextBox();
            TournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            EntryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewlinkLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            TournamentTeamsListBox = new ListBox();
            teamPlayerLabel = new Label();
            removeSelectedPlayersButton = new Button();
            removeSelectedPrizeButton = new Button();
            teamsPlayersLabel = new Label();
            PrizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold);
            createTournamentLabel.ForeColor = Color.FromArgb(64, 0, 0);
            createTournamentLabel.Location = new Point(309, 9);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(326, 42);
            createTournamentLabel.TabIndex = 1;
            createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(51, 135);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(355, 35);
            tournamentNameValue.TabIndex = 11;
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            TournamentNameLabel.ForeColor = Color.Tomato;
            TournamentNameLabel.Location = new Point(51, 90);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(243, 32);
            TournamentNameLabel.TabIndex = 10;
            TournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(203, 208);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(203, 35);
            entryFeeValue.TabIndex = 13;
            entryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            EntryFeeLabel.AutoSize = true;
            EntryFeeLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            EntryFeeLabel.ForeColor = Color.DarkOrange;
            EntryFeeLabel.Location = new Point(51, 211);
            EntryFeeLabel.Name = "EntryFeeLabel";
            EntryFeeLabel.Size = new Size(136, 32);
            EntryFeeLabel.TabIndex = 12;
            EntryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(51, 313);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(355, 35);
            selectTeamDropDown.TabIndex = 15;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            selectTeamLabel.ForeColor = Color.Tomato;
            selectTeamLabel.Location = new Point(51, 272);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(159, 32);
            selectTeamLabel.TabIndex = 14;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewlinkLabel
            // 
            createNewlinkLabel.AutoSize = true;
            createNewlinkLabel.LinkColor = Color.Red;
            createNewlinkLabel.Location = new Point(279, 277);
            createNewlinkLabel.Name = "createNewlinkLabel";
            createNewlinkLabel.Size = new Size(127, 27);
            createNewlinkLabel.TabIndex = 16;
            createNewlinkLabel.TabStop = true;
            createNewlinkLabel.Text = "Create New";
            createNewlinkLabel.LinkClicked += createNewlinkLabel_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Times New Roman", 20.25F);
            addTeamButton.ForeColor = Color.DarkOrange;
            addTeamButton.Location = new Point(102, 375);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(250, 36);
            addTeamButton.TabIndex = 17;
            addTeamButton.Text = "Add Team\r\n";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Times New Roman", 20.25F);
            createPrizeButton.ForeColor = Color.DarkOrange;
            createPrizeButton.Location = new Point(102, 422);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(250, 36);
            createPrizeButton.TabIndex = 18;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // TournamentTeamsListBox
            // 
            TournamentTeamsListBox.BorderStyle = BorderStyle.FixedSingle;
            TournamentTeamsListBox.Font = new Font("Times New Roman", 15.75F);
            TournamentTeamsListBox.FormattingEnabled = true;
            TournamentTeamsListBox.ItemHeight = 23;
            TournamentTeamsListBox.Location = new Point(476, 125);
            TournamentTeamsListBox.Name = "TournamentTeamsListBox";
            TournamentTeamsListBox.Size = new Size(344, 140);
            TournamentTeamsListBox.TabIndex = 19;
            TournamentTeamsListBox.SelectedIndexChanged += TournamentTeamsListBox_SelectedIndexChanged;
            // 
            // teamPlayerLabel
            // 
            teamPlayerLabel.AutoSize = true;
            teamPlayerLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            teamPlayerLabel.ForeColor = Color.Tomato;
            teamPlayerLabel.Location = new Point(476, 90);
            teamPlayerLabel.Name = "teamPlayerLabel";
            teamPlayerLabel.Size = new Size(203, 32);
            teamPlayerLabel.TabIndex = 20;
            teamPlayerLabel.Text = "Teams / Players";
            // 
            // removeSelectedPlayersButton
            // 
            removeSelectedPlayersButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            removeSelectedPlayersButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPlayersButton.Font = new Font("Times New Roman", 20.25F);
            removeSelectedPlayersButton.ForeColor = Color.DarkOrange;
            removeSelectedPlayersButton.Location = new Point(843, 166);
            removeSelectedPlayersButton.Name = "removeSelectedPlayersButton";
            removeSelectedPlayersButton.Size = new Size(129, 77);
            removeSelectedPlayersButton.TabIndex = 21;
            removeSelectedPlayersButton.Text = "Remove Selected";
            removeSelectedPlayersButton.UseVisualStyleBackColor = true;
            removeSelectedPlayersButton.Click += removeSelectedPlayersButton_Click;
            // 
            // removeSelectedPrizeButton
            // 
            removeSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            removeSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPrizeButton.Font = new Font("Times New Roman", 20.25F);
            removeSelectedPrizeButton.ForeColor = Color.DarkOrange;
            removeSelectedPrizeButton.Location = new Point(843, 355);
            removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            removeSelectedPrizeButton.Size = new Size(129, 77);
            removeSelectedPrizeButton.TabIndex = 24;
            removeSelectedPrizeButton.Text = "Remove Selected";
            removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            removeSelectedPrizeButton.Click += removeSelectedPrizeButton_Click;
            // 
            // teamsPlayersLabel
            // 
            teamsPlayersLabel.AutoSize = true;
            teamsPlayersLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            teamsPlayersLabel.ForeColor = Color.Tomato;
            teamsPlayersLabel.Location = new Point(476, 290);
            teamsPlayersLabel.Name = "teamsPlayersLabel";
            teamsPlayersLabel.Size = new Size(88, 32);
            teamsPlayersLabel.TabIndex = 23;
            teamsPlayersLabel.Text = "Prizes";
            // 
            // PrizesListBox
            // 
            PrizesListBox.BorderStyle = BorderStyle.FixedSingle;
            PrizesListBox.Font = new Font("Times New Roman", 15.75F);
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.ItemHeight = 23;
            PrizesListBox.Location = new Point(476, 325);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(344, 140);
            PrizesListBox.TabIndex = 22;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            createTournamentButton.ForeColor = Color.Maroon;
            createTournamentButton.Location = new Point(344, 499);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(335, 50);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(984, 561);
            Controls.Add(createTournamentButton);
            Controls.Add(removeSelectedPrizeButton);
            Controls.Add(teamsPlayersLabel);
            Controls.Add(PrizesListBox);
            Controls.Add(removeSelectedPlayersButton);
            Controls.Add(teamPlayerLabel);
            Controls.Add(TournamentTeamsListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewlinkLabel);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(EntryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(TournamentNameLabel);
            Controls.Add(createTournamentLabel);
            Font = new Font("Times New Roman", 18F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "CreateTournamentForm";
            Text = "CreateTournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentLabel;
        private TextBox tournamentNameValue;
        private Label TournamentNameLabel;
        private TextBox entryFeeValue;
        private Label EntryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewlinkLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox TournamentTeamsListBox;
        private Label teamPlayerLabel;
        private Button removeSelectedPlayersButton;
        private Button removeSelectedPrizeButton;
        private Label teamsPlayersLabel;
        private ListBox PrizesListBox;
        private Button createTournamentButton;
    }
}