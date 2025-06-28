using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Globalization;

namespace Tabungan_Ceritanya_V2
{
    public partial class Card : UserControl
    {
        public int TransactionId { get; private set; }
        private int thisMoney;

        public Card(int id, int money, string reason, DateTime date)
        {
            InitializeComponent();
            TransactionId = id;
            moneyLabel.Text = money.ToString("C0");
            thisMoney = money;
            reasonLabel.Text = reason;
            dateLabel.Text = date.ToString("dd MMM yyyy");
        }

        private void Card_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(RefreshData));
                return;
            }

            if (thisMoney < 0)
            {
                moneyLabel.BackColor = Color.Tomato;
            }
            else
            {
                moneyLabel.BackColor = Color.PaleGreen;
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            int currentMoney = int.Parse(moneyLabel.Text.Replace("Rp", "").Replace(".", "").Trim());
            string currentReason = reasonLabel.Text;
            DateTime currentDate = DateTime.Parse(dateLabel.Text);

            EditLog form = new EditLog(currentMoney, currentReason, currentDate, this);
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var con = new SqliteConnection($"Data Source={Application.StartupPath}\\FinanceManagement.db"))
                {
                    try
                    {
                        con.Open();
                        using (var cmd = new SqliteCommand("UPDATE FinanceLogs SET money = @money, reason = @reason, date = @date WHERE id = @id", con))
                        {
                            cmd.Parameters.AddWithValue("@money", form.UpdatedMoney);
                            cmd.Parameters.AddWithValue("@reason", (object)form.UpdatedReason ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@date", form.UpdatedDate);
                            cmd.Parameters.AddWithValue("@id", TransactionId);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Transaction updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        moneyLabel.Text = form.UpdatedMoney.ToString("C0");
                        reasonLabel.Text = form.UpdatedReason;
                        dateLabel.Text = form.UpdatedDate.ToString("dd MMM yyyy");
                        thisMoney = form.UpdatedMoney;
                        RefreshData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating transaction: " + ex.Message);
                    }
                }
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this transaction?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (var con = new SqliteConnection($"Data Source={Application.StartupPath}\\FinanceManagement.db"))
                {
                    try
                    {
                        con.Open();
                        using (var cmd = new SqliteCommand("DELETE FROM FinanceLogs WHERE id = @id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", TransactionId);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Transaction deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Parent.Controls.Remove(this);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting transaction: " + ex.Message);
                    }
                }
            }
        }
    }
}
