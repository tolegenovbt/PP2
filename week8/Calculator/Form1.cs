using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    enum Operation
    {
        Add, Subtract, Multiply, Divide
    }

    public partial class Form1 : Form
    {

        private Operation operation, repeat;
        private bool isOperationRunning;
        private double result;
        private int lcm, x, y;

        public Form1()
        {
            InitializeComponent();
            isOperationRunning = false;
            result = 0.0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            // type casting
            Button button = (Button)sender;

            if (isOperationRunning)
            {
                textBoxResult.Text = button.Text;
                isOperationRunning = false;
                return;
            }

            if (textBoxResult.Text == "0")
            {
                if (button.Text != "0")
                {
                    textBoxResult.Text = button.Text;
                }
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + button.Text;
            }
        }

        private void operation_Click(object sender, EventArgs e)
        {
            repeat = operation;
            Button button = sender as Button;

            textBoxLabel.Text = textBoxResult.Text + " " + button.Text;

            switch (button.Text)
            {
                case "+":
                    operation = Operation.Add;
                    break;
                case "-":
                    operation = Operation.Subtract;
                    break;
                case "x":
                    operation = Operation.Multiply;
                    break;
                case "/":
                    operation = Operation.Divide;
                    break;
                default:
                    break;
            }

            if (textBoxLabel.Text != "")
            {
                switch (repeat)
                {
                    case Operation.Add:
                        result = result + double.Parse(textBoxResult.Text);
                        break;
                    case Operation.Subtract:
                        if (result == 0)
                            result = double.Parse(textBoxResult.Text);
                        else
                            result = result - double.Parse(textBoxResult.Text);
                        break;
                    case Operation.Multiply:
                        if (result == 0)
                            result = 1;
                        result = result * double.Parse(textBoxResult.Text);
                        break;
                    case Operation.Divide:
                        if (result == 0)
                            result = double.Parse(textBoxResult.Text);
                        else
                            result = result / double.Parse(textBoxResult.Text);
                        break;
                    default:
                        break;
                }
                textBoxLabel.Text = result.ToString();
                //textBoxResult.Text = string.Empty;
            }
            isOperationRunning = true;
            //result = double.Parse(textBoxResult.Text);
        }

        private void equals_Click(object sender, EventArgs e)
        {
            //switch (operation)
            //{
            //    case Operation.Add:
            //        result = result + double.Parse(textBoxResult.Text);
            //        break;
            //    case Operation.Subtract:
            //        result = result - double.Parse(textBoxResult.Text);
            //        break;
            //    case Operation.Multiply:
            //        result = result * double.Parse(textBoxResult.Text);
            //        break;
            //    case Operation.Divide:
            //        result = result / double.Parse(textBoxResult.Text);
            //        break;
            //    default:
            //        break;
            //}
            //textBoxResult.Text = result.ToString();
            //textBoxLabel.Text = string.Empty;
            //result = 0.0;
            y = int.Parse(textBoxResult.Text);
            textBoxResult.Text = (Lcm(Max(x, y), Min(x,y))).ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            Console.WriteLine("Clear");
            result = 0.0;
            isOperationRunning = false;
            textBoxLabel.Text = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBoxResult.Text);
            textBoxResult.Text = string.Empty;
        }
        private int Max(int n1, int n2)
        {
            if (n1 > n2)
                return n1;
            else
                return n2;
        }
        private int Min(int n1, int n2)
        {
            if (n1 > n2)
                return n2;
            else
                return n1;
        }
        private int Lcm(int x, int y)
        {
            if (x % y == 0)
                return x;
            else
                return Lcm(x+x, y);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxResult.Text), cnt = 0 ;
            for(int i=1;i<=n;i++)
            {
                if (n % i == 0)
                    cnt++;
            }
            textBoxResult.Text = cnt.ToString();

        }
    }
}