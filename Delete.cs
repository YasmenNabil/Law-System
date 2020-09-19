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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < Law.Lawslist.Count; i++)
            {
                comboBox1.Items.Add(Law.Lawslist[i].ID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Law l = new Law();
            l.DeleteLaw(comboBox1.Text);
            MessageBox.Show("Deleted");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
