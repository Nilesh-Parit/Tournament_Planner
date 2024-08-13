namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            loadExistingTournamentDropDown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            tournamentDashboardLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(309, 231);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(368, 35);
            loadExistingTournamentDropDown.TabIndex = 22;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            loadExistingTournamentLabel.ForeColor = Color.Tomato;
            loadExistingTournamentLabel.Location = new Point(325, 186);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(341, 32);
            loadExistingTournamentLabel.TabIndex = 21;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold);
            tournamentDashboardLabel.ForeColor = Color.FromArgb(64, 0, 0);
            tournamentDashboardLabel.Location = new Point(274, 74);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(453, 42);
            tournamentDashboardLabel.TabIndex = 18;
            tournamentDashboardLabel.Text = "* Tournament Dashboard *";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Times New Roman", 20.25F);
            loadTournamentButton.ForeColor = Color.DarkOrange;
            loadTournamentButton.Location = new Point(377, 281);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(250, 41);
            loadTournamentButton.TabIndex = 23;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            loadTournamentButton.Click += loadTournamentButton_Click;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            createTournamentButton.ForeColor = Color.Maroon;
            createTournamentButton.Location = new Point(331, 409);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(335, 50);
            createTournamentButton.TabIndex = 26;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(984, 561);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(tournamentDashboardLabel);
            Font = new Font("Times New Roman", 18F);
            ForeColor = Color.White;
            Margin = new Padding(5, 5, 5, 5);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox loadExistingTournamentDropDown;
        private Label loadExistingTournamentLabel;
        private Label tournamentDashboardLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}