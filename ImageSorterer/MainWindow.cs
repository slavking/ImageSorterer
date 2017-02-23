using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSorterer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> movingDict = new Dictionary<string, string>();

        private string[] files;
        private string[] subfolders;

        private string destination;

        private int n = 0;


        private void sourceBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = sourceFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                var sourceLoc = sourceFolder.SelectedPath;
                files = Directory.GetFiles(sourceFolder.SelectedPath);
                subfolders = Directory.GetDirectories(sourceFolder.SelectedPath);
                folderList.Items.AddRange(subfolders);
                pictureBox1.Load(files[n]);
            }
        }

        private void moveBTN_Click(object sender, EventArgs e)
        {
            if (folderList.SelectedIndex == -1)
            {
                MessageBox.Show("Select destination folder!");
                return;
            }
            var checkedMultiTasks = new List<string>();
            foreach (var item in folderList.CheckedItems)
            {
                destination = item.ToString() + "\\";
            }
            movingDict.Add(files[n], destination);
            n++;
            if (n < files.Length)
            {
                pictureBox1.Load(files[n]);
            }
            else
            {
                pictureBox1.Image = null;
                pictureBox1.Dispose();
                sortFiles();
            }

        }

        private void sortFiles()
        {
            foreach (KeyValuePair<string, string> kvp in movingDict)
            {
                var result = kvp.Key.Substring(kvp.Key.LastIndexOf(@"\") + 1);
                try
                {
                    string destinationTemp = Path.Combine(kvp.Value, result);
                    File.Move(kvp.Key, destinationTemp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void folderList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (folderList.CheckedItems.Count >= 1 && e.CurrentValue != CheckState.Checked)
            {
                e.NewValue = e.CurrentValue;
                MessageBox.Show("You can only check one item");
            }
        }

    }
}
