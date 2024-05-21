using System;
using System.IO;
using System.Windows.Forms;

namespace V_EditorPro
{
    public partial class Form1 : Form
    {
        public Form1(string filePath = null)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                textBox1.Text = File.ReadAllText(filePath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(textBox1);
            searchForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                saveToolStripMenuItem.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                openToolStripMenuItem.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}