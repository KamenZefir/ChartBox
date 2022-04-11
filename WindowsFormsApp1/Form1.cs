using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Флажок " + checkBox1.Text + " теперь отмечен");
            }
            else
            {
                MessageBox.Show("Флажок " + checkBox1.Text + " теперь не отмечен");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                MessageBox.Show("Флажок " + checkBox2.Text + " теперь отмечен");
            }
            else
            {
                MessageBox.Show("Флажок " + checkBox2.Text + " теперь не отмечен");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double Xmin = Convert.ToDouble(textBox3.Text);
            double Xmax = Convert.ToDouble(textBox4.Text);
            double h = 0.1, y;
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;

            if (checkBox1.Checked == true)
            {
                this.chart1.Series[0].Points.Clear();
                for (double x = Xmin; x < Xmax; x += h)
                {
                    y = (Math.Sin(x1 * x + x2));
                    this.chart1.Series[0].Points.AddXY(x, y);
                }
            }
            else this.chart1.Series[0].Points.Clear();

            if (checkBox2.Checked == true)
            {
                this.chart1.Series[1].Points.Clear();
                for (double x = Xmin; x < Xmax; x += h)
                {
                    y = (Math.Cos(x1 * x + x2));
                    this.chart1.Series[1].Points.AddXY(x, y);
                }
            }
            else this.chart1.Series[1].Points.Clear();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
