using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn=openFileDialog1.FileName;
                MessageBox.Show(fn);
                if (fn.EndsWith("rtf"))
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Can not open File ");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = saveFileDialog1.FileName;
                MessageBox.Show(fn);
                if (fn.EndsWith("rtf"))
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    MessageBox.Show("file saved successfully");
                }
                else
                {
                    MessageBox.Show("weare changing formate of file into rtf please note it down...");
                    richTextBox1.SaveFile(saveFileDialog1.FileName+".rtf");
                    MessageBox.Show("Saved Successfully");
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Width = hScrollBar1.Value;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Height = vScrollBar1.Value;
        }
    }
}
