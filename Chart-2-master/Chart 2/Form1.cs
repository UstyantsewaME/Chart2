using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Chart_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            double[] yValues = { Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text) };
            string[] xValues = { "Пятёрки", "Четвёрки", "Тройки", "Двойки" };
            chart1.Series[0].Points.DataBindXY(xValues, yValues);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            double[] yValues = { Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text) };
            string[] xValues = { "Пятёрки", "Четвёрки", "Тройки", "Двойки" };
            chart1.Series[0].Points.DataBindXY(xValues, yValues);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(textBox1.Text, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(textBox2.Text, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                textBox2.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(textBox3.Text, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                textBox3.Clear();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(textBox4.Text, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                textBox4.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
