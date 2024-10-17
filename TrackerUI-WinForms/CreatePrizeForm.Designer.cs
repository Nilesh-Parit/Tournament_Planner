namespace TrackerUI
{
    partial class CreatePrizeForm
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
            placeNumberLabel = new Label();
            createPrizeLabel = new Label();
            placeNumberValue = new TextBox();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            placeNumberLabel.ForeColor = Color.Brown;
            placeNumberLabel.Location = new Point(228, 148);
            placeNumberLabel.Margin = new Padding(6, 0, 6, 0);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(180, 31);
            placeNumberLabel.TabIndex = 16;
            placeNumberLabel.Text = "Place Number";
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold);
            createPrizeLabel.ForeColor = Color.FromArgb(64, 0, 0);
            createPrizeLabel.Location = new Point(370, 48);
            createPrizeLabel.Margin = new Padding(6, 0, 6, 0);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(211, 42);
            createPrizeLabel.TabIndex = 15;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(482, 144);
            placeNumberValue.Margin = new Padding(6, 5, 6, 5);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(281, 35);
            placeNumberValue.TabIndex = 17;
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(482, 197);
            placeNameValue.Margin = new Padding(6, 5, 6, 5);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(281, 35);
            placeNameValue.TabIndex = 23;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            placeNameLabel.ForeColor = Color.Brown;
            placeNameLabel.Location = new Point(228, 201);
            placeNameLabel.Margin = new Padding(6, 0, 6, 0);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(167, 31);
            placeNameLabel.TabIndex = 22;
            placeNameLabel.Text = "Placed Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(482, 252);
            prizeAmountValue.Margin = new Padding(6, 5, 6, 5);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(281, 35);
            prizeAmountValue.TabIndex = 25;
            prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            prizeAmountLabel.ForeColor = Color.Brown;
            prizeAmountLabel.Location = new Point(228, 256);
            prizeAmountLabel.Margin = new Padding(6, 0, 6, 0);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(174, 31);
            prizeAmountLabel.TabIndex = 24;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(482, 329);
            prizePercentageValue.Margin = new Padding(6, 5, 6, 5);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(281, 35);
            prizePercentageValue.TabIndex = 27;
            prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            prizePercentageLabel.ForeColor = Color.Brown;
            prizePercentageLabel.Location = new Point(228, 333);
            prizePercentageLabel.Margin = new Padding(6, 0, 6, 0);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(216, 31);
            prizePercentageLabel.TabIndex = 26;
            prizePercentageLabel.Text = "Prize Percentage ";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orLabel.ForeColor = Color.Tomato;
            orLabel.Location = new Point(426, 292);
            orLabel.Margin = new Padding(6, 0, 6, 0);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(59, 32);
            orLabel.TabIndex = 28;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            createPrizeButton.ForeColor = Color.Maroon;
            createPrizeButton.Location = new Point(228, 439);
            createPrizeButton.Margin = new Padding(6, 5, 6, 5);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(535, 47);
            createPrizeButton.TabIndex = 29;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(984, 561);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Times New Roman", 18F);
            Margin = new Padding(6, 5, 6, 5);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label placeNumberLabel;
        private Label createPrizeLabel;
        private TextBox placeNumberValue;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}