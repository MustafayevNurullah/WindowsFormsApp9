using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Size.Items.Add(8);
            Size.Items.Add(9);
            Size.Items.Add(10);
            Size.Items.Add(11);
            Size.Items.Add(12);
            Size.Items.Add(14);
            Size.Items.Add(16);
            Size.Items.Add(18);
            Size.Items.Add(20);
            Size.Items.Add(22);
            Size.Items.Add(24);
            Size.Items.Add(26);
            Size.Items.Add(28);
            Size.Items.Add(36);
            Size.Items.Add(48);
            Size.Items.Add(72);

        

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                Font.Items.Add(font.Name);
            }

            Size.Text = "11";
            Font.Text = "Calibri";
            richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text));

        }

        private void NewMethod(int i)
        {
            Size.Items.Add(i);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog.Color;
            }

        }

        private void L_CheckedChanged(object sender, EventArgs e)
        {
            


                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            
        }

        private void C_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void R_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text));

            //if(Size.SelectedIndex<5)
            //{
            //    richTextBox1.Font = new Font(Font.SelectedIndex + 1.ToString(), Size.SelectedIndex+8);
            //}
            //if ( Size.SelectedIndex < 13 & Size.SelectedIndex >4)
            //{
            //    richTextBox1.Font = new Font(Font.SelectedIndex + 1.ToString(), Size.SelectedIndex + 9);
            //}
            //if(Size.SelectedIndex==13)
            //{
            //    richTextBox1.Font = new Font(Font.SelectedIndex + 1.ToString(), 36);
            //}
            //if(Size.SelectedIndex==14)
            //{
            //    richTextBox1.Font = new Font(Font.SelectedIndex + 1.ToString(), 48);
            //}
            //if (Size.SelectedIndex == 15)
            //{
            //    richTextBox1.Font = new Font(Font.SelectedIndex + 1.ToString(), 72);
            //}

        }

        private void Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text));

            //foreach (FontFamily font in System.Drawing.FontFamily.Families)
            //{

            //if(font.Name==Font.Text)
            //    {
            //        richTextBox1.Font = new Font(font.Name, Convert.ToInt32(Size.Text));
            //    }
            //}


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {


            if(checkBox3.Checked)
            {
                if (U.Checked & checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                }
                if (!U.Checked & B.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Bold | FontStyle.Italic);

                }
                if (U.Checked & !B.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Italic | FontStyle.Underline);

                }
                if (!U.Checked & !B.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Italic);

                }


            }
            else
            {
                if (U.Checked & B.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Regular | FontStyle.Underline | FontStyle.Bold);
                }
                if (!U.Checked & B.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Regular | FontStyle.Bold);

                }
                if (U.Checked & !B.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Regular | FontStyle.Underline);

                }
                if (!U.Checked & !B.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Regular);

                }


            }
        }


        private void B_CheckedChanged(object sender, EventArgs e)
        {
            if (B.Checked)
            {
                if (U.Checked & checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Bold | FontStyle.Underline | FontStyle.Italic );
                }
                if(!U.Checked & checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Bold | FontStyle.Italic);

                }
                if (U.Checked & !checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Bold | FontStyle.Underline);

                }
                if (!U.Checked & !checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Bold );

                }


            }
            else
            {
                if (U.Checked & checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Regular | FontStyle.Underline | FontStyle.Italic);
                }
                if (!U.Checked & checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Regular | FontStyle.Italic);

                }
                if (U.Checked & !checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Regular | FontStyle.Underline);

                }
                if (!U.Checked & !B.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Regular);

                }


            }

        }

        private void U_CheckedChanged(object sender, EventArgs e)
        {
            if (U.Checked)
            {
                if (B.Checked & checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                }
                if (!B.Checked & checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Underline | FontStyle.Italic);

                }
                if (B.Checked & !checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Underline | FontStyle.Bold);

                }
                if (!B.Checked & !B.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Underline);

                }


            }
            else
            {
                if (B.Checked & checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Regular | FontStyle.Bold | FontStyle.Italic);
                }
                if (!B.Checked & checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Regular | FontStyle.Italic);

                }
                if (B.Checked & !checkBox3.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Regular | FontStyle.Bold);

                }
                if (!U.Checked & !B.Checked)
                {
                    richTextBox1.Font = new Font(Font.Text, Convert.ToInt32(Size.Text), FontStyle.Regular);

                }


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
