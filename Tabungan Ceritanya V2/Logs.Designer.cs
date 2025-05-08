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
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            customButton3 = new InventorySystem.Controls.CustomButton();
            customButton1 = new InventorySystem.Controls.CustomButton();
            customButton2 = new InventorySystem.Controls.CustomButton();
            customButton4 = new InventorySystem.Controls.CustomButton();
            customButton5 = new InventorySystem.Controls.CustomButton();
            idBox = new TextBox();
            moneyBox = new TextBox();
            dateTimePicker = new DateTimePicker();
            reasonBox = new TextBox();
            typeBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(0, 0, 64);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 246);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(421, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(254, 28);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(250, 28);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(268, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.DodgerBlue;
            customButton3.BackgroundColor = Color.DodgerBlue;
            customButton3.BorderColor = Color.Black;
            customButton3.BorderRadius = 0;
            customButton3.BorderSize = 0;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton3.ForeColor = Color.White;
            customButton3.Location = new Point(681, 12);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(107, 28);
            customButton3.TabIndex = 7;
            customButton3.Text = "Reset";
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            customButton3.Click += customButton3_Click;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.DodgerBlue;
            customButton1.BackgroundColor = Color.DodgerBlue;
            customButton1.BorderColor = Color.Black;
            customButton1.BorderRadius = 13;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(12, 445);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(121, 43);
            customButton1.TabIndex = 8;
            customButton1.Text = "Back";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.Orange;
            customButton2.BackgroundColor = Color.Orange;
            customButton2.BorderColor = Color.Black;
            customButton2.BorderRadius = 13;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(413, 445);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(121, 43);
            customButton2.TabIndex = 9;
            customButton2.Text = "Update";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.Crimson;
            customButton4.BackgroundColor = Color.Crimson;
            customButton4.BorderColor = Color.Black;
            customButton4.BorderRadius = 13;
            customButton4.BorderSize = 0;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton4.ForeColor = Color.White;
            customButton4.Location = new Point(540, 445);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(121, 43);
            customButton4.TabIndex = 10;
            customButton4.Text = "Delete";
            customButton4.TextColor = Color.White;
            customButton4.UseVisualStyleBackColor = false;
            customButton4.Click += customButton4_Click;
            // 
            // customButton5
            // 
            customButton5.BackColor = Color.DodgerBlue;
            customButton5.BackgroundColor = Color.DodgerBlue;
            customButton5.BorderColor = Color.Black;
            customButton5.BorderRadius = 13;
            customButton5.BorderSize = 0;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton5.ForeColor = Color.White;
            customButton5.Location = new Point(667, 445);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(121, 43);
            customButton5.TabIndex = 11;
            customButton5.Text = "Clear";
            customButton5.TextColor = Color.White;
            customButton5.UseVisualStyleBackColor = false;
            // 
            // idBox
            // 
            idBox.Location = new Point(145, 334);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "ID";
            idBox.ReadOnly = true;
            idBox.Size = new Size(50, 28);
            idBox.TabIndex = 12;
            // 
            // moneyBox
            // 
            moneyBox.Location = new Point(210, 334);
            moneyBox.Name = "moneyBox";
            moneyBox.PlaceholderText = "Money";
            moneyBox.Size = new Size(188, 28);
            moneyBox.TabIndex = 13;
            moneyBox.KeyPress += moneyBox_KeyPress;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(413, 334);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(254, 28);
            dateTimePicker.TabIndex = 14;
            // 
            // reasonBox
            // 
            reasonBox.Location = new Point(210, 377);
            reasonBox.Name = "reasonBox";
            reasonBox.PlaceholderText = "Reason";
            reasonBox.Size = new Size(188, 28);
            reasonBox.TabIndex = 15;
            // 
            // typeBox
            // 
            typeBox.FormattingEnabled = true;
            typeBox.Items.AddRange(new object[] { "INCOME", "EXPENSE" });
            typeBox.Location = new Point(413, 377);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(147, 28);
            typeBox.TabIndex = 16;
            // 
            // Logs
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(800, 500);
            Controls.Add(typeBox);
            Controls.Add(reasonBox);
            Controls.Add(dateTimePicker);
            Controls.Add(moneyBox);
            Controls.Add(idBox);
            Controls.Add(customButton5);
            Controls.Add(customButton4);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Controls.Add(customButton3);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Logs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logs";
            Load += Logs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private InventorySystem.Controls.CustomButton customButton3;
        private InventorySystem.Controls.CustomButton customButton1;
        private InventorySystem.Controls.CustomButton customButton2;
        private InventorySystem.Controls.CustomButton customButton4;
        private InventorySystem.Controls.CustomButton customButton5;
        private TextBox idBox;
        private TextBox moneyBox;
        private DateTimePicker dateTimePicker;
        private TextBox reasonBox;
        private ComboBox typeBox;
    }
}