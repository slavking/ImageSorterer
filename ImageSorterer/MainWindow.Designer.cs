namespace ImageSorterer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceBtn = new System.Windows.Forms.Button();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sourceFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.folderList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.moveBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceBtn
            // 
            this.sourceBtn.Location = new System.Drawing.Point(13, 13);
            this.sourceBtn.Name = "sourceBtn";
            this.sourceBtn.Size = new System.Drawing.Size(125, 23);
            this.sourceBtn.TabIndex = 0;
            this.sourceBtn.Text = "Source Folder";
            this.sourceBtn.UseVisualStyleBackColor = true;
            this.sourceBtn.Click += new System.EventHandler(this.sourceBtn_Click);
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(13, 43);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(104, 13);
            this.sourceLabel.TabIndex = 1;
            this.sourceLabel.Text = "Select source folder.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(144, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // folderList
            // 
            this.folderList.FormattingEnabled = true;
            this.folderList.Location = new System.Drawing.Point(664, 13);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(286, 289);
            this.folderList.TabIndex = 3;
            this.folderList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.folderList_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a subfolder to move the image to";
            // 
            // moveBTN
            // 
            this.moveBTN.Location = new System.Drawing.Point(664, 322);
            this.moveBTN.Name = "moveBTN";
            this.moveBTN.Size = new System.Drawing.Size(286, 125);
            this.moveBTN.TabIndex = 5;
            this.moveBTN.Text = "NEXT";
            this.moveBTN.UseVisualStyleBackColor = true;
            this.moveBTN.Click += new System.EventHandler(this.moveBTN_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 459);
            this.Controls.Add(this.moveBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.sourceBtn);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sourceBtn;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog sourceFolder;
        private System.Windows.Forms.CheckedListBox folderList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button moveBTN;
    }
}

