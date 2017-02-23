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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.sourceBtn = new System.Windows.Forms.Button();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sourceFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.folderList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.moveBTN = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceBtn
            // 
            this.sourceBtn.Location = new System.Drawing.Point(13, 13);
            this.sourceBtn.Name = "sourceBtn";
            this.sourceBtn.Size = new System.Drawing.Size(165, 23);
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
            this.pictureBox1.Location = new System.Drawing.Point(184, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 434);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // folderList
            // 
            this.folderList.FormattingEnabled = true;
            this.folderList.Location = new System.Drawing.Point(704, 13);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(286, 289);
            this.folderList.TabIndex = 3;
            this.folderList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.folderList_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a subfolder to move the image to";
            // 
            // moveBTN
            // 
            this.moveBTN.Location = new System.Drawing.Point(704, 322);
            this.moveBTN.Name = "moveBTN";
            this.moveBTN.Size = new System.Drawing.Size(286, 125);
            this.moveBTN.TabIndex = 5;
            this.moveBTN.Text = "NEXT";
            this.moveBTN.UseVisualStyleBackColor = true;
            this.moveBTN.Click += new System.EventHandler(this.moveBTN_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(10, 378);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(35, 13);
            this.Info.TabIndex = 6;
            this.Info.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "How to use:";
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(13, 115);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(165, 260);
            this.infoBox.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 449);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.moveBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.sourceBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Image Sorterer";
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
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox infoBox;
    }
}

