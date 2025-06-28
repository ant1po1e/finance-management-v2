using ClosedXML.Excel;
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

namespace Tabungan_Ceritanya_V2
{
    public partial class Logs : Form
    {
        SqliteConnection con = new SqliteConnection($"Data Source={Application.StartupPath}\\FinanceManagement.db");
        string baseQuery = "SELECT id AS ID, money AS Money, type AS Type, reason AS Reason, date AS Date FROM FinanceLogs";
        string query;

        Color defaultColor = Color.White;
        Color activeColor = Color.Silver;

        public Logs()
        {
            InitializeComponent();
            LoadLogs();
            AutoFilterByMonth();
        }

        private void LoadLogs()
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                con.Open();

                using (SqliteCommand cmd = new SqliteCommand(query, con))
                {
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            int money = reader.GetInt32(1);
                            string reason = reader.IsDBNull(3) ? "" : reader.GetString(3);
                            DateTime date = reader.GetDateTime(4);
                            Card card = new Card(id, money, reason, date);
                            flowLayoutPanel1.Controls.Add(card);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {
            string keyword = customTextBox1.Texts.Trim();
            query = baseQuery + " WHERE reason LIKE @keyword OR type LIKE @keyword OR CAST(money AS TEXT) LIKE @keyword";
            LoadLogsWithQuery(query, new SqliteParameter("@keyword", "%" + keyword + "%"));
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            ResetFilterButtonColors();
            customButton1.BackColor = activeColor;

            int year = DateTime.Now.Year;
            query = baseQuery + $" WHERE strftime('%m', date) BETWEEN '01' AND '04' AND strftime('%Y', date) = '{year}'";
            LoadLogs();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            ResetFilterButtonColors();
            customButton2.BackColor = activeColor;

            int year = DateTime.Now.Year;
            query = baseQuery + $" WHERE strftime('%m', date) BETWEEN '05' AND '08' AND strftime('%Y', date) = '{year}'";
            LoadLogs();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            ResetFilterButtonColors();
            customButton3.BackColor = activeColor;

            int year = DateTime.Now.Year;
            query = baseQuery + $" WHERE strftime('%m', date) BETWEEN '09' AND '12' AND strftime('%Y', date) = '{year}'";
            LoadLogs();
        }

        private void LoadLogsWithQuery(string sql, params SqliteParameter[] parameters)
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                con.Open();

                using (SqliteCommand cmd = new SqliteCommand(sql, con))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            int money = reader.GetInt32(1);
                            string type = reader.GetString(2);
                            string reason = reader.IsDBNull(3) ? "" : reader.GetString(3);
                            DateTime date = reader.GetDateTime(4);
                            Card card = new Card(id, money, reason, date);
                            flowLayoutPanel1.Controls.Add(card);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ResetFilterButtonColors()
        {
            customButton1.BackColor = defaultColor;
            customButton2.BackColor = defaultColor;
            customButton3.BackColor = defaultColor;
        }

        private void AutoFilterByMonth()
        {
            int month = DateTime.Now.Month;

            if (month >= 1 && month <= 4)
                customButton1_Click(null, null);
            else if (month >= 5 && month <= 8)
                customButton2_Click(null, null);
            else
                customButton3_Click(null, null);
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                con.Open();
                using (SqliteCommand cmd = new SqliteCommand(query ?? baseQuery, con))
                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dt.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                    }

                    while (reader.Read())
                    {
                        object[] row = new object[reader.FieldCount];
                        reader.GetValues(row);
                        dt.Rows.Add(row);
                    }
                }
                con.Close();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("FinanceLogs");
                    var table = worksheet.Cell(1, 1).InsertTable(dt);
                    table.Theme = XLTableTheme.TableStyleMedium2; 

                    var headerRow = worksheet.RangeUsed().FirstRow();
                    headerRow.Style.Font.Bold = true;
                    headerRow.Style.Fill.BackgroundColor = XLColor.SkyBlue;
                    headerRow.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    worksheet.Columns().AdjustToContents();

                    int typeColIndex = dt.Columns["Type"].Ordinal + 1; 
                    int moneyColIndex = dt.Columns["Money"].Ordinal + 1;

                    for (int i = 2; i <= dt.Rows.Count + 1; i++) 
                    {
                        var typeCell = worksheet.Cell(i, typeColIndex);
                        var moneyCell = worksheet.Cell(i, moneyColIndex);

                        if (typeCell.Value.ToString() == "EXPENSE")
                        {
                            typeCell.Style.Fill.BackgroundColor = XLColor.LightCoral;
                            moneyCell.Style.Font.FontColor = XLColor.Red;
                        }
                        else if (typeCell.Value.ToString() == "INCOME")
                        {
                            typeCell.Style.Fill.BackgroundColor = XLColor.LightGreen;
                            moneyCell.Style.Font.FontColor = XLColor.DarkGreen;
                        }
                    }


                    using (SaveFileDialog sfd = new SaveFileDialog()
                    {
                        Filter = "Excel Workbook|*.xlsx",
                        FileName = $"FinanceLogs_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
                    })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Export successful!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
