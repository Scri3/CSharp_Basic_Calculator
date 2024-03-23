using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {

                if ((textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "x") || (textBox1.Text == "/") || (textBox1.Text == "%"))
                {
                    textBox1.Text = "0";
                }

                if (textBox1.Text == "0")
                {
                    textBox1.Text = "0" + "";
                }
                else
                {
                    textBox1.Text += "0";
                }

            }
            else
            {
                textBox1.Text = "";
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                if ((textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "x") || (textBox1.Text == "/") || (textBox1.Text == "%") || (textBox1.Text == "0"))
                {
                    textBox1.Text = "7";
                }
                else
                {
                    textBox1.Text += 7;
                }

            }
            else
            {
                textBox1.Text = "";
            }
        }


        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                if ((textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "x") || (textBox1.Text == "/") || (textBox1.Text == "%"))
                {
                    textBox1.Text = "0";
                }

                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "0" + "";
                }
                else
                {
                    textBox1.Text += "00";
                }

            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != "0") && (textBox1.Text != ""))
            {
                button17.Enabled = true;
            }
            else
            {
                button17.Enabled = false;
            }
        }

        private void onoroff_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled != false)
            {
                textBox1.Enabled = true;
            }
            else if (textBox1.Enabled == true)
            {
                textBox1.Enabled = false;
            }
        }
        private void calculator_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == false)
            {
                textBox1.Enabled = true;
                textBox1.Text = "0";
            }
            else if (textBox1.Enabled == true)
            {
                textBox1.Text = "";
                textBox1.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                if ((textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "x") || (textBox1.Text == "/") || (textBox1.Text == "%"))
                {
                    textBox1.Text = "0";
                }

                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "0" + "";
                }
                else
                {
                    textBox1.Text += "000";
                }

            }
            else
            {
                textBox1.Text = "";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                if ((textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "x") || (textBox1.Text == "/") || (textBox1.Text == "%") || ((textBox1.Text == "0")))
                {
                    textBox1.Text = "1";
                }

                else
                {
                    textBox1.Text += 1;
                }
            }
            else
            {
                textBox1.Text = "";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                if ((textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "x") || (textBox1.Text == "/") || (textBox1.Text == "%") || (textBox1.Text == "0"))
                {
                    textBox1.Text = "2";
                }

                else
                {
                    textBox1.Text += 2;
                }
            }
            else
            {
                textBox1.Text = "";
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                if ((textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "x") || (textBox1.Text == "/") || (textBox1.Text == "%") || (textBox1.Text == "0"))
                {
                    textBox1.Text = "3";
                }

                else
                {
                    textBox1.Text += 3;
                }
            }
            else
            {
                textBox1.Text = "";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                if ((textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "x") || (textBox1.Text == "/") || (textBox1.Text == "%") || (textBox1.Text == "0"))
                {
                    textBox1.Text = "4";
                }

                else
                {
                    textBox1.Text += 4;
                }

            }
            else
            {
                textBox1.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                if ((textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "x") || (textBox1.Text == "/") || (textBox1.Text == "%") || (textBox1.Text == "0"))
                {
                    textBox1.Text = "5";
                }

                else
                {
                    textBox1.Text += 5;
                }

            }
            else
            {
                textBox1.Text = "";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                if ((textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "x") || (textBox1.Text == "/") || (textBox1.Text == "%") || (textBox1.Text == "0"))
                {
                    textBox1.Text = "6";
                }

                else
                {
                    textBox1.Text += 6;
                }

            }
            else
            {
                textBox1.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                if ((textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "x") || (textBox1.Text == "/") || (textBox1.Text == "%") || (textBox1.Text == "0"))
                {
                    textBox1.Text = "8";
                }

                else
                {
                    textBox1.Text += 8;
                }

            }
            else
            {
                textBox1.Text = "";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                if ((textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "x") || (textBox1.Text == "/") || (textBox1.Text == "%") || (textBox1.Text == "0"))
                {
                    textBox1.Text = "9";
                }
                else
                {
                    textBox1.Text += 9;
                }

            }
            else
            {
                textBox1.Text = "";
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                if ((textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "x") || (textBox1.Text == "/") || (textBox1.Text == "%") || ((textBox1.Text == "")))
                {
                    textBox1.Text = "0.";
                }

                //if (textBox1.Text == "")
                //{
                //    textBox1.Text = "0.";
                //}
                else
                {
                    textBox1.Text += ".";
                }
            }
            else
            {
                textBox1.Text = "";
            }

        }

        int indicator;
        string T1, T2;
        double result;
        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled==true)
            {
                indicator = 1;

                T1 = textBox1.Text;
                textBox1.Text = "+";

            }
            else
            {
                textBox1.Text = "";

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                indicator = 2;

                T1 = textBox1.Text;
                textBox1.Text = "-";

            }
            else
            {
                textBox1.Text = "";

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                indicator = 3;

                T1 = textBox1.Text;
                textBox1.Text = "x";
            }
            else
            {
                textBox1.Text = "";

            }


        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                indicator = 4;

                T1 = textBox1.Text;
                textBox1.Text = "/";
            }
            else
            {
                textBox1.Text = "";

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                indicator = 5;

                T1 = textBox1.Text;
                textBox1.Text = "%";
            }
            else
            {
                textBox1.Text = "";

            }


        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled==false)
            {
                DialogResult dr;
               dr= MessageBox.Show("Please Turn on the Calculator!","Calculator is Off!!!",MessageBoxButtons.OK);
            }
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            Button bt=(Button)sender;
            bt.ForeColor = Color.Red;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.ForeColor = Color.White;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                T2 = textBox1.Text;

                switch (indicator)
                {
                    case 1:
                        result = Convert.ToDouble(T1) + Convert.ToDouble(T2);
                        break;
                    case 2:
                        result = Convert.ToDouble(T1) - Convert.ToDouble(T2);
                        break;
                    case 3:
                        result = Convert.ToDouble(T1) * Convert.ToDouble(T2);
                        break;
                    case 4:
                        result = Convert.ToDouble(T1) / Convert.ToDouble(T2);
                        break;
                    case 5:
                        result = Convert.ToDouble(T1) % Convert.ToDouble(T2);
                        break;
                }

                //if (indicator == 1)
                //{
                //    result = Convert.ToDouble(T1) + Convert.ToDouble(T2);
                //}
                //if (indicator == 2)
                //{
                //    result = Convert.ToDouble(T1) - Convert.ToDouble(T2);
                //}
                //if (indicator == 3)
                //{
                //    result = Convert.ToDouble(T1) * Convert.ToDouble(T2);
                //}
                //if (indicator == 4)
                //{
                //    result = Convert.ToDouble(T1) / Convert.ToDouble(T2);
                //}
                //if (indicator == 5)
                //{
                //    result = Convert.ToDouble(T1) % Convert.ToDouble(T2);
                //}

                textBox1.Text = "= " + result.ToString();
            }
            else
            {
                textBox1.Text = "";

            }

        }
    }
}
