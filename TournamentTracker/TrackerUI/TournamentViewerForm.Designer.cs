namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundName = new System.Windows.Forms.Label();
            this.RoundDropdown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.MatchuplistBox = new System.Windows.Forms.ListBox();
            this.TeamOneNamelabel = new System.Windows.Forms.Label();
            this.TeamOneScorelabel = new System.Windows.Forms.Label();
            this.TeamOneScoreValuetextBox = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreValuetextBox = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoNamelabel = new System.Windows.Forms.Label();
            this.VrSLabel = new System.Windows.Forms.Label();
            this.Scorebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HeaderLabel.Location = new System.Drawing.Point(13, 13);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(196, 36);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TournamentName.Location = new System.Drawing.Point(215, 14);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(111, 36);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // RoundName
            // 
            this.RoundName.AutoSize = true;
            this.RoundName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.RoundName.Location = new System.Drawing.Point(22, 67);
            this.RoundName.Name = "RoundName";
            this.RoundName.Size = new System.Drawing.Size(76, 27);
            this.RoundName.TabIndex = 2;
            this.RoundName.Text = "Round";
            // 
            // RoundDropdown
            // 
            this.RoundDropdown.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundDropdown.FormattingEnabled = true;
            this.RoundDropdown.Location = new System.Drawing.Point(117, 67);
            this.RoundDropdown.Name = "RoundDropdown";
            this.RoundDropdown.Size = new System.Drawing.Size(165, 35);
            this.RoundDropdown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckbox
            // 
            this.UnplayedOnlyCheckbox.AutoSize = true;
            this.UnplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckbox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedOnlyCheckbox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.UnplayedOnlyCheckbox.Location = new System.Drawing.Point(117, 108);
            this.UnplayedOnlyCheckbox.Name = "UnplayedOnlyCheckbox";
            this.UnplayedOnlyCheckbox.Size = new System.Drawing.Size(173, 31);
            this.UnplayedOnlyCheckbox.TabIndex = 4;
            this.UnplayedOnlyCheckbox.Text = "Unplayed Only";
            this.UnplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // MatchuplistBox
            // 
            this.MatchuplistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchuplistBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchuplistBox.FormattingEnabled = true;
            this.MatchuplistBox.ItemHeight = 23;
            this.MatchuplistBox.Location = new System.Drawing.Point(27, 160);
            this.MatchuplistBox.Name = "MatchuplistBox";
            this.MatchuplistBox.Size = new System.Drawing.Size(324, 278);
            this.MatchuplistBox.TabIndex = 5;
            // 
            // TeamOneNamelabel
            // 
            this.TeamOneNamelabel.AutoSize = true;
            this.TeamOneNamelabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneNamelabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TeamOneNamelabel.Location = new System.Drawing.Point(450, 160);
            this.TeamOneNamelabel.Name = "TeamOneNamelabel";
            this.TeamOneNamelabel.Size = new System.Drawing.Size(132, 26);
            this.TeamOneNamelabel.TabIndex = 6;
            this.TeamOneNamelabel.Text = "<team one>";
            // 
            // TeamOneScorelabel
            // 
            this.TeamOneScorelabel.AutoSize = true;
            this.TeamOneScorelabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScorelabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TeamOneScorelabel.Location = new System.Drawing.Point(450, 211);
            this.TeamOneScorelabel.Name = "TeamOneScorelabel";
            this.TeamOneScorelabel.Size = new System.Drawing.Size(66, 27);
            this.TeamOneScorelabel.TabIndex = 7;
            this.TeamOneScorelabel.Text = "Score";
            // 
            // TeamOneScoreValuetextBox
            // 
            this.TeamOneScoreValuetextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreValuetextBox.Location = new System.Drawing.Point(532, 203);
            this.TeamOneScoreValuetextBox.Name = "TeamOneScoreValuetextBox";
            this.TeamOneScoreValuetextBox.Size = new System.Drawing.Size(100, 35);
            this.TeamOneScoreValuetextBox.TabIndex = 8;
            // 
            // TeamTwoScoreValuetextBox
            // 
            this.TeamTwoScoreValuetextBox.Location = new System.Drawing.Point(532, 367);
            this.TeamTwoScoreValuetextBox.Name = "TeamTwoScoreValuetextBox";
            this.TeamTwoScoreValuetextBox.Size = new System.Drawing.Size(100, 35);
            this.TeamTwoScoreValuetextBox.TabIndex = 11;
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoScoreLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(450, 375);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(66, 27);
            this.TeamTwoScoreLabel.TabIndex = 10;
            this.TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamTwoNamelabel
            // 
            this.TeamTwoNamelabel.AutoSize = true;
            this.TeamTwoNamelabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoNamelabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TeamTwoNamelabel.Location = new System.Drawing.Point(447, 327);
            this.TeamTwoNamelabel.Name = "TeamTwoNamelabel";
            this.TeamTwoNamelabel.Size = new System.Drawing.Size(133, 26);
            this.TeamTwoNamelabel.TabIndex = 9;
            this.TeamTwoNamelabel.Text = "<team two>";
            // 
            // VrSLabel
            // 
            this.VrSLabel.AutoSize = true;
            this.VrSLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VrSLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.VrSLabel.Location = new System.Drawing.Point(491, 262);
            this.VrSLabel.Name = "VrSLabel";
            this.VrSLabel.Size = new System.Drawing.Size(84, 40);
            this.VrSLabel.TabIndex = 12;
            this.VrSLabel.Text = "-V/S-";
            this.VrSLabel.Click += new System.EventHandler(this.VrSLabel_Click);
            // 
            // Scorebutton
            // 
            this.Scorebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Scorebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Scorebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Scorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scorebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Scorebutton.Location = new System.Drawing.Point(749, 282);
            this.Scorebutton.Name = "Scorebutton";
            this.Scorebutton.Size = new System.Drawing.Size(99, 42);
            this.Scorebutton.TabIndex = 13;
            this.Scorebutton.Text = "Score";
            this.Scorebutton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 466);
            this.Controls.Add(this.Scorebutton);
            this.Controls.Add(this.VrSLabel);
            this.Controls.Add(this.TeamTwoScoreValuetextBox);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamTwoNamelabel);
            this.Controls.Add(this.TeamOneScoreValuetextBox);
            this.Controls.Add(this.TeamOneScorelabel);
            this.Controls.Add(this.TeamOneNamelabel);
            this.Controls.Add(this.MatchuplistBox);
            this.Controls.Add(this.UnplayedOnlyCheckbox);
            this.Controls.Add(this.RoundDropdown);
            this.Controls.Add(this.RoundName);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundName;
        private System.Windows.Forms.ComboBox RoundDropdown;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox MatchuplistBox;
        private System.Windows.Forms.Label TeamOneNamelabel;
        private System.Windows.Forms.Label TeamOneScorelabel;
        private System.Windows.Forms.TextBox TeamOneScoreValuetextBox;
        private System.Windows.Forms.TextBox TeamTwoScoreValuetextBox;
        private System.Windows.Forms.Label TeamTwoScoreLabel;
        private System.Windows.Forms.Label TeamTwoNamelabel;
        private System.Windows.Forms.Label VrSLabel;
        private System.Windows.Forms.Button Scorebutton;
    }
}

