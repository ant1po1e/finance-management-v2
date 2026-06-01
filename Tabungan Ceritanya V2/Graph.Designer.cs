using Tabungan_Ceritanya_V2.Controls;

namespace Tabungan_Ceritanya_V2
{
    partial class Graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            customButton4 = new CustomButton();
            label3 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.Coral;
            customButton4.BackgroundColor = Color.Coral;
            customButton4.BorderColor = Color.PaleVioletRed;
            customButton4.BorderRadius = 10;
            customButton4.BorderSize = 0;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            customButton4.ForeColor = Color.White;
            customButton4.Location = new Point(16, 456);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(112, 40);
            customButton4.TabIndex = 5;
            customButton4.Text = "Close";
            customButton4.TextColor = Color.White;
            customButton4.UseVisualStyleBackColor = false;
            customButton4.Click += customButton4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(376, 464);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 8;
            label3.Text = "Graph";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chart1
            // 
            chart1.BackColor = Color.FromArgb(64, 64, 64);
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 12);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            chart1.RightToLeft = RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(768, 421);
            chart1.TabIndex = 9;
            chart1.Text = "chart1";
            // 
            // Graph
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(803, 512);
            Controls.Add(chart1);
            Controls.Add(label3);
            Controls.Add(customButton4);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Graph";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logs";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomButton customButton4;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}