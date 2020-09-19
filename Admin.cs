using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EditForm fo = new EditForm();
            fo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete dr = new Delete();
            dr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_LAW ad = new ADD_LAW();
            ad.Show();
        }
    }
}
