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
    public partial class ADD_LAW : Form
    {
        public ADD_LAW()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Law l = new Law();
            l.AddLaw(textBox1.Text, comboBox1.Text, richTextBox1.Text);
            MessageBox.Show("Added");
        }

        private void ADD_LAW_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Law.Lawslist.Count; i++)
            {
                comboBox1.Items.Add(Law.Lawslist[i].lType);
            }
        }
    }
}
