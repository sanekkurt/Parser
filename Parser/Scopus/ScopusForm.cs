
using Parser.Scopus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parser.Save;

namespace Parser.Scopus
{
    public partial class ScopusForm : Form
    {

        ParserWorker<List<string>> parser;
        List<string> data = new List<string>();

        public ScopusForm()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            label3.Visible = false;
            pictureBox1.Enabled = false;
            label3.Enabled = false;

            parser = new ParserWorker<List<string>>(new ScopusParser());

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, List<string> arg2)
        {
            for (int i = 0; i < arg2.Count; i++)
                data.Add(arg2[i]);
        }


        private void Parser_OnCompleted(object obj)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\ScopusList.doc";
  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files(*.doc)|*.doc|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                path = saveFileDialog1.FileName;

            label3.Text = "Сохранение...";
            var save = new SaveBibTeX();
            save.InBibTeX(data, path);
            /*var save = new SaveDocument();
            /*передаем инфу
            save.InDoc(data, path);
            pictureBox1.Enabled = false;
            label3.Enabled = false;
            pictureBox1.Visible = false;
            label3.Visible = false;
            MessageBox.Show("Сохранено");
            this.Close();*/

        }

        private void search_orcid_Click(object sender, EventArgs e)
        {
            search_orcid.Enabled = false;
            pictureBox1.Enabled = true;
            label3.Enabled = true;
            pictureBox1.Visible = true;
            label3.Visible = true;
            parser.Settings = new ScopusSettings(orcid_box.Text);
            parser.Start();
        }

        private void ButtonAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }

        private void ScopusForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void orcid_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
