using System.Text.RegularExpressions;

namespace Assignment1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (input1.Text != string.Empty && input2.Text != string.Empty && Regex.IsMatch(input1.Text, @"^[+-]?\d*[.]?\d*$") && Regex.IsMatch(input2.Text, @"^[+-]?\d*[.]?\d*$"))
            {
                double num1 = double.Parse(input1.Text);
                double num2 = double.Parse(input2.Text);
                double result = num1 - num2;
                output.Text = Convert.ToString(result);
            }
            else
            {
                if (input1.Text == string.Empty || !Regex.IsMatch(input1.Text, @"^[+-]?\d*[.]?\d*$"))
                {
                    input1.Text = "Please input a number!"; output.Text = "";
                }
                if (input2.Text == string.Empty || !Regex.IsMatch(input2.Text, @"^[+-]?\d*[.]?\d*$"))
                {
                    input2.Text = "Please input a number!"; output.Text = "";
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (input1.Text != string.Empty && input2.Text != string.Empty && Regex.IsMatch(input1.Text, @"^[+-]?\d*[.]?\d*$") && Regex.IsMatch(input2.Text, @"^[+-]?\d*[.]?\d*$"))
            {
                double num1 = double.Parse(input1.Text);
                double num2 = double.Parse(input2.Text);
                double result = num1 + num2;
                output.Text = Convert.ToString(result);
            }
            else
            {
                if (input1.Text == string.Empty || !Regex.IsMatch(input1.Text, @"^[+-]?\d*[.]?\d*$"))
                {
                    input1.Text = "Please input a number!"; output.Text = "";
                }
                if (input2.Text == string.Empty || !Regex.IsMatch(input2.Text, @"^[+-]?\d*[.]?\d*$"))
                {
                    input2.Text = "Please input a number!"; output.Text = "";
                }
            }
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            if (input1.Text != string.Empty && input2.Text != string.Empty && Regex.IsMatch(input1.Text, @"^[+-]?\d*[.]?\d*$") && Regex.IsMatch(input2.Text, @"^[+-]?\d*[.]?\d*$"))
            {
                double num1 = double.Parse(input1.Text);
                double num2 = double.Parse(input2.Text);
                double result = num1 * num2;
                output.Text = Convert.ToString(result);
            }
            else
            {
                if (input1.Text == string.Empty || !Regex.IsMatch(input1.Text, @"^[+-]?\d*[.]?\d*$"))
                {
                    input1.Text = "Please input a number!"; output.Text = "";
                }
                if (input2.Text == string.Empty || !Regex.IsMatch(input2.Text, @"^[+-]?\d*[.]?\d*$"))
                {
                    input2.Text = "Please input a number!"; output.Text = "";
                }
            }
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            if (input1.Text != string.Empty && input2.Text != string.Empty && Regex.IsMatch(input1.Text, @"^[+-]?\d*[.]?\d*$") && Regex.IsMatch(input2.Text, @"^[+-]?\d*[.]?\d*$"))
            {
                double num1 = double.Parse(input1.Text);
                double num2 = double.Parse(input2.Text);
                if (num2 != 0)
                {
                    double result = num1 / num2;
                    output.Text = Convert.ToString(result);
                }
                else
                {
                    input2.Text = "You know zero can't be divisor,right?"; output.Text = "";
                }

            }
            else
            {
                if (input1.Text == string.Empty || !Regex.IsMatch(input1.Text, @"^[+-]?\d*[.]?\d*$"))
                {
                    input1.Text = "Please input a number!"; output.Text = "";
                }
                if (input2.Text == string.Empty || !Regex.IsMatch(input2.Text, @"^[+-]?\d*[.]?\d*$"))
                {
                    input2.Text = "Please input a number!"; output.Text = "";
                }
            }
        }

        private void remButton_Click(object sender, EventArgs e)
        {
            if (input1.Text != string.Empty && input2.Text != string.Empty && Regex.IsMatch(input1.Text, @"^[+-]?\d*$") && Regex.IsMatch(input2.Text, @"^[+-]?\d*$"))
            {
                int num1 = int.Parse(input1.Text);
                int num2 = int.Parse(input2.Text);
                if(num2 != 0)
                {
                    int result = num1 % num2;
                    output.Text = Convert.ToString(result);
                }
                else
                {
                    input2.Text = "You know zero can't be divisor,right?"; output.Text = "";
                }

            }
            else
            {
                if (input1.Text == string.Empty || !Regex.IsMatch(input1.Text, @"^[+-]?\d*$"))
                {
                    input1.Text = "Please input a integer!";
                    output.Text = "";
                }
                if (input2.Text == string.Empty || !Regex.IsMatch(input2.Text, @"^[+-]?\d*$"))
                {
                    input2.Text = "Please input a integer!";
                    output.Text = "";
                }
            }
        }
    }
}
