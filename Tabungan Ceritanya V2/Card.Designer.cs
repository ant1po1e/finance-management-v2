using Tabungan_Ceritanya_V2.Controls;

namespace Tabungan_Ceritanya_V2
{
    partial class Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateLabel = new Label();
            reasonLabel = new Label();
            customButton1 = new CustomButton();
            customButton2 = new CustomButton();
            moneyLabel = new Label();
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.BackColor = Color.LightSkyBlue;
            dateLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(8, 8);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(168, 40);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "99/99/9999";
            dateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // reasonLabel
            // 
            reasonLabel.BackColor = Color.Gainsboro;
            reasonLabel.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reasonLabel.Location = new Point(8, 56);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Padding = new Padding(10, 0, 0, 0);
            reasonLabel.Size = new Size(616, 40);
            reasonLabel.TabIndex = 1;
            reasonLabel.Text = "Lorem ipsum dolor sit amet";
            reasonLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Gold;
            customButton1.BackgroundColor = Color.Gold;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 10;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton1.ForeColor = Color.Black;
            customButton1.Location = new Point(632, 8);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(120, 40);
            customButton1.TabIndex = 2;
            customButton1.Text = "Edit";
            customButton1.TextColor = Color.Black;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.Salmon;
            customButton2.BackgroundColor = Color.Salmon;
            customButton2.BorderColor = Color.PaleVioletRed;
            customButton2.BorderRadius = 10;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton2.ForeColor = Color.Black;
            customButton2.Location = new Point(632, 56);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(120, 40);
            customButton2.TabIndex = 3;
            customButton2.Text = "Delete";
            customButton2.TextColor = Color.Black;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // moneyLabel
            // 
            moneyLabel.BackColor = Color.PaleGreen;
            moneyLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moneyLabel.Location = new Point(184, 8);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Padding = new Padding(10, 0, 0, 0);
            moneyLabel.Size = new Size(440, 40);
            moneyLabel.TabIndex = 4;
            moneyLabel.Text = "Rp. 19.000";
            moneyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Card
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(dateLabel);
            Controls.Add(moneyLabel);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Controls.Add(reasonLabel);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Card";
            Size = new Size(758, 105);
            Load += Card_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label dateLabel;
        private Label reasonLabel;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private Label moneyLabel;
    }
}
