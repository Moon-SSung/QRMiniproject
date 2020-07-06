namespace QRMiniproject
{
    partial class InOutPutVisualForm
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.InputTab = new MetroFramework.Controls.MetroTabPage();
            this.InputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OutTab = new MetroFramework.Controls.MetroTabPage();
            this.OutChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroTabControl1.SuspendLayout();
            this.InputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputChart)).BeginInit();
            this.OutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutChart)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.InputTab);
            this.metroTabControl1.Controls.Add(this.OutTab);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(886, 451);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // InputTab
            // 
            this.InputTab.Controls.Add(this.InputChart);
            this.InputTab.HorizontalScrollbarBarColor = true;
            this.InputTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InputTab.HorizontalScrollbarSize = 10;
            this.InputTab.Location = new System.Drawing.Point(4, 38);
            this.InputTab.Name = "InputTab";
            this.InputTab.Size = new System.Drawing.Size(878, 409);
            this.InputTab.TabIndex = 0;
            this.InputTab.Text = "입고";
            this.InputTab.VerticalScrollbarBarColor = true;
            this.InputTab.VerticalScrollbarHighlightOnWheel = false;
            this.InputTab.VerticalScrollbarSize = 10;
            // 
            // InputChart
            // 
            chartArea1.Name = "ChartArea1";
            this.InputChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.InputChart.Legends.Add(legend1);
            this.InputChart.Location = new System.Drawing.Point(3, 3);
            this.InputChart.Name = "InputChart";
            this.InputChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.InputChart.Series.Add(series1);
            this.InputChart.Size = new System.Drawing.Size(872, 417);
            this.InputChart.TabIndex = 2;
            this.InputChart.Text = "chart1";
            // 
            // OutTab
            // 
            this.OutTab.Controls.Add(this.OutChart);
            this.OutTab.HorizontalScrollbarBarColor = true;
            this.OutTab.HorizontalScrollbarHighlightOnWheel = false;
            this.OutTab.HorizontalScrollbarSize = 10;
            this.OutTab.Location = new System.Drawing.Point(4, 38);
            this.OutTab.Name = "OutTab";
            this.OutTab.Size = new System.Drawing.Size(878, 409);
            this.OutTab.TabIndex = 1;
            this.OutTab.Text = "출고";
            this.OutTab.VerticalScrollbarBarColor = true;
            this.OutTab.VerticalScrollbarHighlightOnWheel = false;
            this.OutTab.VerticalScrollbarSize = 10;
            // 
            // OutChart
            // 
            chartArea2.Name = "ChartArea1";
            this.OutChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.OutChart.Legends.Add(legend2);
            this.OutChart.Location = new System.Drawing.Point(3, 3);
            this.OutChart.Name = "OutChart";
            this.OutChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.OutChart.Series.Add(series2);
            this.OutChart.Size = new System.Drawing.Size(872, 417);
            this.OutChart.TabIndex = 2;
            this.OutChart.Text = "chart1";
            // 
            // InOutPutVisualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 538);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "InOutPutVisualForm";
            this.Text = "InOutPutVisual";
            this.Activated += new System.EventHandler(this.InOutPutVisualForm_Activated);
            this.Load += new System.EventHandler(this.InOutPutVisual_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.InputTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputChart)).EndInit();
            this.OutTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage InputTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart InputChart;
        private MetroFramework.Controls.MetroTabPage OutTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart OutChart;
    }
}