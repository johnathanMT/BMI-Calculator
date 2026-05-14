using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void lblBMIResult_Click(object sender, EventArgs e)
        {
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            
            if (!double.TryParse(textBox1.Text, out double weight) || !double.TryParse(textBox2.Text, out double height))
            {
                MessageBox.Show("Please enter valid numeric values for weight and height.");
                return;
            }

            double bmi = 0;

            if (rbImperial.Checked)
            {
                bmi = 703 * (weight / (height * height));
            }
            else if (rbMetric.Checked)
            {
                bmi = weight / (height * height);
            }
            else
            {
                MessageBox.Show("Please select a measurement type.");
                return;
            }

            string status = "";

            if (bmi < 18.5)
            {
                status = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                status = "Healthy Weight";
            }
            else if (bmi >= 25.0 && bmi <= 29.9)
            {
                status = "Overweight";
            }
            else if (bmi >= 30.0 && bmi <= 39.9)
            {
                status = "Obesity";
            }
            else
            {
                status = "Severe obesity";
            }

            lblBMIResult.Text = $"Your BMI = {bmi:0.0} \nStatus = {status}";
        }

        private void btnConvert_Click_1(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double weight) || !double.TryParse(textBox2.Text, out double height))
            {
                MessageBox.Show("Please enter valid numeric values for weight and height.");
                return;
            }

            double bmi = 0;

            if (rbImperial.Checked)
            {
                bmi = 703 * (weight / (height * height));
            }
            else if (rbMetric.Checked)
            {
                bmi = weight / (height * height);
            }
            else
            {
                MessageBox.Show("Please select a measurement type.");
                return;
            }

            string status = "";

            if (bmi < 18.5)
            {
                status = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                status = "Healthy Weight";
            }
            else if (bmi >= 25.0 && bmi <= 29.9)
            {
                status = "Overweight";
            }
            else if (bmi >= 30.0 && bmi <= 39.9)
            {
                status = "Obesity";
            }
            else
            {
                status = "Severe obesity";
            }

            lblBMIResult.Text = $"Your BMI = {bmi:0.0} \nStatus = {status}";
        }
    }
}
