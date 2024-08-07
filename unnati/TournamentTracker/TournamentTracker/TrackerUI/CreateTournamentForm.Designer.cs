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
            createTournamentLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTournamentLabel.ForeColor = SystemColors.MenuHighlight;
            createTournamentLabel.Location = new Point(38, 20);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(317, 50);
            createTournamentLabel.TabIndex = 1;
            createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(47, 130);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(328, 35);
            tournamentNameValue.TabIndex = 11;
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            TournamentNameLabel.Location = new Point(38, 90);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(225, 37);
            TournamentNameLabel.TabIndex = 10;
            TournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(182, 186);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(120, 35);
            entryFeeValue.TabIndex = 13;
            entryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            EntryFeeLabel.AutoSize = true;
            EntryFeeLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EntryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            EntryFeeLabel.Location = new Point(38, 184);
            EntryFeeLabel.Name = "EntryFeeLabel";
            EntryFeeLabel.Size = new Size(124, 37);
            EntryFeeLabel.TabIndex = 12;
            EntryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(47, 328);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(328, 38);
            selectTeamDropDown.TabIndex = 15;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(38, 282);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(150, 37);
            selectTeamLabel.TabIndex = 14;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewlinkLabel
            // 
            createNewlinkLabel.AutoSize = true;
            createNewlinkLabel.Location = new Point(261, 295);
            createNewlinkLabel.Name = "createNewlinkLabel";
            createNewlinkLabel.Size = new Size(114, 30);
            createNewlinkLabel.TabIndex = 16;
            createNewlinkLabel.TabStop = true;
            createNewlinkLabel.Text = "create new";
            createNewlinkLabel.LinkClicked += createNewlinkLabel_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTeamButton.ForeColor = SystemColors.MenuHighlight;
            addTeamButton.Location = new Point(94, 390);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(231, 38);
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
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(94, 454);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(231, 37);
            createPrizeButton.TabIndex = 18;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // TournamentTeamsListBox
            // 
            TournamentTeamsListBox.BorderStyle = BorderStyle.FixedSingle;
            TournamentTeamsListBox.FormattingEnabled = true;
            TournamentTeamsListBox.ItemHeight = 30;
            TournamentTeamsListBox.Location = new Point(492, 130);
            TournamentTeamsListBox.Name = "TournamentTeamsListBox";
            TournamentTeamsListBox.Size = new Size(318, 152);
            TournamentTeamsListBox.TabIndex = 19;
            TournamentTeamsListBox.SelectedIndexChanged += TournamentTeamsListBox_SelectedIndexChanged;
            // 
            // teamPlayerLabel
            // 
            teamPlayerLabel.AutoSize = true;
            teamPlayerLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamPlayerLabel.ForeColor = SystemColors.MenuHighlight;
            teamPlayerLabel.Location = new Point(481, 90);
            teamPlayerLabel.Name = "teamPlayerLabel";
            teamPlayerLabel.Size = new Size(189, 37);
            teamPlayerLabel.TabIndex = 20;
            teamPlayerLabel.Text = "Teams / Players";
            // 
            // removeSelectedPlayersButton
            // 
            removeSelectedPlayersButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            removeSelectedPlayersButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPlayersButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeSelectedPlayersButton.ForeColor = SystemColors.MenuHighlight;
            removeSelectedPlayersButton.Location = new Point(833, 162);
            removeSelectedPlayersButton.Name = "removeSelectedPlayersButton";
            removeSelectedPlayersButton.Size = new Size(119, 86);
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
            removeSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeSelectedPrizeButton.ForeColor = SystemColors.MenuHighlight;
            removeSelectedPrizeButton.Location = new Point(833, 380);
            removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            removeSelectedPrizeButton.Size = new Size(119, 86);
            removeSelectedPrizeButton.TabIndex = 24;
            removeSelectedPrizeButton.Text = "Remove Selected";
            removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            removeSelectedPrizeButton.Click += removeSelectedPrizeButton_Click;
            // 
            // teamsPlayersLabel
            // 
            teamsPlayersLabel.AutoSize = true;
            teamsPlayersLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamsPlayersLabel.ForeColor = SystemColors.MenuHighlight;
            teamsPlayersLabel.Location = new Point(481, 308);
            teamsPlayersLabel.Name = "teamsPlayersLabel";
            teamsPlayersLabel.Size = new Size(84, 37);
            teamsPlayersLabel.TabIndex = 23;
            teamsPlayersLabel.Text = "Prizes";
            // 
            // PrizesListBox
            // 
            PrizesListBox.BorderStyle = BorderStyle.FixedSingle;
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.ItemHeight = 30;
            PrizesListBox.Location = new Point(492, 348);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(318, 152);
            PrizesListBox.TabIndex = 22;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(278, 540);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(309, 55);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(985, 607);
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
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
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