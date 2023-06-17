using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_uas
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        float iCelsius, iFarenheit, iKevin;
        char iOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 316;
            textBox1.Width = 266;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 610;
            textBox1.Width = 570;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 316;
            textBox1.Width = 266;
        }

        private void temperaturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1027;
            textBox1.Width = 570;
            textConvert.Focus();

            grupBox1.Visible = true;
            groupBox1.Visible = true;
            groupBox2.Visible = false;

            grupBox1.Location = new Point(610, 30);
            grupBox1.Width = 550;
            grupBox1.Height = 400;
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1027;
            textBox1.Width = 570;
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1027;
            textBox1.Width = 570;
            textMultiply.Focus();
            grupBox1.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = true;

            groupBox2.Location = new Point(610, 26);
            groupBox2.Width = 417;
            groupBox2.Height = 368;

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
                lblShowOp.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
                lblShowOp.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text .Length >0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aritmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            lblShowOp.Text = System.Convert.ToString(results) + "" + operation;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            switch(operation)
            {
                case "+":
                    textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                    break;
                    //28:21
                case "Mod":
                    textBox1.Text = (results % Double.Parse(textBox1.Text)).ToString();
                    break;
                    //28:21
                case "Exp":
                    double i = Double.Parse(textBox1.Text);
                    double q;
                    q = (results);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;

            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.14159265358997632";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + Double.Parse(textBox1.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);

        }

        private void button38_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + Double.Parse(textBox1.Text) + ")");
            sq = Math.Log10(sq);
            textBox1.Text = System.Convert.ToString(sq);

        }

        private void button36_Click(object sender, EventArgs e)
        {
            double sinh = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("sinh" + "(" + Double.Parse(textBox1.Text) + ")");
            sinh = Math.Log10(sinh);
            textBox1.Text = System.Convert.ToString(sinh);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("sin" + "(" + Double.Parse(textBox1.Text) + ")");
            sin = Math.Log10(sin);
            textBox1.Text = System.Convert.ToString(sin);

        }

        private void button32_Click(object sender, EventArgs e)
        {
            double cosh = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("cosh" + "(" + Double.Parse(textBox1.Text) + ")");
            cosh = Math.Log10(cosh);
            textBox1.Text = System.Convert.ToString(cosh);

        }

        private void button31_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("cos" + "(" + Double.Parse(textBox1.Text) + ")");
            cos = Math.Log10(cos);
            textBox1.Text = System.Convert.ToString(cos);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double tanh = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("tanh" + "(" + Double.Parse(textBox1.Text) + ")");
            tanh = Math.Log10(tanh);
            textBox1.Text = System.Convert.ToString(tanh);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("tan" + "(" + Double.Parse(textBox1.Text) + ")");
            tan = Math.Log10(tan);
            textBox1.Text = System.Convert.ToString(tan);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int a  = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 2);
 
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 16);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 8);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(1.0/ Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + Double.Parse(textBox1.Text) + ")");
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void rbFahKeCel_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void rbKevin_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void button43_Click(object sender, EventArgs e)
        {
            textConvert.Clear();
            lblConvert.Text = "";
            rbCekKeFah.Checked = false;
            rbFahKeCel.Checked = false;
            rbKevin.Checked = false; 
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textMultiply.Text);

            for(int i = 1; 1 < 13; i++)
            {
                listMultiply.Items.Add(i + " x" + a + " = " + a * i);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnresetMulti_Click(object sender, EventArgs e)
        {
            listMultiply.Items.Clear();
            textMultiply.Clear();
        }

        private void rbCekKeFah_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void button42_Click(object sender, EventArgs e)
        {
            switch(iOperation)
            {

                case 'C':
                    //Celsius ke Farenheit
                    iCelsius = float.Parse(textConvert.Text);
                    lblConvert.Text = ((((9 * iCelsius) / 5) + 32).ToString());
                    break;

                case 'F':
                    //Farenheit ke Celsius
                    iFarenheit = float.Parse(textConvert.Text);
                    lblConvert.Text = ((((iFarenheit - 32 ) * 5) / 9).ToString());
                    break;

                case 'K':
                    //Kevin
                    iKevin = float.Parse(textConvert.Text);
                    lblConvert.Text = (((((9 * iKevin) / 5) + 32) + 273.15).ToString());
                    break;
            }
        }
    }
    
}