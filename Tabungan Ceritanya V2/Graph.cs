using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tabungan_Ceritanya_V2
{
    public partial class Graph : Form
    {
        private SqliteConnection con =
            new SqliteConnection($"Data Source={Application.StartupPath}\\FinanceManagement.db");

        public Graph()
        {
            InitializeComponent();
            LoadGraph();
        }

        private void LoadGraph()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();
            chart1.Titles.Clear();

            ChartArea area = new ChartArea("MainArea");

            // Background chart area
            area.BackColor = Color.FromArgb(28, 28, 28);

            // Axis X
            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisX.LineColor = Color.Gray;
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(50, 50, 50);
            area.AxisX.TitleForeColor = Color.White;

            // Axis Y
            area.AxisY.LabelStyle.ForeColor = Color.White;
            area.AxisY.LineColor = Color.Gray;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(50, 50, 50);
            area.AxisY.TitleForeColor = Color.White;

            area.AxisX.Interval = 1;
            area.AxisX.Title = "Month";
            area.AxisY.Title = "Amount";
            area.AxisY.LabelStyle.Format = "#,##0";

            chart1.ChartAreas.Add(area);

            chart1.Legends.Add(new Legend("Legend"));
            chart1.BackColor = Color.FromArgb(18, 18, 18);

            chart1.Legends[0].BackColor = Color.FromArgb(18, 18, 18);
            chart1.Legends[0].ForeColor = Color.White;
            Title title = new Title();
            title.Text = $"Income vs Expense ({DateTime.Now.Year})";
            title.ForeColor = Color.White;
            title.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            chart1.Titles.Add(title);

            string[] months =
            {
                "Jan","Feb","Mar","Apr",
                "May","Jun","Jul","Aug",
                "Sep","Oct","Nov","Dec"
            };

            decimal[] incomeData = new decimal[12];
            decimal[] expenseData = new decimal[12];

            try
            {
                con.Open();

                string sql = @"
                    SELECT
                        CAST(strftime('%m', date) AS INTEGER) AS MonthNumber,

                        SUM(
                            CASE
                                WHEN type = 'INCOME'
                                THEN money
                                ELSE 0
                            END
                        ) AS Income,

                        SUM(
                            CASE
                                WHEN type = 'EXPENSE'
                                THEN ABS(money)
                                ELSE 0
                            END
                        ) AS Expense

                    FROM FinanceLogs

                    WHERE strftime('%Y', date) = @year

                    GROUP BY MonthNumber
                    ORDER BY MonthNumber;";

                using (SqliteCommand cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@year", DateTime.Now.Year.ToString());

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int monthIndex = reader.GetInt32(0) - 1;

                            incomeData[monthIndex] =
                                reader.IsDBNull(1)
                                ? 0
                                : Convert.ToDecimal(reader.GetValue(1));

                            expenseData[monthIndex] =
                                reader.IsDBNull(2)
                                ? 0
                                : Convert.ToDecimal(reader.GetValue(2));
                        }
                    }
                }

                Series incomeSeries = new Series("Income")
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 3,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8,
                    XValueType = ChartValueType.String,
                    IsXValueIndexed = true,
                    Color = Color.LimeGreen
                };

                Series expenseSeries = new Series("Expense")
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 3,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8,
                    XValueType = ChartValueType.String,
                    IsXValueIndexed = true,
                    Color = Color.Tomato
                };

                for (int i = 0; i < 12; i++)
                {
                    incomeSeries.Points.AddXY(months[i], (double)incomeData[i]);
                    expenseSeries.Points.AddXY(months[i], (double)expenseData[i]);
                }

                chart1.Series.Add(incomeSeries);
                chart1.Series.Add(expenseSeries);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error loading graph:\n\n{ex.Message}",
                    "Graph Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            Logs logsForm = new Logs();
            logsForm.Show();
            this.Close();
        }
    }
}