using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRMiniproject
{
    public partial class ClientForm : MetroForm
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            UpdateData();  
        }

        private void UpdateData()
        {
            throw new NotImplementedException();
        }

        

       
    }
}
