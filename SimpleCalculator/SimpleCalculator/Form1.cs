using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "0";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = "0";
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "1";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = "1";
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "2";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = "2";
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "3";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = "3";
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "4";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = "4";
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "5";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = "5";
            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "6";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = "6";
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "7";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = "7";
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "8";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = "8";
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "9";
            }
            else if(answer.Text.Length == 1 && answer.Text[0] =='0')
            {
                answer.Text = "9";
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += ".";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = ".";
            }
        }

        private void Adder_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "+";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = "+";
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "-";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = "-";
            }
        }

        private void Divider_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "/";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = "/";
            }
        }

        private void Multiplier_Click(object sender, EventArgs e)
        {
            if (answer.Text != null)
            {
                answer.Text += "*";
            }
            else if (answer.Text.Length == 1 && answer.Text[0] == '0')
            {
                answer.Text = "*";
            }
        }

        private void AnsBtn_Click(object sender, EventArgs e)
        {
            int counter = 0;
            
            if(answer.Text[answer.Text.Length-1]=='+' || answer.Text[answer.Text.Length - 1] == '-' || answer.Text[answer.Text.Length - 1] == '*' || answer.Text[answer.Text.Length - 1] == '/'||answer.Text[answer.Text.Length - 1] == '.')
            {
                MessageBox.Show("ERROR!!!!!");
                answer.Text = "0";
            }
            if(answer.Text[0]=='*' || answer.Text[0] == '/'||answer.Text[0] == '.')
            {
                MessageBox.Show("ERROR!!!!!");
                answer.Text = "0";
            }
            for(int i =0;i<answer.Text.Length-1;i++)
            {
                if(!(answer.Text[i]>='0'&&answer.Text[i]<='9')&&!(answer.Text[i] == '+' || answer.Text[i] == '-' || answer.Text[i] == '*' || answer.Text[i] == '/' || answer.Text[i] == '.'))
                {
                    MessageBox.Show("ERROR!!!!!");
                    answer.Text = "0";
                }
                if((answer.Text[i] == '+' || answer.Text[i] == '-' || answer.Text[i] == '*' || answer.Text[i] == '/' || answer.Text[i] == '.')&&(answer.Text[i+1] == '+' || answer.Text[i+1] == '-' || answer.Text[i+1] == '*' || answer.Text[i+1] == '/' || answer.Text[i+1] == '.'))
                {
                    MessageBox.Show("ERROR!!!!!");
                    answer.Text = "0";
                }
            }

            for(int i =1;i<answer.Text.Length;i++)//started at 1 because if there was a minus or plus at the start will not count it as adder or minuser..
            {
                if(answer.Text[i]=='+'|| answer.Text[i]=='-'||answer.Text[i]=='*'||answer.Text[i]=='/')
                {
                    counter++;
                }
            }

            
            double[] numbers = new double[counter+1];
            string numberInText=null;
            int index = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                for (int i = index; i < answer.Text.Length; i++)
                {
                    if ((answer.Text[i] >= '0' && answer.Text[i] <= '9')||answer.Text[i]=='.')
                    {
                        numberInText += answer.Text.Substring(i, 1);
                    }
                    else
                    {
                        numbers[j] = double.Parse(numberInText);
                        numberInText = null;
                        index = i + 1;
                        break;
                    }
                }
            }
            numbers[numbers.Length-1] = double.Parse(numberInText);
            double sum = 0;
            counter = 0;
            for(int i =0;i<answer.Text.Length;i++)
            {
                if(answer.Text[i] == '+')
                {
                    if (counter == 0)
                    {
                        sum = numbers[counter] + numbers[counter + 1];
                        counter++;
                    }
                    else
                    {
                        sum += numbers[counter];
                        counter++;
                    }
                }
                else if(answer.Text[i] == '-')
                {
                    if (counter == 0)
                    {
                        sum = numbers[counter] - numbers[counter + 1];
                        counter++;
                    }
                    else
                    {
                        sum -= numbers[counter];
                        counter++;
                    }
                }
                else if(answer.Text[i] == '*')
                {
                    if (counter == 0)
                    {
                        sum = numbers[counter] * numbers[counter + 1];
                        counter++;
                    }
                    else
                    {
                        sum *= numbers[counter];
                        counter++;
                    }
                }
                else if(answer.Text[i] == '/')
                {
                    if (counter == 0)
                    {
                        sum = numbers[counter] / numbers[counter + 1];
                        counter++;
                    }
                    else
                    {
                        sum /= numbers[counter];
                        counter++;
                    }
                }
                
            }
            if (counter > 0)
            {
                answer.Text = sum.ToString();
            }
            else
            {
                answer.Text = null;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            string newAns = answer.Text.Substring(0, answer.Text.Length - 1);
            answer.Text = newAns;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            answer.Text = "0";
        }
    }
}
