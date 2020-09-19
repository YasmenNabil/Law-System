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
    public partial class LogIN : Form
    {
        public static string rname = "admin1";
        public static string ID = "123";
        public static bool n = false;
        Adminu ee = new Adminu(ID, rname,n);
            
        public LogIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==ee.Name&&textBox2.Text==ee.ID)
            {
                Admin ad=new Admin();
                ad.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR,User Name or Password Is Not Correct");
            }
        }

        private void LogIN_Load(object sender, EventArgs e)
        {
           
        }
    }
}
