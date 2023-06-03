using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_v1
{
    public partial class frmAddOrEditCustomer : Form
    {
        public frmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //pcCustomer.Image
                pcCustomer.ImageLocation = openFile.FileName;
            }
        }
    }
}
