using Parser.Scopus;
using Parser.Elibrary;
using System;
using System.Windows.Forms;

namespace Parser
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonScopus_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Hide();
            ScopusForm newForm = new ScopusForm();
            newForm.ShowDialog();
            this.Close();
        }

        private void ButtonElibrary_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Hide();
            ElibraryForm newForm = new ElibraryForm();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
