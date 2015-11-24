using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class DataSourceSelector : Form
    {
        public DataSourceSelector()
        {
            InitializeComponent();
        }

        public string SelectedFilePath = "";
        public bool IsTextDatabaseSelected = false;
        public string MsDbConnectionString = "";

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.txt|Text Datenbank";
            ofd.ShowDialog();
            textBox1.Text = ofd.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsTextDatabaseSelected = false;
            MsDbConnectionString = string.Format("Data Source={0};" + "Initial Catalog={1};" + "Integrated Security=True;" + "Connect Timeout=30;" + "Encrypt=False;" + "TrustServerCertificate=False;", textBox2.Text, textBox5.Text);
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IsTextDatabaseSelected = true;
            SelectedFilePath = textBox1.Text;
            Close();
        }



    }
}
