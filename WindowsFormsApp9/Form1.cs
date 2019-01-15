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
            for (int i = 8; i < 75; i+=5)
                NewMethod(i);
            // Font.Items.AddRange(FontFamily.Families);
            List<string> fonts = new List<string>();

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                Font.Items.Add(font.Name);
            }

            richTextBox1.Font = new Font("Calibri", 11);
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
            switch (Size.SelectedIndex)
            {
                case 0:
                    richTextBox1.Font = new Font(Font.SelectedIndex + 1.ToString(), 8);

                    break;
                case 1:
                    richTextBox1.Font = new Font(Font.SelectedIndex + 1.ToString(), 13);

                    break;
                case 2:
                    richTextBox1.Font = new Font(Font.SelectedIndex + 1.ToString(), 18);

                    break;
                case 3:
                    richTextBox1.Font = new Font(Font.SelectedIndex + 1.ToString(), 23);

                    break;


            }


            richTextBox1.Font = new Font(Font.SelectedIndex+1.ToString(), Size.SelectedIndex+1);
           
        }

        private void Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = Font.SelectedIndex;
      
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                if(a==Font.SelectedIndex+1)
                {
                   
            richTextBox1.Font = new Font(font.Name, Size.SelectedIndex+1);
                }
            }

        }
    }
}
