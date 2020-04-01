using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

        }

        private void userInputTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal userInput;
                userInput = decimal.Parse(userInputTextBox.Text);
                decimal seconds_to_minutes;
                decimal seconds_to_hours;
                decimal seconds_to_days;
                {
                    //minutes
                    if (userInput >= 60)
                    {
                        seconds_to_minutes = userInput / 60;
                        userOutputLabel.Text = seconds_to_minutes.ToString("") + " " + "minute(s)";
                    }
                    //hours
                    if (userInput >= 3600)
                    {
                        seconds_to_hours = userInput / 3600;
                        userOutputLabel.Text = seconds_to_hours.ToString("") + " " + "hour(s)";
                    }
                    //days
                    if (userInput >= 86400)
                    {
                        seconds_to_days = userInput / 86400;
                        userOutputLabel.Text = seconds_to_days.ToString("") + " " + "day(s)";
                    }
                    if (userInput < 60)
                    {
                        userOutputLabel.Text = userInput.ToString() + " " + "second(s)";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
        }



        private void userOutputLabel_Click(object sender, EventArgs e)
        {
            userOutputLabel.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
