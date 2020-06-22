namespace sistemiOdlocanja
{
    partial class NavadniGrafi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.VrednostiAlternativ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VrednostiUtezi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.VrednostiAlternativ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VrednostiUtezi)).BeginInit();
            this.SuspendLayout();
            // 
            // VrednostiAlternativ
            // 
            chartArea1.Name = "ChartArea1";
            this.VrednostiAlternativ.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.VrednostiAlternativ.Legends.Add(legend1);
            this.VrednostiAlternativ.Location = new System.Drawing.Point(46, 52);
            this.VrednostiAlternativ.Name = "VrednostiAlternativ";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "chartAlterniv";
            this.VrednostiAlternativ.Series.Add(series1);
            this.VrednostiAlternativ.Size = new System.Drawing.Size(437, 300);
            this.VrednostiAlternativ.TabIndex = 0;
            this.VrednostiAlternativ.Text = "vrednostiAlternativ";
            // 
            // VrednostiUtezi
            // 
            chartArea2.Name = "ChartArea1";
            this.VrednostiUtezi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.VrednostiUtezi.Legends.Add(legend2);
            this.VrednostiUtezi.Location = new System.Drawing.Point(638, 52);
            this.VrednostiUtezi.Name = "VrednostiUtezi";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "vrednostUtezi";
            this.VrednostiUtezi.Series.Add(series2);
            this.VrednostiUtezi.Size = new System.Drawing.Size(300, 300);
            this.VrednostiUtezi.TabIndex = 1;
            this.VrednostiUtezi.Text = "chart2";
            // 
            // NavadniGrafi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 456);
            this.Controls.Add(this.VrednostiUtezi);
            this.Controls.Add(this.VrednostiAlternativ);
            this.Name = "NavadniGrafi";
            this.Text = "NavadniGrafi";
            ((System.ComponentModel.ISupportInitialize)(this.VrednostiAlternativ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VrednostiUtezi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart VrednostiAlternativ;
        private System.Windows.Forms.DataVisualization.Charting.Chart VrednostiUtezi;
    }
}