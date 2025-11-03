using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace File_Explorer
{
    public partial class FormMain : Form
    {
        Stack<string> folderCol;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PopulateTreeView();
            folderCol = new Stack<string>();
            folderCol.Push(@"C:\");
        }

        private void PopulateTreeView()
        {
            trvTree.Nodes.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode disko = new TreeNode(drive.Name);
                disko.Tag = drive.Name;
                disko.ImageIndex = 1;
                disko.SelectedImageIndex = 1;
                DirectoryInfo diskInfo = new DirectoryInfo(drive.Name);
                foreach (var dir in diskInfo.GetDirectories())
                {
                    TreeNode directory = new TreeNode(dir.Name);
                    directory.Tag = dir.FullName;
                    directory.ImageIndex = 0;
                    directory.SelectedImageIndex = 0;
                    disko.Nodes.Add(directory);
                }
                foreach (var f in diskInfo.GetFiles())
                {
                    TreeNode file = new TreeNode(f.Name);
                    file.ImageIndex = 2;
                    file.SelectedImageIndex = 2;
                    disko.Nodes.Add(file);
                }
                trvTree.Nodes.Add(disko);
            }
        }

        private void PopulateListView(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                DirectoryInfo[] subDirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                lvwFiles.Items.Clear();
                foreach (var directory in subDirs)
                {
                    ListViewItem item = new ListViewItem(directory.Name);
                    item.ImageIndex = 0;
                    item.Tag = directory.FullName;
                    lvwFiles.Items.Add(item);
                }
                foreach (var file in files)
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.ImageIndex = 2;
                    item.Tag = file.FullName;
                    lvwFiles.Items.Add(item);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"Access denied to folder:\n{path}", "Access Denied");
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void trvTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Parent != null)
            {
                PopulateListView(e.Node.Tag.ToString());
            }
            folderCol.Push(e.Node.Tag.ToString());
            if (folderCol.Count > 1)
                btnBack.Enabled = true;
        }

        private void lvwFiles_DoubleClick(object sender, EventArgs e)
        {
            string path = lvwFiles.SelectedItems[0].Tag.ToString();
            if (lvwFiles.SelectedItems[0].ImageIndex == 0)
            {
                PopulateListView(path);
                folderCol.Push(path);
                if (folderCol.Count > 1)
                    btnBack.Enabled = true;
            }
            else
            {
                Process.Start(path);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            folderCol.Pop();
            string path = folderCol.Peek();
            PopulateListView(path);
            if (folderCol.Count == 1)
                btnBack.Enabled = false;

        }
    }
}
