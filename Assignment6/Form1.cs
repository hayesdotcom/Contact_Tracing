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

            A.WriteLine("HEALTH CONDITIONS:");

            if (checkBox1.CheckState == CheckState.Checked)
            {
                A.WriteLine(label12.Text + "- YES.");
            }
            if (checkBox2.CheckState == CheckState.Checked)
            {
                A.WriteLine(label12.Text + "- NO.");
            }
            if (checkBox3.CheckState == CheckState.Checked)
            {
                A.WriteLine(label13.Text + "- YES.");
            }
            if (checkBox4.CheckState == CheckState.Checked)
            {
                A.WriteLine(label13.Text + "- NO.");
            }
            if (checkBox6.CheckState == CheckState.Checked)
            {
                A.WriteLine(label14.Text + "- YES.");
            }
            if (checkBox5.CheckState == CheckState.Checked)
            {
                A.WriteLine(label14.Text + "- NO.");
            }
            if (checkBox8.CheckState == CheckState.Checked)
            {
                A.WriteLine(label15.Text + "- YES.");
            }
            if (checkBox7.CheckState == CheckState.Checked)
            {
                A.WriteLine(label15.Text + "- NO.");
            }

            A.Close();
            MessageBox.Show("Data was added succesfully!");

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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = String.Empty;
            comboBox2.Text = String.Empty;
            comboBox3.Text = String.Empty;
            comboBox4.Text = String.Empty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
