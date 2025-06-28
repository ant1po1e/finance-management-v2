using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tabungan_Ceritanya_V2.Controls;

namespace Tabungan_Ceritanya_V2
{
    public partial class EditLog : Form
    {
        public int UpdatedMoney { get; private set; }
        public string UpdatedReason { get; private set; }
        public DateTime UpdatedDate { get; private set; }

        private Card parentCard;


        public EditLog(int money, string reason, DateTime date, Card cardRef)
        {
            InitializeComponent();

            parentCard = cardRef;

            customTextBox2.Texts = reason;
            dateTimePicker1.Value = date;

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "INCOME", "EXPENSE" });
            comboBox1.SelectedIndex = 0;

            if (money < 0)
            {
                comboBox1.SelectedItem = "EXPENSE";
                customTextBox1.Texts = Math.Abs(money).ToString(); 
            }
            else
            {
                comboBox1.SelectedItem = "INCOME";
                customTextBox1.Texts = money.ToString();
            }

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(customTextBox1.Texts.Trim(), out int money))
            {
                MessageBox.Show("Invalid number for money.");
                return;
            }

            string selectedType = comboBox1.SelectedItem?.ToString();

            if (selectedType == "EXPENSE")
            {
                money = -Math.Abs(money); 
            }
            else
            {
                money = Math.Abs(money); 
            }

            var confirm = MessageBox.Show("Are you sure you want to save the changes?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                UpdatedMoney = money;
                UpdatedReason = string.IsNullOrWhiteSpace(customTextBox2.Texts) ? null : customTextBox2.Texts.Trim();
                UpdatedDate = dateTimePicker1.Value;

                parentCard?.RefreshData();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void customButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void customTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
