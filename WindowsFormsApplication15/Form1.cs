using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Logic.Interfaces;
using Logic;
using DataAccessLayer;

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {
        private ILogic _logic;

        public Form1()
        {
            InitializeComponent();
        }


        private void UpdateVideoGrid()
        {

        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSourceSelector selector = new DataSourceSelector();
            selector.ShowDialog();

            if (selector.IsTextDatabaseSelected)
            {
                _logic = new VideoManagement(new TextDatabase(selector.SelectedFilePath));
            }
            else
            {
                _logic = new VideoManagement(new MsDatabase(selector.MsDbConnectionString));

                dataGridView1.DataSource = _logic.Videos;
                PopulateListViewTreeView();
            }
        }

        private void PopulateListViewTreeView()
        {
            List<Category> myCategory = new List<Category>();
            treeView1.Nodes.Clear();

            foreach (var item in _logic.Categories)
            {
                TreeNode node = new TreeNode();
                node.Tag = item;
                node.Text = item.Name;
                treeView1.Nodes.Add(node);
            }

            treeView1.ExpandAll();
            treeView1.AllowDrop = true;
        }
    }
}


