namespace File_Explorer
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.trvTree = new System.Windows.Forms.TreeView();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.imgImagens = new System.Windows.Forms.ImageList(this.components);
            this.imgListView = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trvTree
            // 
            this.trvTree.BackColor = System.Drawing.Color.LightGray;
            this.trvTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvTree.ImageIndex = 2;
            this.trvTree.ImageList = this.imgImagens;
            this.trvTree.Location = new System.Drawing.Point(12, 49);
            this.trvTree.Name = "trvTree";
            this.trvTree.SelectedImageIndex = 0;
            this.trvTree.Size = new System.Drawing.Size(236, 555);
            this.trvTree.TabIndex = 0;
            this.trvTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvTree_NodeMouseDoubleClick);
            // 
            // lvwFiles
            // 
            this.lvwFiles.BackColor = System.Drawing.Color.LightGray;
            this.lvwFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFiles.HideSelection = false;
            this.lvwFiles.LargeImageList = this.imgListView;
            this.lvwFiles.Location = new System.Drawing.Point(254, 49);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(991, 555);
            this.lvwFiles.TabIndex = 1;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.DoubleClick += new System.EventHandler(this.lvwFiles_DoubleClick);
            // 
            // imgImagens
            // 
            this.imgImagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgImagens.ImageStream")));
            this.imgImagens.TransparentColor = System.Drawing.Color.Transparent;
            this.imgImagens.Images.SetKeyName(0, "folder.png");
            this.imgImagens.Images.SetKeyName(1, "hard-drive.png");
            this.imgImagens.Images.SetKeyName(2, "blank-page.png");
            // 
            // imgListView
            // 
            this.imgListView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListView.ImageStream")));
            this.imgListView.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListView.Images.SetKeyName(0, "folder.png");
            this.imgListView.Images.SetKeyName(1, "hard-drive.png");
            this.imgListView.Images.SetKeyName(2, "blank-page.png");
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 31);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1257, 616);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lvwFiles);
            this.Controls.Add(this.trvTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvTree;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.ImageList imgImagens;
        private System.Windows.Forms.ImageList imgListView;
        private System.Windows.Forms.Button btnBack;
    }
}

