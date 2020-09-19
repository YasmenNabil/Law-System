using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace WindowsFormsApplication1
{
    public partial class Law_Form : Form
    {
        public Law_Form()
        {
            InitializeComponent();
        }

        private void addNewLawToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
             System.IO.StreamReader file = new System.IO.StreamReader("Law.txt");
            string[] columnnames = file.ReadLine().Split(',');
            DataTable dt = new DataTable();
            foreach (string c in columnnames)
            {

                dt.Columns.Add(c);
            }
            string newline;
            while ((newline = file.ReadLine()) != null)
            {
                string[] values = newline.Split(',');
                DataRow dr = dt.NewRow();
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[1] == comboBox1.SelectedItem.ToString())
                    {
                        dr[i] = values[i];
                    }
                   
                }
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;
            for (int i = 1; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "" && dataGridView1.Rows[i].Cells[1].Value.ToString() == "" && dataGridView1.Rows[i].Cells[2].Value.ToString() == "")
                {

                    dataGridView1.Rows.RemoveAt(i);
                    i--;
                }

            }

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Law_Form_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Rape"); ////
            comboBox1.Items.Add("Social Danger");////
            comboBox1.Items.Add("Bankruptcy"); ////
            comboBox1.Items.Add("Property");////
            comboBox1.Items.Add("General Provisions");////
            comboBox1.Items.Add("Criminal"); ////
            comboBox1.Items.Add("Forgery");//
            comboBox1.Items.Add("Theft"); //
            comboBox1.Items.Add("Bribery"); //
        }
    }
}
