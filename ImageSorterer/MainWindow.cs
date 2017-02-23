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


/* 
maded by cnsr on request of some german bernd
doesn't even steal your data
trust me
(also doesn't really work)
t. ukrainian bernd aka cnsr
*/

namespace ImageSorterer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Info.Text = ("Made by cnsr for KC.\nSomewhat works, maybe doesn't.\nI am not sure.\nVersion: " + version);
            infoBox.Text = ("1. Select source folder. It must contain destination subfolders." + Environment.NewLine + "2. Select destination folder, click \"NEXT\" button." + Environment.NewLine + "3. That's all.");
        }

        private Dictionary<string, string> movingDict = new Dictionary<string, string>();

        private string[] files;
        private string[] subfolders;

        private string destination;

        private int n = 0;

        private string version = "1.0.0";
        
        private void sourceBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = sourceFolder.ShowDialog();
            bool isEmpty = !Directory.EnumerateFiles(sourceFolder.SelectedPath).Any();
            if (result == DialogResult.OK & !isEmpty)
            {
                var sourceLoc = sourceFolder.SelectedPath;
                files = Directory.GetFiles(sourceFolder.SelectedPath);
                subfolders = Directory.GetDirectories(sourceFolder.SelectedPath);
                folderList.Items.AddRange(subfolders);
                pictureBox1.Load(files[n]);
                PicResize();
            }
            else
            {
                MessageBox.Show("Folder does not contain any files.");
            }
        }

        private void PicResize()
        {
            if (pictureBox1.Width < pictureBox1.Image.Width && pictureBox1.Height < pictureBox1.Image.Height)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
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
            PicResize();
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
