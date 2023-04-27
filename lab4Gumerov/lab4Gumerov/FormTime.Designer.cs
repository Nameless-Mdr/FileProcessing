namespace lab4Gumerov
{
    partial class FormTime
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartM1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartM2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartM4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartM3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartM4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartM3)).BeginInit();
            this.SuspendLayout();
            // 
            // chartM1
            // 
            chartArea1.Name = "ChartArea1";
            this.chartM1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartM1.Legends.Add(legend1);
            this.chartM1.Location = new System.Drawing.Point(12, 1);
            this.chartM1.Name = "chartM1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "SearchLinq";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "SearchNoLinq";
            this.chartM1.Series.Add(series1);
            this.chartM1.Series.Add(series2);
            this.chartM1.Size = new System.Drawing.Size(400, 300);
            this.chartM1.TabIndex = 0;
            this.chartM1.Text = "chart1";
            // 
            // chartM2
            // 
            chartArea2.Name = "ChartArea1";
            this.chartM2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartM2.Legends.Add(legend2);
            this.chartM2.Location = new System.Drawing.Point(418, 1);
            this.chartM2.Name = "chartM2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "SearchLinq";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "SearchNoLinq";
            this.chartM2.Series.Add(series3);
            this.chartM2.Series.Add(series4);
            this.chartM2.Size = new System.Drawing.Size(400, 300);
            this.chartM2.TabIndex = 1;
            this.chartM2.Text = "chart2";
            // 
            // chartM4
            // 
            chartArea3.Name = "ChartArea1";
            this.chartM4.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartM4.Legends.Add(legend3);
            this.chartM4.Location = new System.Drawing.Point(418, 307);
            this.chartM4.Name = "chartM4";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "SearchLinq";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "SearchNoLinq";
            this.chartM4.Series.Add(series5);
            this.chartM4.Series.Add(series6);
            this.chartM4.Size = new System.Drawing.Size(400, 300);
            this.chartM4.TabIndex = 3;
            this.chartM4.Text = "chart3";
            // 
            // chartM3
            // 
            chartArea4.Name = "ChartArea1";
            this.chartM3.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartM3.Legends.Add(legend4);
            this.chartM3.Location = new System.Drawing.Point(12, 307);
            this.chartM3.Name = "chartM3";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "SearchLinq";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "SearchNoLinq";
            this.chartM3.Series.Add(series7);
            this.chartM3.Series.Add(series8);
            this.chartM3.Size = new System.Drawing.Size(400, 300);
            this.chartM3.TabIndex = 2;
            this.chartM3.Text = "chart4";
            // 
            // FormTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 619);
            this.Controls.Add(this.chartM4);
            this.Controls.Add(this.chartM3);
            this.Controls.Add(this.chartM2);
            this.Controls.Add(this.chartM1);
            this.Name = "FormTime";
            this.Text = "FormTime";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartM4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartM3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartM1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartM2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartM4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartM3;
    }
}