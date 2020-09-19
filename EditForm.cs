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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < Law.Lawslist.Count; i++)
            {
                comboBox1.Items.Add(Law.Lawslist[i].ID);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Law d = new Law();
            d.Update(comboBox1.Text, richTextBox1.Text);
            MessageBox.Show("Updated");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Law_Form lawd = new Law_Form();
            lawd.Show();
        }
    }
}
