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
    public partial class Reserve : Form
    {
        public Reserve()
        {
            InitializeComponent();
        }

        private void Reserve_Load(object sender, EventArgs e)
        {

            Type.Items.Add("Rape"); ////
            Type.Items.Add("Social Danger");////
            Type.Items.Add("Bankruptcy"); ////
            Type.Items.Add("Property");////
            Type.Items.Add("General Provisions");////
            Type.Items.Add("Criminal"); ////
            Type.Items.Add("Forgery");//
            Type.Items.Add("Theft"); //
            Type.Items.Add("Bribery"); //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            
            for(int i=0;i<Lawyer.Lawyerslist.Count;i++)
            {
                if (Type.SelectedItem.ToString() == Lawyer.Lawyerslist[i].Type)
                {
                    comboBox2.Items.Add(Lawyer.Lawyerslist[i].Name);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 11 && textBox2.Text != null && textBox3.Text != null && richTextBox1.Text != null)
            {
                MessageBox.Show("Reserved Successfully,Lawyer Will Call You Soon To Set Time For Meeting");
                Adminu.saveReservations(textBox3.Text, textBox1.Text, textBox2.Text, comboBox2.Text, richTextBox1.Text);

            }
            else
            {
                MessageBox.Show("You need To Fill All This Data");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
