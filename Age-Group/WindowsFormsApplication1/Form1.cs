using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int Age;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int BY = 0;
            try
            {
                BY = Convert.ToInt32(BirthYear.Text);
            }
            catch
            {
                MessageBox.Show("The Birth Year must be a Number!");
                return;
            }
            if (BY > DateTime.Now.Year)
            {
                MessageBox.Show("Wrong Birth Year! Try Again");
                return;
            }
            Age=DateTime.Now.Year-BY;
            label2.Text = "You Are "+Age+" Years OLD";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String AgeGroup;
            if (Age > 60) AgeGroup = "OLD";
            else if (Age > 45) AgeGroup = "Middle-Age";
            else if (Age > 19) AgeGroup = "Young";
            else if (Age > 12) AgeGroup = "Teenager";
            else if (Age >= 0) AgeGroup = "Child";
            else AgeGroup = "Not entered";
            label3.Text = "Your Age Group is: " + AgeGroup;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("This program shows your Age & Age Group, Would you like to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                Application.Exit();
        }
    }
}
