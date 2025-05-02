using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tabungan_Ceritanya_V2
{
    public partial class Logs : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lenovo\Documents\Tabungan Ceritanya.mdf"";Integrated Security=True;Connect Timeout=30");
        string query = "SELECT id AS ID, money AS Money, type AS Type, reason AS Reason, date AS Date FROM FinanceLogs";

        string filterText = "";
        string filterType = "";
        DateTime? filterDate = null;

        public Logs()
        {
            InitializeComponent();
        }

        private void LoadDataGrid()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }

                    ColorTypeColumn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Theres an error:\n\n" + $"Message: {ex.Message}\n" + $"Source: {ex.Source}\n" + $"Stack Trace: {ex.StackTrace}\n", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void ColorTypeColumn()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Type"].Value != null)
                {
                    string type = row.Cells["Type"].Value.ToString();

                    if (type.Equals("INCOME", StringComparison.OrdinalIgnoreCase))
                    {
                        row.Cells["Type"].Style.BackColor = Color.LightGreen;
                        row.Cells["Type"].Style.ForeColor = Color.Black;
                    }
                    else if (type.Equals("EXPENSE", StringComparison.OrdinalIgnoreCase))
                    {
                        row.Cells["Type"].Style.BackColor = Color.LightCoral;
                        row.Cells["Type"].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "ALL", "INCOME", "EXPENSE" });
            comboBox1.SelectedIndex = 0;

            filterDate = null;

            LoadDataGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filterText = textBox1.Text;
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            try
            {
                List<string> conditions = new List<string>();

                if (!string.IsNullOrWhiteSpace(filterText))
                {
                    conditions.Add("reason LIKE @reason");
                }

                if (!string.IsNullOrWhiteSpace(filterType) && filterType != "ALL")
                {
                    conditions.Add("type = @type");
                }

                if (filterDate.HasValue)
                {
                    conditions.Add("CAST(date AS DATE) = @date");
                }

                string whereClause = conditions.Count > 0 ? "WHERE " + string.Join(" AND ", conditions) : "";

                string finalQuery = $"SELECT id AS ID, money AS Money, type AS Type, reason AS Reason, date AS Date FROM FinanceLogs {whereClause}";

                using (SqlCommand cmd = new SqlCommand(finalQuery, con))
                {
                    if (!string.IsNullOrWhiteSpace(filterText))
                    {
                        cmd.Parameters.AddWithValue("@reason", "%" + filterText + "%");
                    }

                    if (!string.IsNullOrWhiteSpace(filterType) && filterType != "ALL")
                    {
                        cmd.Parameters.AddWithValue("@type", filterType);
                    }

                    if (filterDate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@date", filterDate.Value.Date);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Theres an error:\n\n" + $"Message: {ex.Message}\n" + $"Source: {ex.Source}\n" + $"Stack Trace: {ex.StackTrace}\n", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterType = comboBox1.SelectedItem.ToString();
            ApplyFilters();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            filterDate = dateTimePicker1.Value;
            ApplyFilters();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            filterDate = null;
            dateTimePicker1.Value = DateTime.Today;

            ApplyFilters();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                idBox.Text = row.Cells["ID"].Value?.ToString() ?? "";
                moneyBox.Text = row.Cells["Money"].Value?.ToString() ?? "";
                typeBox.Text = row.Cells["Type"].Value?.ToString() ?? "";
                reasonBox.Text = row.Cells["Reason"].Value?.ToString() ?? "";

                if (row.Cells["Date"].Value != null && row.Cells["Date"].Value != DBNull.Value)
                {
                    dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Date"].Value);
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Today;
                }
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(moneyBox.Text))
            {
                MessageBox.Show("Please enter a valid amount.");
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("UPDATE FinanceLogs SET money = @money, type = @type, reason = @reason, date = @date WHERE id = @id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", idBox.Text);
                            cmd.Parameters.AddWithValue("@money", moneyBox.Text);
                            cmd.Parameters.AddWithValue("@type", typeBox.Text);
                            cmd.Parameters.AddWithValue("@reason", reasonBox.Text);
                            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Theres an error:\n\n" + $"Message: {ex.Message}\n" + $"Source: {ex.Source}\n" + $"Stack Trace: {ex.StackTrace}\n", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                        LoadDataGrid();
                        ClearInputs();
                    }
                }
            }
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idBox.Text))
            {
                MessageBox.Show("Please select a data.");
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM FinanceLogs WHERE id = @id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", idBox.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Theres an error:\n\n" + $"Message: {ex.Message}\n" + $"Source: {ex.Source}\n" + $"Stack Trace: {ex.StackTrace}\n", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                        LoadDataGrid();
                        ClearInputs();
                    }
                }
            }
        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            idBox.Clear();
            moneyBox.Clear();
            typeBox.SelectedIndex = 0;
            reasonBox.Clear();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
