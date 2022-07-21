using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textHeight.Text = "";
            textWeight.Text = "";
            textResult.Text = "";

            radioKg.Checked = false;
            radioLb.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(textWeight.Text);
            double height = Convert.ToDouble(textHeight.Text);
            double result = 0.0;
            string result2 = "";

            if (radioKg.Checked) 
            { 
                result = weight / (height * height);
            }
            else
            if (radioLb.Checked)
            {
                weight = weight / 2.205;
                result = weight / (height * height);
            }

            if (result < 18.5)
            {
                result2 = "You are underweight";
            }
            else
            if (result < 25)
            {
                result2 = "You have normal weight";
            }
            else
            if (result < 30)
            {
                result2 = "You are overweight";
            }
            else
            if (result > 30)
                result2 = "You are obese";

            textResult.Text = "Your BMI is: " + result.ToString("#.#") + "\r\n" + result2;

            /*
             * Underweight = <18.5
                Normal weight = 18.5-24.9
                Overweight = 25-29.9
                Obesity = BMI of 30 or greater
             * 
             */
        }
    }
}
