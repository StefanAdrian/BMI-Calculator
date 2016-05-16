using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_medii_programare_vizuala
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int weight;
            int height;
            double BMI;

            weight = Convert.ToInt32(textBoxWeight.Text.ToString());
            height = Convert.ToInt32(textBoxHeight.Text.ToString());
            BMI = ((double)weight / height / height) * 10000;
            labelResult.Text = BMI.ToString("n");

            textBoxWeight.Text = string.Empty;
            textBoxHeight.Text = string.Empty;
        }
    }
}
