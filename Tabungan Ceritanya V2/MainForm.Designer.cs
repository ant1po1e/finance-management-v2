using Tabungan_Ceritanya_V2.Controls;

namespace Tabungan_Ceritanya_V2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            customTextBox1 = new Tabungan_Ceritanya_V2.Controls.CustomTextBox();
            customButton1 = new Tabungan_Ceritanya_V2.Controls.CustomButton();
            customButton2 = new Tabungan_Ceritanya_V2.Controls.CustomButton();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            customButton3 = new Tabungan_Ceritanya_V2.Controls.CustomButton();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.BorderColor = Color.Teal;
            customTextBox1.BorderFocusColor = Color.PaleTurquoise;
            customTextBox1.BorderRadius = 5;
            customTextBox1.BorderSize = 2;
            customTextBox1.Font = new Font("Segoe UI", 9.5F);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(24, 64);
            customTextBox1.Margin = new Padding(4);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 7, 10, 7);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "";
            customTextBox1.Size = new Size(336, 36);
            customTextBox1.TabIndex = 3;
            customTextBox1.Texts = "";
            customTextBox1.UnderlinedStyle = false;
            customTextBox1.KeyPress += customTextBox1_KeyPress;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.LimeGreen;
            customButton1.BackgroundColor = Color.LimeGreen;
            customButton1.BorderColor = Color.Black;
            customButton1.BorderRadius = 20;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(24, 120);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(160, 50);
            customButton1.TabIndex = 0;
            customButton1.Text = "Plus";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.Crimson;
            customButton2.BackgroundColor = Color.Crimson;
            customButton2.BorderColor = Color.Black;
            customButton2.BorderRadius = 20;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(200, 120);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(162, 50);
            customButton2.TabIndex = 2;
            customButton2.Text = "Minus";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 4;
            label1.Text = "Current Money: Rp.0-";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 223);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 97);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 56);
            label2.Name = "label2";
            label2.Size = new Size(96, 18);
            label2.TabIndex = 6;
            label2.Text = "Flow: Rp.0-";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.DodgerBlue;
            customButton3.BackgroundColor = Color.DodgerBlue;
            customButton3.BorderColor = Color.Black;
            customButton3.BorderRadius = 20;
            customButton3.BorderSize = 0;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton3.ForeColor = Color.White;
            customButton3.Location = new Point(24, 376);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(336, 50);
            customButton3.TabIndex = 6;
            customButton3.Text = "Logs";
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            customButton3.Click += customButton3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 16);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 7;
            label3.Text = "Menu";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(386, 454);
            Controls.Add(label3);
            Controls.Add(customButton3);
            Controls.Add(panel1);
            Controls.Add(customTextBox1);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabungan Ceritanya";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Tabungan_Ceritanya_V2.Controls.CustomTextBox customTextBox1;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private CustomButton customButton3;
        private Label label3;
    }
}
