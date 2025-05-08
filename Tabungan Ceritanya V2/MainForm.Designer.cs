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
            plusButton = new InventorySystem.Controls.CustomButton();
            minusButton = new InventorySystem.Controls.CustomButton();
            customTextBox1 = new InventorySystem.Controls.CustomTextBox();
            customButton1 = new InventorySystem.Controls.CustomButton();
            customButton2 = new InventorySystem.Controls.CustomButton();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            customButton3 = new InventorySystem.Controls.CustomButton();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // plusButton
            // 
            plusButton.BackColor = Color.LimeGreen;
            plusButton.BackgroundColor = Color.LimeGreen;
            plusButton.BorderColor = Color.PaleVioletRed;
            plusButton.BorderRadius = 20;
            plusButton.BorderSize = 0;
            plusButton.FlatAppearance.BorderSize = 0;
            plusButton.FlatStyle = FlatStyle.Flat;
            plusButton.ForeColor = Color.White;
            plusButton.Location = new Point(37, 120);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(146, 50);
            plusButton.TabIndex = 0;
            plusButton.Text = "Plus";
            plusButton.TextColor = Color.White;
            plusButton.UseVisualStyleBackColor = false;
            // 
            // minusButton
            // 
            minusButton.BackColor = Color.Crimson;
            minusButton.BackgroundColor = Color.Crimson;
            minusButton.BorderColor = Color.PaleVioletRed;
            minusButton.BorderRadius = 20;
            minusButton.BorderSize = 0;
            minusButton.FlatAppearance.BorderSize = 0;
            minusButton.FlatStyle = FlatStyle.Flat;
            minusButton.ForeColor = Color.White;
            minusButton.Location = new Point(203, 120);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(146, 50);
            minusButton.TabIndex = 2;
            minusButton.Text = "Minus";
            minusButton.TextColor = Color.White;
            minusButton.UseVisualStyleBackColor = false;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.BorderColor = Color.Teal;
            customTextBox1.BorderFocusColor = Color.PaleTurquoise;
            customTextBox1.BorderRadius = 0;
            customTextBox1.BorderSize = 2;
            customTextBox1.Font = new Font("Segoe UI", 9.5F);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(37, 68);
            customTextBox1.Margin = new Padding(4);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 7, 10, 7);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "";
            customTextBox1.Size = new Size(312, 36);
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
            customButton1.Location = new Point(37, 120);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(146, 50);
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
            customButton2.Location = new Point(203, 120);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(146, 50);
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
            panel1.Location = new Point(37, 223);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 97);
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
            customButton3.Location = new Point(37, 377);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(312, 50);
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
            label3.Location = new Point(37, 23);
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
            Controls.Add(minusButton);
            Controls.Add(plusButton);
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

        private InventorySystem.Controls.CustomButton plusButton;
        private InventorySystem.Controls.CustomButton minusButton;
        private InventorySystem.Controls.CustomTextBox customTextBox1;
        private InventorySystem.Controls.CustomButton customButton1;
        private InventorySystem.Controls.CustomButton customButton2;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private InventorySystem.Controls.CustomButton customButton3;
        private Label label3;
    }
}
