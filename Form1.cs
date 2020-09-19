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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Law_Form f = new Law_Form();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LawyerForm l = new LawyerForm();
            l.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data a = new Data();
            a.read_Lawyer();
            a.read_Law();
            a.read_users();
            a.read_Courts();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reserve r = new Reserve();
            r.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Court c=new Court();
            c.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            LogIN log = new LogIN();
            log.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Rate r = new Rate();
            r.Show();
        }
    }
}
