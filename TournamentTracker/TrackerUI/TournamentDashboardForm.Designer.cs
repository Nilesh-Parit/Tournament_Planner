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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ExistingTournamentLabel = new System.Windows.Forms.Label();
            this.ExistingTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HeaderLabel.Location = new System.Drawing.Point(221, 90);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(308, 36);
            this.HeaderLabel.TabIndex = 12;
            this.HeaderLabel.Text = "Tournament Dashboard";
            // 
            // ExistingTournamentLabel
            // 
            this.ExistingTournamentLabel.AutoSize = true;
            this.ExistingTournamentLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingTournamentLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ExistingTournamentLabel.Location = new System.Drawing.Point(260, 178);
            this.ExistingTournamentLabel.Name = "ExistingTournamentLabel";
            this.ExistingTournamentLabel.Size = new System.Drawing.Size(231, 23);
            this.ExistingTournamentLabel.TabIndex = 33;
            this.ExistingTournamentLabel.Text = "Load Existing Tournament";
            this.ExistingTournamentLabel.Click += new System.EventHandler(this.PlaceNumberLabel_Click);
            // 
            // ExistingTournamentDropdown
            // 
            this.ExistingTournamentDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingTournamentDropdown.FormattingEnabled = true;
            this.ExistingTournamentDropdown.Location = new System.Drawing.Point(220, 213);
            this.ExistingTournamentDropdown.Name = "ExistingTournamentDropdown";
            this.ExistingTournamentDropdown.Size = new System.Drawing.Size(311, 28);
            this.ExistingTournamentDropdown.TabIndex = 34;
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoadTournamentButton.Location = new System.Drawing.Point(279, 266);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(193, 36);
            this.LoadTournamentButton.TabIndex = 41;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournament
            // 
            this.CreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournament.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateTournament.Location = new System.Drawing.Point(279, 322);
            this.CreateTournament.Name = "CreateTournament";
            this.CreateTournament.Size = new System.Drawing.Size(193, 36);
            this.CreateTournament.TabIndex = 42;
            this.CreateTournament.Text = "Create Tournament";
            this.CreateTournament.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 470);
            this.Controls.Add(this.CreateTournament);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.ExistingTournamentDropdown);
            this.Controls.Add(this.ExistingTournamentLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label ExistingTournamentLabel;
        private System.Windows.Forms.ComboBox ExistingTournamentDropdown;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateTournament;
    }
}