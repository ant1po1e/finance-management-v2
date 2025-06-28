namespace Tabungan_Ceritanya_V2
{
    partial class EditLog
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
            customButton1 = new Tabungan_Ceritanya_V2.Controls.CustomButton();
            customTextBox1 = new Tabungan_Ceritanya_V2.Controls.CustomTextBox();
            label3 = new Label();
            customTextBox2 = new Tabungan_Ceritanya_V2.Controls.CustomTextBox();
            dateTimePicker1 = new DateTimePicker();
            customButton2 = new Tabungan_Ceritanya_V2.Controls.CustomButton();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.PaleGreen;
            customButton1.BackgroundColor = Color.PaleGreen;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 10;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton1.ForeColor = Color.Black;
            customButton1.Location = new Point(192, 200);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(120, 40);
            customButton1.TabIndex = 3;
            customButton1.Text = "Confirm";
            customButton1.TextColor = Color.Black;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.BorderColor = Color.Teal;
            customTextBox1.BorderFocusColor = Color.PaleTurquoise;
            customTextBox1.BorderRadius = 5;
            customTextBox1.BorderSize = 2;
            customTextBox1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customTextBox1.ForeColor = Color.Black;
            customTextBox1.Location = new Point(16, 56);
            customTextBox1.Margin = new Padding(4);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 7, 10, 7);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DimGray;
            customTextBox1.PlaceholderText = "";
            customTextBox1.Size = new Size(336, 35);
            customTextBox1.TabIndex = 4;
            customTextBox1.Texts = "";
            customTextBox1.UnderlinedStyle = false;
            customTextBox1.KeyPress += customTextBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(128, 16);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 8;
            label3.Text = "Edit Log";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = SystemColors.Window;
            customTextBox2.BorderColor = Color.Teal;
            customTextBox2.BorderFocusColor = Color.PaleTurquoise;
            customTextBox2.BorderRadius = 5;
            customTextBox2.BorderSize = 2;
            customTextBox2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customTextBox2.ForeColor = Color.Black;
            customTextBox2.Location = new Point(16, 104);
            customTextBox2.Margin = new Padding(4);
            customTextBox2.Multiline = false;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(10, 7, 10, 7);
            customTextBox2.PasswordChar = false;
            customTextBox2.PlaceholderColor = Color.DimGray;
            customTextBox2.PlaceholderText = "";
            customTextBox2.Size = new Size(336, 35);
            customTextBox2.TabIndex = 9;
            customTextBox2.Texts = "";
            customTextBox2.UnderlinedStyle = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(16, 152);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(160, 28);
            dateTimePicker1.TabIndex = 10;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.LightSalmon;
            customButton2.BackgroundColor = Color.LightSalmon;
            customButton2.BorderColor = Color.PaleVioletRed;
            customButton2.BorderRadius = 10;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton2.ForeColor = Color.Black;
            customButton2.Location = new Point(56, 200);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(120, 40);
            customButton2.TabIndex = 11;
            customButton2.Text = "Cancel";
            customButton2.TextColor = Color.Black;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(192, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 28);
            comboBox1.TabIndex = 12;
            // 
            // EditLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(369, 259);
            Controls.Add(comboBox1);
            Controls.Add(customButton2);
            Controls.Add(dateTimePicker1);
            Controls.Add(customTextBox2);
            Controls.Add(label3);
            Controls.Add(customTextBox1);
            Controls.Add(customButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditLog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.CustomButton customButton1;
        private Controls.CustomTextBox customTextBox1;
        private Label label3;
        private Controls.CustomTextBox customTextBox2;
        private DateTimePicker dateTimePicker1;
        private Controls.CustomButton customButton2;
        private ComboBox comboBox1;
    }
}