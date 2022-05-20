using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForWindowsForm
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = (int)numericUpDown1.Value;
            int with = (int)numericUpDown2.Value;
            bool checkSigns = checkBox1.Checked;
            bool checkCopy = checkBox2.Checked;

            Random r = new Random();
            Random Type = new Random();
            
            for(int j = 0; j < with; j++)
            {
                for (int i = 0; i < length; i++)
                {
                    if (checkSigns == true)
                    {
                        char value = (char)r.Next(33, 126);
                        if (value == '\\' || value == '/')
                        {
                            value = (char)r.Next(48, 57);
                            richTextBox1.Text += value.ToString();
                        }
                        else
                        {
                            richTextBox1.Text += value.ToString();
                        }

                        if (checkCopy == true)
                        {
                            Clipboard.SetText(richTextBox1.Text);
                        }

                        continue;
                    }


                    int value1 = r.Next(0, 9);
                    richTextBox1.Text += value1.ToString();
                    

                    if (checkCopy == true)
                    {
                        Clipboard.SetText(richTextBox1.Text);
                    }
                   
                    
                }
                richTextBox1.Text += "\n";
            }
        }
    }
}
