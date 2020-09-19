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
    public partial class LawyerForm : Form
    {
        public LawyerForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void LawyerForm_Load(object sender, EventArgs e)
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Controls.Add(new Label() { Text = "ID" }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Lawyer Name" },  1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Lawyer Phone" }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Lawyer Email" }, 3, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Lawyer Type " }, 4, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Rate " }, 5, 0);


            for (int i = 0; i < Lawyer.Lawyerslist.Count ; i++)
            {
               if (Lawyer.Lawyerslist[i].Type == comboBox1.SelectedItem.ToString())
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1; // size of rows
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    // Data , colomn index, row index
                    tableLayoutPanel1.Controls.Add(new Label() { Text = Lawyer.Lawyerslist[i].ID }, 0, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = Lawyer.Lawyerslist[i].Name }, 1, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = Lawyer.Lawyerslist[i].phoneNumber }, 2, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = Lawyer.Lawyerslist[i].Email }, 3, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = Lawyer.Lawyerslist[i].Type }, 4, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = Lawyer.Lawyerslist[i].rate.ToString() }, 5, tableLayoutPanel1.RowCount - 1);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reserve r = new Reserve();
            r.Show();
        }
    }
}
