using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] massiv = new int[10];
            Random random = new Random();
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = random.Next(-10, 10);
            }
            dataGridView1.DataSource = massiv.Select(x => new { Value = x }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int chislo = Convert.ToInt32(row.Cells["Value"].Value);
                if (chislo % 2 != 0 && chislo < 0)
                {
                    sum += chislo;

                }
            }

            textBox1.Text = Convert.ToString(sum);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                chart1.Series[0].Points.AddXY(0,
                    (int)Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value));
            }
        }
    }
}

