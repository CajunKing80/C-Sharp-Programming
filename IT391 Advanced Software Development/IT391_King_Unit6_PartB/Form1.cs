using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT391_King_Unit6_PartB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 15)

                if (textBox2.Text.Length < 15)

                    if (textBox3.Text != null)

                        if (textBox4.Text != null)

                            if (textBox5.Text.Length == 5)
                            {
                                string firstName = textBox1.Text;
                                string lastName = textBox2.Text;
                                string address = textBox4.Text;
                                long phoneNumber = long.Parse(textBox3.Text);
                                int zipCode = int.Parse(textBox5.Text);
                                MessageBox.Show("Submitted Succesfully");
                            }

                            else
                            {
                                MessageBox.Show("Input Validation Error");    
                            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
