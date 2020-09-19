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
    public partial class Court : Form
    {
        Courts c = new Courts();
        public Court()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Name" }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Address" }, 1, 0);
           
            for (int i = 0; i < Courts.Courtslist.Count; i++)
            {
                if (Courts.Courtslist[i].City == comboBox1.SelectedItem.ToString())
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1; // size of rows
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    // Data , colomn index, row index
                    tableLayoutPanel1.Controls.Add(new Label() { Text = Courts.Courtslist[i].Name }, 0, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = Courts.Courtslist[i].Address}, 1, tableLayoutPanel1.RowCount - 1);
                }
            }
        }

        private void Court_Load(object sender, EventArgs e)
        {
            for(int i = 0;i<Courts.Courtslist.Count;i++)
            {
               
              comboBox1.Items.Add(Courts.Courtslist[i].City);
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
