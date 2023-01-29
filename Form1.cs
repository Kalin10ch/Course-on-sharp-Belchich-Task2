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

namespace PR4_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text = "-2,4";

            textBox2.Text = "1";

            textBox3.Text = "0,2";

            textBox4.Text = "2,5";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox7.Text += "Лаб.раб №4 Ст. гр. ПОКС-33";
            
            double x0 = Double.Parse(textBox1.Text);

            textBox7.Text += Environment.NewLine + "X0 = " + x0.ToString();

            double xK = Double.Parse(textBox2.Text);

            textBox7.Text += Environment.NewLine + "Xk = " + xK.ToString();

            double Dx = Double.Parse(textBox3.Text);

            textBox7.Text += Environment.NewLine + "DX = " + Dx.ToString();

            double B = Double.Parse(textBox4.Text);

            textBox7.Text += Environment.NewLine + "B = " + B.ToString();

            double y = 0;

            while (x0 < xK)

            {
                x0 += Dx;

                y= 9 * (x0 + 15 * Math.Sqrt(Math.Pow(x0, 3) + Math.Pow(B, 3)));
                
                textBox7.Text += Environment.NewLine + "X = " + x0.ToString() + " ;" + "Y = " + y.ToString() + " ;";

                x0 = Math.Round(x0,2);

            }
        }
    }
}
