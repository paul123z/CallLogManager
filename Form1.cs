using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallLogManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // condition for writing minimum some input

                if (textBox1.Text.Length > 0)
                    textBox2.Focus();
            }
            else 
            {
                textBox1.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // condition for writing minimum some input

                if (textBox2.Text.Length > 0)
                    textBox3.Focus();
            }
            else
            {
                textBox2.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // condition for writing minimum some input

                if (textBox3.Text.Length > 0)
                    textBox4.Focus();
            }
            else
            {
                textBox3.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // condition for writing minimum some input

                if (textBox5.Text.Length > 0)
                    textBox6.Focus();
            }
            else
            {
                textBox5.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // condition for writing minimum some input

                if (textBox6.Text.Length > 0)
                    textBox7.Focus();
            }
            else
            {
                textBox6.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // condition for writing minimum some input

                if (comboBox1.SelectedIndex != -1) 
                {
                    dateTimePicker1.Focus();
                }
                    
            }
            else
            {
                comboBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Name Required");
            }

            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox3, "Mobile No. Required");
            }
            else
            {
                MessageBox.Show("Data Saved");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
