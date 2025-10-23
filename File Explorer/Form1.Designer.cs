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
            this.trvTree = new System.Windows.Forms.TreeView();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.imgPastas = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // trvTree
            // 
            this.trvTree.BackColor = System.Drawing.Color.LightGray;
            this.trvTree.Location = new System.Drawing.Point(12, 12);
            this.trvTree.Name = "trvTree";
            this.trvTree.Size = new System.Drawing.Size(236, 478);
            this.trvTree.TabIndex = 0;
            // 
            // lvwFiles
            // 
            this.lvwFiles.BackColor = System.Drawing.Color.LightGray;
            this.lvwFiles.HideSelection = false;
            this.lvwFiles.Location = new System.Drawing.Point(254, 12);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(621, 478);
            this.lvwFiles.TabIndex = 1;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            // 
            // imgPastas
            // 
            this.imgPastas.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgPastas.ImageSize = new System.Drawing.Size(16, 16);
            this.imgPastas.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(887, 502);
            this.Controls.Add(this.lvwFiles);
            this.Controls.Add(this.trvTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "File Explorer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvTree;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.ImageList imgPastas;
    }
}

