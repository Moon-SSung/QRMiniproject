using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace QRMiniproject
{
    public partial class InOutPutVisualForm : MetroForm
    {
        
        public InOutPutVisualForm()
        {
            InitializeComponent();
        }

        private void InOutPutVisual_Load(object sender, EventArgs e)
        {
           
            InputChart.Legends[0].Docking = Docking.Bottom;
            InputChart.DataManipulator.Sort(PointSortOrder.Descending,InputChart.Series[0]);
            InputChart.Legends[0].Alignment = StringAlignment.Center;
            InputChart.Series[0]["PieLabelStyle"] = "OutSide";
            InputChart.Series[0].BorderWidth = 1;
            InputChart.Series[0].BorderColor = Color.Black;
            InputChart.Series[0].LegendText = "#VALX (#PERCENT{P1})";
            InputChart.Series[0].Label = "#VALY ";
            InputChart.Text = "입고수량";

            OutChart.Legends[0].Docking = Docking.Bottom;
            OutChart.DataManipulator.Sort(PointSortOrder.Descending, InputChart.Series[0]);
            OutChart.Legends[0].Alignment = StringAlignment.Center;
            OutChart.Series[0]["PieLabelStyle"] = "OutSide";
            OutChart.Series[0].BorderWidth = 1;
            OutChart.Series[0].BorderColor = Color.Black;
            OutChart.Series[0].LegendText = "#VALX (#PERCENT{P1})";
            OutChart.Series[0].Label = "#VALY ";
            OutChart.Text = "판매 총액";

        }
        private void UpdateData()
        {
            // 탭을 눌렸을 때 현황을 차트에 뿌림
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT sum(count) AS '수량', ID FROM InputTbl" +
                                  " GROUP BY ID "+
                                  " ORDER BY '수량' ";
                SqlDataReader reader = cmd.ExecuteReader();
                InputChart.Series["Series1"].Points.Clear();
                int i = 0;
                while (reader.Read())
                {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(reader[1] + " " + reader[0] + "개", reader[0]);
                    point.ToolTip = string.Format("{0}, {1}개", reader[1], reader[0]);
                    InputChart.Series["Series1"].Points.Add(point);
                    InputChart.Series["Series1"].Points[i++].LegendText = reader[1].ToString();
                }
                InputChart.Series["Series1"].IsValueShownAsLabel = true;

                reader.Close();
                cmd.CommandText = @"select p.Name, o.count * p.price as '판매총액'
                                        from OutputTbl as o
                                        INNER JOIN ProductTbl
as p
                                        on o.productIdx = p.p_idx
                                      ORDER BY '판매총액' ";
                reader = cmd.ExecuteReader();
                OutChart.Series["Series1"].Points.Clear();
                i = 0;
                while (reader.Read())
                {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(reader[0] + " " + reader[1] + "원", reader[1]);
                    point.ToolTip = string.Format("{0}, {1}원", reader[0], reader[1]);
                    OutChart.Series["Series1"].Points.Add(point);
                    OutChart.Series["Series1"].Points[i++].LegendText = reader[0].ToString();

                }
                OutChart.Series["Series1"].IsValueShownAsLabel = true;

            }
        }


        private void BtnInput_Click(object sender, EventArgs e)
        {
       
            List<int> amount = new List<int>();
            List<string> products = new List<string>();
       
            InputChart.Series[0].Points.Clear();
            InputChart.Series[0].Points.DataBindXY(products, amount);
            InputChart.Series[0].IsValueShownAsLabel = true;

          
       

         
        }

        private void BtnOutput_Click(object sender, EventArgs e)
        {
            List<int> amount = new List<int>();
            List<string> products = new List<string>();
         

            InputChart.Series[0].Points.Clear();
            InputChart.Series[0].Points.DataBindXY(products, amount);
            InputChart.Series[0].IsValueShownAsLabel = true;

       

        }

        private void InOutPutVisualForm_Activated(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
