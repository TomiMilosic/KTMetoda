namespace sistemiOdlocanja
{
    partial class ObcutljivostForm
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
            this.chartObcutljivosti = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartObcutljivosti)).BeginInit();
            this.SuspendLayout();
            // 
            // chartObcutljivosti
            // 
            chartArea1.Name = "ChartArea1";
            this.chartObcutljivosti.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartObcutljivosti.Legends.Add(legend1);
            this.chartObcutljivosti.Location = new System.Drawing.Point(119, 12);
            this.chartObcutljivosti.Name = "chartObcutljivosti";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "obculjivost";
            series1.YValuesPerPoint = 4;
            this.chartObcutljivosti.Series.Add(series1);
            this.chartObcutljivosti.Size = new System.Drawing.Size(875, 439);
            this.chartObcutljivosti.TabIndex = 0;
            this.chartObcutljivosti.Text = "GrafObčutljivosti";
            // 
            // ObcutljivostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 463);
            this.Controls.Add(this.chartObcutljivosti);
            this.Name = "ObcutljivostForm";
            this.Text = "ObcutljivostForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartObcutljivosti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartObcutljivosti;
    }
}