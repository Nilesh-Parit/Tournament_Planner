
namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameValue = new TextBox();
            TeamNameLabel = new Label();
            createTeamLabel = new Label();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addMemberButton = new Button();
            addNewMembergroupBox = new GroupBox();
            createMemberButton = new Button();
            cellphoneLabelValue = new TextBox();
            cellphoneLabel = new Label();
            emailLabelValue = new TextBox();
            emailLabel = new Label();
            lastNameLabelValue = new TextBox();
            lastNameLabel = new Label();
            firstNameLabelValue = new TextBox();
            TeamOneScoreLabel = new Label();
            removeSelectedMemberButton = new Button();
            TeamMembersListBox = new ListBox();
            createTeamButton = new Button();
            addNewMembergroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(15, 150);
            teamNameValue.Margin = new Padding(6, 5, 6, 5);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(319, 35);
            teamNameValue.TabIndex = 14;
            teamNameValue.TextChanged += teamNameValue_TextChanged;
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            TeamNameLabel.ForeColor = Color.Tomato;
            TeamNameLabel.Location = new Point(15, 108);
            TeamNameLabel.Margin = new Padding(6, 0, 6, 0);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(159, 32);
            TeamNameLabel.TabIndex = 13;
            TeamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold);
            createTeamLabel.ForeColor = Color.FromArgb(64, 0, 0);
            createTeamLabel.Location = new Point(369, 18);
            createTeamLabel.Margin = new Padding(6, 0, 6, 0);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(217, 42);
            createTeamLabel.TabIndex = 12;
            createTeamLabel.Text = "Create Team";
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(15, 282);
            selectTeamMemberDropDown.Margin = new Padding(6, 5, 6, 5);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(319, 35);
            selectTeamMemberDropDown.TabIndex = 17;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            selectTeamMemberLabel.ForeColor = Color.Tomato;
            selectTeamMemberLabel.Location = new Point(15, 232);
            selectTeamMemberLabel.Margin = new Padding(6, 0, 6, 0);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(272, 32);
            selectTeamMemberLabel.TabIndex = 16;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Times New Roman", 20.25F);
            addMemberButton.ForeColor = Color.DarkOrange;
            addMemberButton.Location = new Point(47, 385);
            addMemberButton.Margin = new Padding(6, 5, 6, 5);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(221, 42);
            addMemberButton.TabIndex = 18;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // addNewMembergroupBox
            // 
            addNewMembergroupBox.Controls.Add(createMemberButton);
            addNewMembergroupBox.Controls.Add(cellphoneLabelValue);
            addNewMembergroupBox.Controls.Add(cellphoneLabel);
            addNewMembergroupBox.Controls.Add(emailLabelValue);
            addNewMembergroupBox.Controls.Add(emailLabel);
            addNewMembergroupBox.Controls.Add(lastNameLabelValue);
            addNewMembergroupBox.Controls.Add(lastNameLabel);
            addNewMembergroupBox.Controls.Add(firstNameLabelValue);
            addNewMembergroupBox.Controls.Add(TeamOneScoreLabel);
            addNewMembergroupBox.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            addNewMembergroupBox.ForeColor = Color.Tomato;
            addNewMembergroupBox.Location = new Point(627, 90);
            addNewMembergroupBox.Margin = new Padding(6, 5, 6, 5);
            addNewMembergroupBox.Name = "addNewMembergroupBox";
            addNewMembergroupBox.Padding = new Padding(6, 5, 6, 5);
            addNewMembergroupBox.Size = new Size(353, 358);
            addNewMembergroupBox.TabIndex = 19;
            addNewMembergroupBox.TabStop = false;
            addNewMembergroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Times New Roman", 20.25F);
            createMemberButton.ForeColor = Color.DarkOrange;
            createMemberButton.Location = new Point(70, 295);
            createMemberButton.Margin = new Padding(6, 5, 6, 5);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(221, 42);
            createMemberButton.TabIndex = 20;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellphoneLabelValue
            // 
            cellphoneLabelValue.Location = new Point(150, 220);
            cellphoneLabelValue.Margin = new Padding(6, 5, 6, 5);
            cellphoneLabelValue.Name = "cellphoneLabelValue";
            cellphoneLabelValue.Size = new Size(191, 41);
            cellphoneLabelValue.TabIndex = 19;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Times New Roman", 20.25F);
            cellphoneLabel.ForeColor = Color.Brown;
            cellphoneLabel.Location = new Point(12, 230);
            cellphoneLabel.Margin = new Padding(6, 0, 6, 0);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(128, 31);
            cellphoneLabel.TabIndex = 18;
            cellphoneLabel.Text = "Cellphone";
            // 
            // emailLabelValue
            // 
            emailLabelValue.Location = new Point(150, 165);
            emailLabelValue.Margin = new Padding(6, 5, 6, 5);
            emailLabelValue.Name = "emailLabelValue";
            emailLabelValue.Size = new Size(191, 41);
            emailLabelValue.TabIndex = 17;
            emailLabelValue.TextChanged += emailLabelValue_TextChanged;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Times New Roman", 20.25F);
            emailLabel.ForeColor = Color.Brown;
            emailLabel.Location = new Point(12, 175);
            emailLabel.Margin = new Padding(6, 0, 6, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(78, 31);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email";
            // 
            // lastNameLabelValue
            // 
            lastNameLabelValue.Location = new Point(150, 111);
            lastNameLabelValue.Margin = new Padding(6, 5, 6, 5);
            lastNameLabelValue.Name = "lastNameLabelValue";
            lastNameLabelValue.Size = new Size(191, 41);
            lastNameLabelValue.TabIndex = 13;
            lastNameLabelValue.TextChanged += lastNameLabelValue_TextChanged;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Times New Roman", 20.25F);
            lastNameLabel.ForeColor = Color.Brown;
            lastNameLabel.Location = new Point(12, 121);
            lastNameLabel.Margin = new Padding(6, 0, 6, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(130, 31);
            lastNameLabel.TabIndex = 12;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabelValue
            // 
            firstNameLabelValue.Location = new Point(150, 60);
            firstNameLabelValue.Margin = new Padding(6, 5, 6, 5);
            firstNameLabelValue.Name = "firstNameLabelValue";
            firstNameLabelValue.Size = new Size(191, 41);
            firstNameLabelValue.TabIndex = 11;
            // 
            // TeamOneScoreLabel
            // 
            TeamOneScoreLabel.AutoSize = true;
            TeamOneScoreLabel.Font = new Font("Times New Roman", 20.25F);
            TeamOneScoreLabel.ForeColor = Color.Brown;
            TeamOneScoreLabel.Location = new Point(12, 70);
            TeamOneScoreLabel.Margin = new Padding(6, 0, 6, 0);
            TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            TeamOneScoreLabel.Size = new Size(133, 31);
            TeamOneScoreLabel.TabIndex = 10;
            TeamOneScoreLabel.Text = "First Name";
            // 
            // removeSelectedMemberButton
            // 
            removeSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            removeSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            removeSelectedMemberButton.Font = new Font("Times New Roman", 20.25F);
            removeSelectedMemberButton.ForeColor = Color.DarkOrange;
            removeSelectedMemberButton.Location = new Point(369, 385);
            removeSelectedMemberButton.Margin = new Padding(6, 5, 6, 5);
            removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            removeSelectedMemberButton.Size = new Size(221, 42);
            removeSelectedMemberButton.TabIndex = 24;
            removeSelectedMemberButton.Text = "Remove Selected";
            removeSelectedMemberButton.UseVisualStyleBackColor = true;
            removeSelectedMemberButton.Click += removeSelectedMemberButton_Click;
            // 
            // TeamMembersListBox
            // 
            TeamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            TeamMembersListBox.Font = new Font("Times New Roman", 15.75F);
            TeamMembersListBox.FormattingEnabled = true;
            TeamMembersListBox.ItemHeight = 23;
            TeamMembersListBox.Location = new Point(357, 108);
            TeamMembersListBox.Margin = new Padding(6, 5, 6, 5);
            TeamMembersListBox.Name = "TeamMembersListBox";
            TeamMembersListBox.Size = new Size(243, 255);
            TeamMembersListBox.TabIndex = 22;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            createTeamButton.ForeColor = Color.Maroon;
            createTeamButton.Location = new Point(315, 502);
            createTeamButton.Margin = new Padding(6, 5, 6, 5);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(359, 45);
            createTeamButton.TabIndex = 25;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(984, 561);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedMemberButton);
            Controls.Add(TeamMembersListBox);
            Controls.Add(addNewMembergroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(TeamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Times New Roman", 18F);
            Margin = new Padding(6, 5, 6, 5);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMembergroupBox.ResumeLayout(false);
            addNewMembergroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox teamNameValue;
        private Label TeamNameLabel;
        private Label createTeamLabel;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private Button addMemberButton;
        private GroupBox addNewMembergroupBox;
        private TextBox firstNameLabelValue;
        private Label TeamOneScoreLabel;
        private Button createMemberButton;
        private TextBox cellphoneLabelValue;
        private Label cellphoneLabel;
        private TextBox emailLabelValue;
        private Label emailLabel;
        private TextBox lastNameLabelValue;
        private Label lastNameLabel;
        private Button removeSelectedMemberButton;
        private ListBox TeamMembersListBox;
        private Button createTeamButton;
    }
}