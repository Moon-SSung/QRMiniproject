using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string mode = "";
        string query = "SERVER=192.168.0.164; DATABASE=mydb; UID=root; PASSWORD=1234;";
        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();

        }

        private void Initialize()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "SERVER=192.168.0.164; DATABASE=mydb; UID=root; PASSWORD=1234;";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            string Query = "SELECT * FROM tblBook2";
            cmd.CommandText = Query;

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblBook2");

            DataGrid.DataSource = ds;
            DataGrid.DataMember = "tblBook2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            mode = "INSERT";
            AddProcess();
            Initialize();
        }

        private void AddProcess()
        {
            if (string.IsNullOrEmpty(mode))
            {
                MessageBox.Show(this, "데이터를 입력하고 추가하세요", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (MySqlConnection connection = new MySqlConnection(query))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                string query = "";

                if (mode == "UPDATE")
                {
                    query = "UPDATE tblBook2 " +
                               "   SET name = @name " +
                               " , Publisher = @Publisher "+
                               " , Page = @Page " +
                               "   WHERE ISBN = @ISBN;   ";
                   

                }
                else if (mode == "INSERT")
                {
                    query = "  INSERT INTO tblBook2 VALUES (@ISBN, @name, @Publisher, @Page) ";
                    
                }
                cmd.CommandText = query;

                MySqlParameter sqlParmISBN = new MySqlParameter("@ISBN",MySqlDbType.VarChar,20);
                sqlParmISBN.Value = ISBNtxt.Text;
                cmd.Parameters.Add(sqlParmISBN);
                MySqlParameter sqlParmname = new MySqlParameter("@name", MySqlDbType.VarChar,40);
                sqlParmname.Value = BookNametxt.Text;
                cmd.Parameters.Add(sqlParmname);
                MySqlParameter sqlParmPublisher = new MySqlParameter("@Publisher", MySqlDbType.VarChar,20);
                sqlParmPublisher.Value = Publishertxt.Text;
                cmd.Parameters.Add(sqlParmPublisher);
                MySqlParameter sqlParmPage = new MySqlParameter("@Page", MySqlDbType.VarChar,20);
                sqlParmPage.Value = PageTxt.Text;
                cmd.Parameters.Add(sqlParmPage);

                cmd.ExecuteNonQuery();

            }
            
        }

        private void ChangeBT_Click(object sender, EventArgs e)
        {
            mode = "UPDATE";
            AddProcess();
            Initialize();
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >-1)
            {
                DataGridViewRow data = DataGrid.Rows[e.RowIndex];
                ISBNtxt.Text = data.Cells[0].Value.ToString();
                BookNametxt.Text = data.Cells[1].Value.ToString();
                Publishertxt.Text = data.Cells[2].Value.ToString();
                PageTxt.Text = data.Cells[3].Value.ToString();
                ISBNtxt.ReadOnly = false;
                ISBNtxt.BackColor = Color.Beige;

              
            }
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            DeletProcess();
            Initialize();
        }

        private void DeletProcess()
        {
            using (MySqlConnection connection = new MySqlConnection(query))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM tblBook2 " +
                                 " WHERE ISBN = @ISBN" +
                                 " AND name = @name " +
                                 " AND Publisher = @Publisher " +
                                 " AND Page = @Page  ";
                //Delete  -> WHERE AND AND AND AND AND로 추가 하면 된다.
                
                MySqlParameter sqlParmISBN = new MySqlParameter("@ISBN", MySqlDbType.VarChar, 20);
                sqlParmISBN.Value = ISBNtxt.Text;
                cmd.Parameters.Add(sqlParmISBN);
                MySqlParameter sqlParmname = new MySqlParameter("@name", MySqlDbType.VarChar, 40);
                sqlParmname.Value = BookNametxt.Text;
                cmd.Parameters.Add(sqlParmname);
                MySqlParameter sqlParmPublisher = new MySqlParameter("@Publisher", MySqlDbType.VarChar, 20);
                sqlParmPublisher.Value = Publishertxt.Text;
                cmd.Parameters.Add(sqlParmPublisher);
                MySqlParameter sqlParmPage = new MySqlParameter("@Page", MySqlDbType.VarChar, 20);
                sqlParmPage.Value = PageTxt.Text;
                cmd.Parameters.Add(sqlParmPage);

                cmd.ExecuteNonQuery();


            }
        }
    }
}
