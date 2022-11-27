using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string memoryText = "";
        
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach  (FontFamily font in FontFamily.Families)
            {
                cbFonts.Items.Add(font.Name);
            }
            for (int i = 8; i < 73; i++)
            {
                cbSize.Items.Add(i);
            }
            cbFonts.SelectedItem = "Times New Roman";
            cbSize.SelectedItem = 16;
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(cbFonts.Text, int.Parse(cbSize.Text),FontStyle.Regular);
        }
        private void cbSize_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(cbFonts.Text, int.Parse(cbSize.Text), FontStyle.Regular);
        }
        private void pasteClick(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
            richTextBox1.SelectedText = memoryText;
        }

        private void CopyClick(object sender, EventArgs e)
        {
            memoryText = richTextBox1.SelectedText;
        }

        private void cutClick(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void tsBold_Click(object sender, EventArgs e)
        {
            //rtbFont = FontStyle.Bold;
            //richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, rtbFont);
        }
        Font rtbFont = new Font(Form1.DefaultFont, FontStyle.Regular);
        private void tsItalic_Click(object sender, EventArgs e)
        {
            //rtbFont = FontStyle.Italic;
            //richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, rtbFont);
        }

        private void tsUnderline_Click(object sender, EventArgs e)
        {
            //rtbFont = FontStyle.Underline;
            //richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, rtbFont);
        }

        private void tsGrowFont_Click(object sender, EventArgs e)
        {
            cbSize.Text = (Convert.ToInt32(cbSize.Text) + 1).ToString();
        }
        private void tsShrinkFont_Click(object sender, EventArgs e)
        {
            if (cbSize.Text!="1")
            {
                cbSize.Text = (Convert.ToInt32(cbSize.Text) - 1).ToString();
            } 
            
        }
        

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)//change color
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;


            switch (btn.Text)
            {
                case "red":
                    richTextBox1.SelectionColor = Color.Red;
                    break;
                case "yellow":
                    richTextBox1.SelectionColor = Color.Yellow;
                    break;
                case "black":
                    richTextBox1.SelectionColor = Color.Black;
                    break;
                case "green":
                    richTextBox1.SelectionColor = Color.Green;
                    break;
                case "blue":
                    richTextBox1.SelectionColor = Color.Blue;
                    break;
                case "white":
                    richTextBox1.SelectionColor = Color.White;
                    break;
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)//highlight
        {
            ToolStripMenuItem btn =(ToolStripMenuItem) sender;
            switch (btn.Text)
            {
                case "red":
                    richTextBox1.SelectionBackColor = Color.Red;
                    break;
                case "yellow":
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    break;
                case "black":
                    richTextBox1.SelectionBackColor = Color.Black;
                    break;
                case "green":
                    richTextBox1.SelectionBackColor = Color.Green;
                    break;
                case "blue":
                    richTextBox1.SelectionBackColor = Color.Blue;
                    break;
                case "white":
                    richTextBox1.SelectionBackColor = Color.White;
                    break;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
    }
}
