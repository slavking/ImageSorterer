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

        //private string sourceFile;
        private string destination;

        private int n = 0;

        protected int pCurrentImage = -1;


        private void sourceBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = sourceFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                var sourceLoc = sourceFolder.SelectedPath;
                //
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                //
                files = Directory.GetFiles(sourceFolder.SelectedPath);
                subfolders = Directory.GetDirectories(sourceFolder.SelectedPath);
                folderList.Items.AddRange(subfolders);
                pictureBox1.Load(files[n]);
            }
        }

        private void moveBTN_Click(object sender, EventArgs e)
        {
            foreach (object item in folderList.Items)
            {
                var ch= folderList.CheckedItems.Contains(item);
                if (ch)
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Select destination folder!");
                    return;
                }
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
                //pictureBox1.Image = Image.FromFile(files[n]);
                pictureBox1.Load(files[n]);
                //pictureBox1.Image = files[n].Clone() as Bitmap;
            }
            else
            {
                //pictureBox1.Invalidate();
                pictureBox1.Image = null;
                pictureBox1.Dispose();
                sortFiles();
            }

        }

        private void sortFiles()
        {
            //pictureBox1.Dispose();
            //pictureBox1.Invalidate();
            //pictureBox1.Update();
            foreach (KeyValuePair<string, string> kvp in movingDict)
            {
                var result = kvp.Key.Substring(kvp.Key.LastIndexOf(@"\") + 1);
                MessageBox.Show(kvp.Key + " - " + kvp.Value + result);
                try
                {
                    string destinationTemp = Path.Combine(kvp.Value, result);
                    MessageBox.Show(destinationTemp);
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
