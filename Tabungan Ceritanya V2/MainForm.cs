using Microsoft.Data.Sqlite;
using System.Data;

namespace Tabungan_Ceritanya_V2
{
    public partial class MainForm : Form
    {
        SqliteConnection con = new SqliteConnection($"Data Source={Application.StartupPath}\\FinanceManagement.db");

        public MainForm()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            try
            {
                con.Open();

                string createLog = "CREATE TABLE IF NOT EXISTS FinanceLogs (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT, money INTEGER NOT NULL, " +
                    "type TEXT NOT NULL CHECK (type = 'EXPENSE' OR type = 'INCOME'), " +
                    "reason TEXT, " +
                    "date DATETIME DEFAULT (CURRENT_TIMESTAMP) NOT NULL);";

                new SqliteCommand(createLog, con).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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

            CurrentMoney();
            TotalIncome();
        }

        private void CurrentMoney()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                using (SqliteCommand cmd = new SqliteCommand("SELECT IFNULL(SUM(money), 0) FROM FinanceLogs", con))
                {
                    object result = cmd.ExecuteScalar();
                    decimal total = Convert.ToDecimal(result);
                    label1.Text = "Current Money: " + total.ToString("C2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            AddTransaction("INCOME");
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            AddTransaction("EXPENSE");
        }

        private void TotalIncome()
        {
            decimal income = 0;
            decimal expense = 0;

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                using (SqliteCommand cmd = new SqliteCommand("SELECT SUM(money) FROM FinanceLogs WHERE type = 'INCOME'", con))
                {
                    object result = cmd.ExecuteScalar();
                    income = (result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
                }

                using (SqliteCommand cmd = new SqliteCommand("SELECT SUM(ABS(money)) FROM FinanceLogs WHERE type = 'EXPENSE'", con))
                {
                    object result = cmd.ExecuteScalar();
                    expense = (result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
                }

                decimal total = income - expense;

                label2.Text = "Total Income: " + total.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void AddTransaction(string type)
        {
            if (string.IsNullOrWhiteSpace(customTextBox1.Texts))
            {
                MessageBox.Show("Please fill the blank fields.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(customTextBox1.Texts, out int jumlahInt))
            {
                decimal jumlah = jumlahInt;

                if (type == "EXPENSE")
                    jumlah = -Math.Abs(jumlah);

                string reason = null;

                if (type == "EXPENSE")
                {
                    reason = PromptReason();

                    if (string.IsNullOrWhiteSpace(reason))
                    {
                        MessageBox.Show("A reason must be filled in for the expenditure.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    using (SqliteCommand cmd = new SqliteCommand("INSERT INTO FinanceLogs (money, type, date, reason) VALUES (@money, @type, CURRENT_TIMESTAMP, @reason)", con))
                    {
                        cmd.Parameters.AddWithValue("@money", jumlah);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@reason", (object)reason ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"{(type == "INCOME" ? "Income" : "Expense")} recorder successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    customTextBox1.Texts = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Number must be round without any commas.");
            }
        }

        private string PromptReason()
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 400;
                prompt.Height = 200;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.Text = "Enter the reason for the expense";
                prompt.StartPosition = FormStartPosition.CenterScreen;

                Label textLabel = new Label() { Left = 20, Top = 20, Text = "Reason:" };
                TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
                Button confirmation = new Button() { Text = "OK", Left = 270, Width = 90, Top = 120, DialogResult = DialogResult.OK };

                confirmation.Click += (sender, e) => { prompt.Close(); };

                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            Logs logs = new Logs();
            logs.Show();
            this.Hide();
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
