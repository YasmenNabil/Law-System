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
    public partial class Rate : Form
    {
        int rate;
        public Rate()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rate_Load(object sender, EventArgs e)
        {
            for(int i = 0;i<Lawyer.Lawyerslist.Count;i++)
            {
               
              comboBox1.Items.Add(Lawyer.Lawyerslist[i].Name);
            }
            List<object> list = new List<object>();
            foreach (object o in comboBox1.Items)
            {
                if (!list.Contains(o))
                {
                    list.Add(o);
                }
            }
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list.ToArray());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                rate = 1;
            }
            else if (radioButton2.Checked == true)
            {
                rate = 2;
            }
            else if (radioButton3.Checked == true)
            {
                rate = 3;
            }
            else if (radioButton4.Checked == true)
            {
                rate = 4;
            }
            else if (radioButton5.Checked == true)
            {
                rate = 5;
            }
            Lawyer.addrate(comboBox1.SelectedItem.ToString(), rate);
            Data.writeFilelawyer();
        }

        }
    }
