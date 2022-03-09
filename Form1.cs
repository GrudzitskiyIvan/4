using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        double x0, xk, dx, a, b;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox6.Text = "Работу выполнил ст. Звинаревский С. С.";
            
        }

        public double func(double x, double a, double b)
        {
            return a*Math.Pow(x,3)+Math.Pow(Math.Cos(Math.Pow(x,3)-b),2);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x0 = textBox1.Text == "" ? 0 : Convert.ToDouble(textBox1.Text.Replace('.', ','));
                xk = textBox2.Text == "" ? 0 : Convert.ToDouble(textBox2.Text.Replace('.', ','));
                dx = textBox3.Text == "" ? 0 : Convert.ToDouble(textBox3.Text.Replace('.', ','));
                a = textBox4.Text == "" ? 0 : Convert.ToDouble(textBox4.Text.Replace('.', ','));
                b = textBox5.Text == "" ? 0 : Convert.ToDouble(textBox5.Text.Replace('.', ','));
                if (dx == 0) throw new Exception("Шаг не может быть равен 0");
                textBox6.Text = "Работу выполнил ст. Звинаревский С. С.";
                if (x0 == xk)
                {
                    textBox6.Text += Environment.NewLine + "x=" + Convert.ToString(x0).Replace(',', '.') + ";\ty=" + Convert.ToString(func(x0, a, b)).Replace(',', '.');
                }
                else
                    if (x0 < xk)
                {
                    for (double x = x0; x <= xk; x += dx)
                    {
                        textBox6.Text += Environment.NewLine + "x=" + Convert.ToString(x).Replace(',', '.') + ";\ty=" + Convert.ToString(func(x, a, b)).Replace(',', '.');
                    }
                }
                else
                {
                    for (double x = x0; x >= xk; x += dx)
                    {
                        textBox6.Text += Environment.NewLine + "x=" + Convert.ToString(x).Replace(',','.') + ";\ty=" + Convert.ToString(func(x, a, b)).Replace(',', '.');
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
