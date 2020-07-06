using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QRMiniproject
{
    public partial class InOutChartForm : Form
    {
        public InOutChartForm()
        {
            InitializeComponent();
        }

        public void UpdateData()
        {
            // 탭을 눌렸을 때 현황을 차트에 뿌림
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT sum(count), ID FROM InputTbl" +
                                  " GROUP BY ID ";
                SqlDataReader reader = cmd.ExecuteReader();
                InPieChart.Series["Series1"].Points.Clear();
                while (reader.Read())
                {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(reader[1]+" "+reader[0]+"개", reader[0]);
                    point.ToolTip = string.Format("{0}, {1}", reader[1], reader[0]);
                    InPieChart.Series["Series1"].Points.Add(point);
                }
                reader.Close();
                cmd.CommandText = @"select p.Name, o.count * p.price as '판매총액'
                                        from OutputTbl as o
                                        INNER JOIN ProductTbl as p
                                        on o.productIdx = p.p_idx; ";
                reader = cmd.ExecuteReader();
                OutPieChart.Series["Series1"].Points.Clear();
                while (reader.Read())
                {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(reader[0]+" "+reader[1]+"원", reader[1]);
                    point.ToolTip = string.Format("{0}, {1}", reader[0], reader[1]);
                    OutPieChart.Series["Series1"].Points.Add(point);
                }
            }
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void InOutChartForm_Activated(object sender, EventArgs e)
        {
            InPieChart.Titles.Add("입고 수량 현황");
            OutPieChart.Titles.Add("제품별 판매 현황");
            UpdateData();
        }
    }
}
