
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
            teamNameValue.Location = new Point(21, 119);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(340, 23);
            teamNameValue.TabIndex = 14;
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamNameLabel.ForeColor = SystemColors.MenuHighlight;
            TeamNameLabel.Location = new Point(12, 79);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(151, 37);
            TeamNameLabel.TabIndex = 13;
            TeamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.ForeColor = SystemColors.MenuHighlight;
            createTeamLabel.Location = new Point(12, 9);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(213, 50);
            createTeamLabel.TabIndex = 12;
            createTeamLabel.Text = "Create Team";
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(21, 202);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(340, 23);
            selectTeamMemberDropDown.TabIndex = 17;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamMemberLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamMemberLabel.Location = new Point(12, 162);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(253, 37);
            selectTeamMemberLabel.TabIndex = 16;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addMemberButton.ForeColor = SystemColors.MenuHighlight;
            addMemberButton.Location = new Point(64, 231);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(231, 38);
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
            addNewMembergroupBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNewMembergroupBox.ForeColor = SystemColors.MenuHighlight;
            addNewMembergroupBox.Location = new Point(21, 307);
            addNewMembergroupBox.Name = "addNewMembergroupBox";
            addNewMembergroupBox.Size = new Size(340, 302);
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
            createMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createMemberButton.ForeColor = SystemColors.MenuHighlight;
            createMemberButton.Location = new Point(43, 249);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(231, 38);
            createMemberButton.TabIndex = 20;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellphoneLabelValue
            // 
            cellphoneLabelValue.Location = new Point(152, 198);
            cellphoneLabelValue.Name = "cellphoneLabelValue";
            cellphoneLabelValue.Size = new Size(170, 35);
            cellphoneLabelValue.TabIndex = 19;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cellphoneLabel.ForeColor = SystemColors.MenuHighlight;
            cellphoneLabel.Location = new Point(6, 190);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(132, 37);
            cellphoneLabel.TabIndex = 18;
            cellphoneLabel.Text = "Cellphone";
            // 
            // emailLabelValue
            // 
            emailLabelValue.Location = new Point(152, 148);
            emailLabelValue.Name = "emailLabelValue";
            emailLabelValue.Size = new Size(170, 35);
            emailLabelValue.TabIndex = 17;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = SystemColors.MenuHighlight;
            emailLabel.Location = new Point(6, 138);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(78, 37);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email";
            // 
            // lastNameLabelValue
            // 
            lastNameLabelValue.Location = new Point(152, 99);
            lastNameLabelValue.Name = "lastNameLabelValue";
            lastNameLabelValue.Size = new Size(170, 35);
            lastNameLabelValue.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = SystemColors.MenuHighlight;
            lastNameLabel.Location = new Point(6, 91);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(135, 37);
            lastNameLabel.TabIndex = 12;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabelValue
            // 
            firstNameLabelValue.Location = new Point(152, 49);
            firstNameLabelValue.Name = "firstNameLabelValue";
            firstNameLabelValue.Size = new Size(170, 35);
            firstNameLabelValue.TabIndex = 11;
            // 
            // TeamOneScoreLabel
            // 
            TeamOneScoreLabel.AutoSize = true;
            TeamOneScoreLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            TeamOneScoreLabel.Location = new Point(6, 41);
            TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            TeamOneScoreLabel.Size = new Size(138, 37);
            TeamOneScoreLabel.TabIndex = 10;
            TeamOneScoreLabel.Text = "First Name";
            // 
            // removeSelectedMemberButton
            // 
            removeSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            removeSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            removeSelectedMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeSelectedMemberButton.ForeColor = SystemColors.MenuHighlight;
            removeSelectedMemberButton.Location = new Point(729, 365);
            removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            removeSelectedMemberButton.Size = new Size(119, 86);
            removeSelectedMemberButton.TabIndex = 24;
            removeSelectedMemberButton.Text = "Remove Selected";
            removeSelectedMemberButton.UseVisualStyleBackColor = true;
            removeSelectedMemberButton.Click += removeSelectedMemberButton_Click;
            // 
            // TeamMembersListBox
            // 
            TeamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            TeamMembersListBox.FormattingEnabled = true;
            TeamMembersListBox.ItemHeight = 15;
            TeamMembersListBox.Location = new Point(425, 202);
            TeamMembersListBox.Name = "TeamMembersListBox";
            TeamMembersListBox.Size = new Size(280, 407);
            TeamMembersListBox.TabIndex = 22;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTeamButton.ForeColor = SystemColors.MenuHighlight;
            createTeamButton.Location = new Point(265, 631);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(288, 55);
            createTeamButton.TabIndex = 25;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 712);
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