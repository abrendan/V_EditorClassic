using System;
using System.Windows.Forms;

namespace V_EditorPro
{
    public partial class SearchForm : Form
    {
        private TextBox mainTextBox;

        public SearchForm(TextBox textBox)
        {
            InitializeComponent();
            this.mainTextBox = textBox;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            int index = mainTextBox.Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);
            if (index >= 0)
            {
                mainTextBox.Focus();
                mainTextBox.Select(index, searchText.Length);
            }
            else
            {
                MessageBox.Show("Text not found!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}