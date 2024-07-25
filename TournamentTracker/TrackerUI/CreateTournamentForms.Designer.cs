namespace TrackerUI
{
    partial class CreateTournamentForms
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
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.TournamentNametextBox = new System.Windows.Forms.TextBox();
            this.EntryFeetextBox = new System.Windows.Forms.TextBox();
            this.RoundDropdown = new System.Windows.Forms.ComboBox();
            this.CreateRoundlinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.TournamentPlayerListBox = new System.Windows.Forms.ListBox();
            this.DeletePlayerButton = new System.Windows.Forms.Button();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.Roundlabel = new System.Windows.Forms.Label();
            this.CreateRoundbutton = new System.Windows.Forms.Button();
            this.TournamentPlayerLabel = new System.Windows.Forms.Label();
            this.TournamentPrizeLabel = new System.Windows.Forms.Label();
            this.DeletePrizeButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PrizeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(263, 36);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament:";
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TournamentNameLabel.Location = new System.Drawing.Point(12, 77);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(190, 27);
            this.TournamentNameLabel.TabIndex = 2;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // TournamentNametextBox
            // 
            this.TournamentNametextBox.Location = new System.Drawing.Point(21, 112);
            this.TournamentNametextBox.Name = "TournamentNametextBox";
            this.TournamentNametextBox.Size = new System.Drawing.Size(257, 20);
            this.TournamentNametextBox.TabIndex = 9;
            // 
            // EntryFeetextBox
            // 
            this.EntryFeetextBox.Location = new System.Drawing.Point(128, 163);
            this.EntryFeetextBox.Name = "EntryFeetextBox";
            this.EntryFeetextBox.Size = new System.Drawing.Size(150, 20);
            this.EntryFeetextBox.TabIndex = 11;
            this.EntryFeetextBox.Text = "0";
            // 
            // RoundDropdown
            // 
            this.RoundDropdown.FormattingEnabled = true;
            this.RoundDropdown.Location = new System.Drawing.Point(21, 247);
            this.RoundDropdown.Name = "RoundDropdown";
            this.RoundDropdown.Size = new System.Drawing.Size(257, 21);
            this.RoundDropdown.TabIndex = 13;
            // 
            // CreateRoundlinkLabel
            // 
            this.CreateRoundlinkLabel.AutoSize = true;
            this.CreateRoundlinkLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateRoundlinkLabel.Location = new System.Drawing.Point(194, 223);
            this.CreateRoundlinkLabel.Name = "CreateRoundlinkLabel";
            this.CreateRoundlinkLabel.Size = new System.Drawing.Size(84, 19);
            this.CreateRoundlinkLabel.TabIndex = 14;
            this.CreateRoundlinkLabel.TabStop = true;
            this.CreateRoundlinkLabel.Text = "Create New";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddTeamButton.Location = new System.Drawing.Point(73, 353);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(141, 36);
            this.AddTeamButton.TabIndex = 15;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayerListBox
            // 
            this.TournamentPlayerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentPlayerListBox.FormattingEnabled = true;
            this.TournamentPlayerListBox.Location = new System.Drawing.Point(364, 107);
            this.TournamentPlayerListBox.Name = "TournamentPlayerListBox";
            this.TournamentPlayerListBox.Size = new System.Drawing.Size(233, 93);
            this.TournamentPlayerListBox.TabIndex = 17;
            // 
            // DeletePlayerButton
            // 
            this.DeletePlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeletePlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeletePlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeletePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePlayerButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeletePlayerButton.Location = new System.Drawing.Point(620, 146);
            this.DeletePlayerButton.Name = "DeletePlayerButton";
            this.DeletePlayerButton.Size = new System.Drawing.Size(111, 54);
            this.DeletePlayerButton.TabIndex = 19;
            this.DeletePlayerButton.Text = "Delete Selected";
            this.DeletePlayerButton.UseVisualStyleBackColor = true;
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.EntryFeeLabel.Location = new System.Drawing.Point(13, 156);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(107, 27);
            this.EntryFeeLabel.TabIndex = 24;
            this.EntryFeeLabel.Text = "Entry Fee";
            this.EntryFeeLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // Roundlabel
            // 
            this.Roundlabel.AutoSize = true;
            this.Roundlabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roundlabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Roundlabel.Location = new System.Drawing.Point(16, 217);
            this.Roundlabel.Name = "Roundlabel";
            this.Roundlabel.Size = new System.Drawing.Size(76, 27);
            this.Roundlabel.TabIndex = 25;
            this.Roundlabel.Text = "Round";
            // 
            // CreateRoundbutton
            // 
            this.CreateRoundbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateRoundbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateRoundbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateRoundbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateRoundbutton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateRoundbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateRoundbutton.Location = new System.Drawing.Point(73, 311);
            this.CreateRoundbutton.Name = "CreateRoundbutton";
            this.CreateRoundbutton.Size = new System.Drawing.Size(141, 36);
            this.CreateRoundbutton.TabIndex = 26;
            this.CreateRoundbutton.Text = "Create Prize";
            this.CreateRoundbutton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayerLabel
            // 
            this.TournamentPlayerLabel.AutoSize = true;
            this.TournamentPlayerLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentPlayerLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TournamentPlayerLabel.Location = new System.Drawing.Point(359, 77);
            this.TournamentPlayerLabel.Name = "TournamentPlayerLabel";
            this.TournamentPlayerLabel.Size = new System.Drawing.Size(154, 27);
            this.TournamentPlayerLabel.TabIndex = 27;
            this.TournamentPlayerLabel.Text = "Team / Players";
            // 
            // TournamentPrizeLabel
            // 
            this.TournamentPrizeLabel.AutoSize = true;
            this.TournamentPrizeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentPrizeLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TournamentPrizeLabel.Location = new System.Drawing.Point(359, 266);
            this.TournamentPrizeLabel.Name = "TournamentPrizeLabel";
            this.TournamentPrizeLabel.Size = new System.Drawing.Size(154, 27);
            this.TournamentPrizeLabel.TabIndex = 28;
            this.TournamentPrizeLabel.Text = "Team / Players";
            // 
            // DeletePrizeButton
            // 
            this.DeletePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeletePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeletePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeletePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePrizeButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeletePrizeButton.Location = new System.Drawing.Point(620, 334);
            this.DeletePrizeButton.Name = "DeletePrizeButton";
            this.DeletePrizeButton.Size = new System.Drawing.Size(111, 54);
            this.DeletePrizeButton.TabIndex = 29;
            this.DeletePrizeButton.Text = "Delete Selected";
            this.DeletePrizeButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(262, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 36);
            this.button3.TabIndex = 30;
            this.button3.Text = "Create Tournament";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PrizeListBox
            // 
            this.PrizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizeListBox.FormattingEnabled = true;
            this.PrizeListBox.Location = new System.Drawing.Point(364, 296);
            this.PrizeListBox.Name = "PrizeListBox";
            this.PrizeListBox.Size = new System.Drawing.Size(233, 93);
            this.PrizeListBox.TabIndex = 31;
            // 
            // CreateTournamentForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 466);
            this.Controls.Add(this.PrizeListBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DeletePrizeButton);
            this.Controls.Add(this.TournamentPrizeLabel);
            this.Controls.Add(this.TournamentPlayerLabel);
            this.Controls.Add(this.CreateRoundbutton);
            this.Controls.Add(this.Roundlabel);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.DeletePlayerButton);
            this.Controls.Add(this.TournamentPlayerListBox);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateRoundlinkLabel);
            this.Controls.Add(this.RoundDropdown);
            this.Controls.Add(this.EntryFeetextBox);
            this.Controls.Add(this.TournamentNametextBox);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "CreateTournamentForms";
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournamentForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox TournamentNametextBox;
        private System.Windows.Forms.TextBox EntryFeetextBox;
        private System.Windows.Forms.ComboBox RoundDropdown;
        private System.Windows.Forms.LinkLabel CreateRoundlinkLabel;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.ListBox TournamentPlayerListBox;
        private System.Windows.Forms.Button DeletePlayerButton;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.Label Roundlabel;
        private System.Windows.Forms.Button CreateRoundbutton;
        private System.Windows.Forms.Label TournamentPlayerLabel;
        private System.Windows.Forms.Label TournamentPrizeLabel;
        private System.Windows.Forms.Button DeletePrizeButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox PrizeListBox;
    }
}