using Tabungan_Ceritanya_V2.Controls;

namespace Tabungan_Ceritanya_V2
{
    partial class Logs
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
            customButton1 = new CustomButton();
            customButton2 = new CustomButton();
            customButton3 = new CustomButton();
            customTextBox1 = new CustomTextBox();
            customButton4 = new CustomButton();
            flowLayoutPanel1 = new CustomFlowLayoutPanel();
            label3 = new Label();
            customButton5 = new CustomButton();
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.White;
            customButton1.BackgroundColor = Color.White;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 10;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.Black;
            customButton1.Location = new Point(16, 16);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(112, 34);
            customButton1.TabIndex = 0;
            customButton1.Text = "Jan - Apr";
            customButton1.TextColor = Color.Black;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.White;
            customButton2.BackgroundColor = Color.White;
            customButton2.BorderColor = Color.PaleVioletRed;
            customButton2.BorderRadius = 10;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.ForeColor = Color.Black;
            customButton2.Location = new Point(136, 16);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(112, 34);
            customButton2.TabIndex = 1;
            customButton2.Text = "May - Aug";
            customButton2.TextColor = Color.Black;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.White;
            customButton3.BackgroundColor = Color.White;
            customButton3.BorderColor = Color.PaleVioletRed;
            customButton3.BorderRadius = 10;
            customButton3.BorderSize = 0;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.ForeColor = Color.Black;
            customButton3.Location = new Point(256, 16);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(104, 34);
            customButton3.TabIndex = 2;
            customButton3.Text = "Sep - Dec";
            customButton3.TextColor = Color.Black;
            customButton3.UseVisualStyleBackColor = false;
            customButton3.Click += customButton3_Click;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.BorderColor = Color.Teal;
            customTextBox1.BorderFocusColor = Color.PaleTurquoise;
            customTextBox1.BorderRadius = 5;
            customTextBox1.BorderSize = 2;
            customTextBox1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(368, 16);
            customTextBox1.Margin = new Padding(4);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 7, 10, 7);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "Search (income/expense, money, reason)";
            customTextBox1.Size = new Size(416, 35);
            customTextBox1.TabIndex = 4;
            customTextBox1.Texts = "";
            customTextBox1.UnderlinedStyle = false;
            customTextBox1._TextChanged += customTextBox1__TextChanged;
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.Coral;
            customButton4.BackgroundColor = Color.Coral;
            customButton4.BorderColor = Color.PaleVioletRed;
            customButton4.BorderRadius = 10;
            customButton4.BorderSize = 0;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton4.ForeColor = Color.White;
            customButton4.Location = new Point(16, 456);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(112, 40);
            customButton4.TabIndex = 5;
            customButton4.Text = "Close";
            customButton4.TextColor = Color.White;
            customButton4.UseVisualStyleBackColor = false;
            customButton4.Click += customButton4_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(50, 50, 50);
            flowLayoutPanel1.Location = new Point(16, 64);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(768, 376);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(376, 464);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 8;
            label3.Text = "Logs";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customButton5
            // 
            customButton5.BackColor = Color.DeepSkyBlue;
            customButton5.BackgroundColor = Color.DeepSkyBlue;
            customButton5.BorderColor = Color.PaleVioletRed;
            customButton5.BorderRadius = 10;
            customButton5.BorderSize = 0;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton5.ForeColor = Color.White;
            customButton5.Location = new Point(672, 456);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(112, 40);
            customButton5.TabIndex = 9;
            customButton5.Text = "Export";
            customButton5.TextColor = Color.White;
            customButton5.UseVisualStyleBackColor = false;
            customButton5.Click += customButton5_Click;
            // 
            // Logs
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(803, 512);
            Controls.Add(customButton5);
            Controls.Add(label3);
            Controls.Add(customTextBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(customButton4);
            Controls.Add(customButton3);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Logs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private Tabungan_Ceritanya_V2.Controls.CustomTextBox customTextBox1;
        private CustomButton customButton4;
        private Controls.CustomFlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private CustomButton customButton5;
    }
}