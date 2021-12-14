using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Assignment6
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter A = new StreamWriter(Application.StartupPath + "\\form\\" + "Records.txt");

            A.WriteLine("DETAILS:");
              
            A.WriteLine(label2.Text + " " + textBox1.Text);
            A.WriteLine(label3.Text + " " + textBox2.Text);
            A.WriteLine(label4.Text + " " + comboBox1.Text);
            A.WriteLine(label5.Text + " " + textBox3.Text);
            A.WriteLine(label6.Text + " " + textBox4.Text);
            A.WriteLine(label7.Text + " " + comboBox2.Text + " " + comboBox3.Text + ", " + comboBox4.Text);
            A.WriteLine(label8.Text + " " + textBox5.Text);



            A.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
