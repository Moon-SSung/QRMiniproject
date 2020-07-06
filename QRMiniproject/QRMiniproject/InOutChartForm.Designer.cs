namespace QRMiniproject
{
    partial class InOutChartForm
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
            this.InOutTabControl = new MetroFramework.Controls.MetroTabControl();
            this.InputChart = new MetroFramework.Controls.MetroTabPage();
            this.OutChart = new MetroFramework.Controls.MetroTabPage();
            this.InPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OutPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InOutTabControl.SuspendLayout();
            this.InputChart.SuspendLayout();
            this.OutChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InPieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutPieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // InOutTabControl
            // 
            this.InOutTabControl.Controls.Add(this.InputChart);
            this.InOutTabControl.Controls.Add(this.OutChart);
            this.InOutTabControl.Location = new System.Drawing.Point(12, 12);
            this.InOutTabControl.Name = "InOutTabControl";
            this.InOutTabControl.SelectedIndex = 1;
            this.InOutTabControl.Size = new System.Drawing.Size(776, 426);
            this.InOutTabControl.TabIndex = 0;
            this.InOutTabControl.UseSelectable = true;
            this.InOutTabControl.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // InputChart
            // 
            this.InputChart.Controls.Add(this.InPieChart);
            this.InputChart.HorizontalScrollbarBarColor = true;
            this.InputChart.HorizontalScrollbarHighlightOnWheel = false;
            this.InputChart.HorizontalScrollbarSize = 10;
            this.InputChart.Location = new System.Drawing.Point(4, 38);
            this.InputChart.Name = "InputChart";
            this.InputChart.Size = new System.Drawing.Size(768, 384);
            this.InputChart.TabIndex = 0;
            this.InputChart.Text = "입고";
            this.InputChart.VerticalScrollbarBarColor = true;
            this.InputChart.VerticalScrollbarHighlightOnWheel = false;
            this.InputChart.VerticalScrollbarSize = 10;
            // 
            // OutChart
            // 
            this.OutChart.Controls.Add(this.OutPieChart);
            this.OutChart.HorizontalScrollbarBarColor = true;
            this.OutChart.HorizontalScrollbarHighlightOnWheel = false;
            this.OutChart.HorizontalScrollbarSize = 10;
            this.OutChart.Location = new System.Drawing.Point(4, 38);
            this.OutChart.Name = "OutChart";
            this.OutChart.Size = new System.Drawing.Size(768, 384);
            this.OutChart.TabIndex = 1;
            this.OutChart.Text = "출고";
            this.OutChart.VerticalScrollbarBarColor = true;
            this.OutChart.VerticalScrollbarHighlightOnWheel = false;
            this.OutChart.VerticalScrollbarSize = 10;
            // 
            // InPieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.InPieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.InPieChart.Legends.Add(legend1);
            this.InPieChart.Location = new System.Drawing.Point(3, 3);
            this.InPieChart.Name = "InPieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.InPieChart.Series.Add(series1);
            this.InPieChart.Size = new System.Drawing.Size(762, 378);
            this.InPieChart.TabIndex = 2;
            this.InPieChart.Text = "chart1";
            // 
            // OutPieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.OutPieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.OutPieChart.Legends.Add(legend2);
            this.OutPieChart.Location = new System.Drawing.Point(3, 3);
            this.OutPieChart.Name = "OutPieChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.OutPieChart.Series.Add(series2);
            this.OutPieChart.Size = new System.Drawing.Size(762, 378);
            this.OutPieChart.TabIndex = 2;
            this.OutPieChart.Text = "chart1";
            // 
            // InOutChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InOutTabControl);
            this.Name = "InOutChartForm";
            this.Text = "InOutChartForm";
            this.Activated += new System.EventHandler(this.InOutChartForm_Activated);
            this.InOutTabControl.ResumeLayout(false);
            this.InputChart.ResumeLayout(false);
            this.OutChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InPieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutPieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl InOutTabControl;
        private MetroFramework.Controls.MetroTabPage InputChart;
        private MetroFramework.Controls.MetroTabPage OutChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart InPieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart OutPieChart;
    }
}