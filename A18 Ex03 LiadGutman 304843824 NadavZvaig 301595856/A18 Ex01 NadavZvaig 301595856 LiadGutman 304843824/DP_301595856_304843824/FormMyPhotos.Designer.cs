namespace DP_301595856_304843824
{
    partial class FormMyPhotos
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
            this.buttonShowAlbums = new System.Windows.Forms.Button();
            this.buttonNextPhoto = new System.Windows.Forms.Button();
            this.pictureBoxAlbumPhotos = new System.Windows.Forms.PictureBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonNewestAlbumSort = new System.Windows.Forms.Button();
            this.buttonOldestAlbumSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumPhotos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowAlbums
            // 
            this.buttonShowAlbums.Location = new System.Drawing.Point(90, 319);
            this.buttonShowAlbums.Name = "buttonShowAlbums";
            this.buttonShowAlbums.Size = new System.Drawing.Size(223, 57);
            this.buttonShowAlbums.TabIndex = 0;
            this.buttonShowAlbums.Text = "Show Albums";
            this.buttonShowAlbums.UseVisualStyleBackColor = true;
            this.buttonShowAlbums.Click += new System.EventHandler(this.buttonShowAlbums_Click);
            // 
            // buttonNextPhoto
            // 
            this.buttonNextPhoto.Location = new System.Drawing.Point(629, 319);
            this.buttonNextPhoto.Name = "buttonNextPhoto";
            this.buttonNextPhoto.Size = new System.Drawing.Size(205, 57);
            this.buttonNextPhoto.TabIndex = 1;
            this.buttonNextPhoto.Text = "Next Photo";
            this.buttonNextPhoto.UseVisualStyleBackColor = true;
            this.buttonNextPhoto.Click += new System.EventHandler(this.buttonNextPhoto_Click);
            // 
            // pictureBoxAlbumPhotos
            // 
            this.pictureBoxAlbumPhotos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxAlbumPhotos.Location = new System.Drawing.Point(512, 29);
            this.pictureBoxAlbumPhotos.Name = "pictureBoxAlbumPhotos";
            this.pictureBoxAlbumPhotos.Size = new System.Drawing.Size(417, 284);
            this.pictureBoxAlbumPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumPhotos.TabIndex = 2;
            this.pictureBoxAlbumPhotos.TabStop = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 20;
            this.listBoxAlbums.Location = new System.Drawing.Point(90, 29);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(223, 284);
            this.listBoxAlbums.TabIndex = 3;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // buttonNewestAlbumSort
            // 
            this.buttonNewestAlbumSort.Location = new System.Drawing.Point(90, 382);
            this.buttonNewestAlbumSort.Name = "buttonNewestAlbumSort";
            this.buttonNewestAlbumSort.Size = new System.Drawing.Size(98, 60);
            this.buttonNewestAlbumSort.TabIndex = 4;
            this.buttonNewestAlbumSort.Text = "Newest Album Sort";
            this.buttonNewestAlbumSort.UseVisualStyleBackColor = true;
            this.buttonNewestAlbumSort.Click += new System.EventHandler(this.buttonNewestAlbumSort_Click);
            // 
            // buttonOldestAlbumSort
            // 
            this.buttonOldestAlbumSort.Location = new System.Drawing.Point(215, 382);
            this.buttonOldestAlbumSort.Name = "buttonOldestAlbumSort";
            this.buttonOldestAlbumSort.Size = new System.Drawing.Size(98, 60);
            this.buttonOldestAlbumSort.TabIndex = 5;
            this.buttonOldestAlbumSort.Text = "Oldest Album Sort";
            this.buttonOldestAlbumSort.UseVisualStyleBackColor = true;
            this.buttonOldestAlbumSort.Click += new System.EventHandler(this.buttonOldestAlbumSort_Click);
            // 
            // FormMyPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 479);
            this.Controls.Add(this.buttonOldestAlbumSort);
            this.Controls.Add(this.buttonNewestAlbumSort);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.pictureBoxAlbumPhotos);
            this.Controls.Add(this.buttonNextPhoto);
            this.Controls.Add(this.buttonShowAlbums);
            this.Name = "FormMyPhotos";
            this.Text = "FormMyPhotos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumPhotos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowAlbums;
        private System.Windows.Forms.Button buttonNextPhoto;
        private System.Windows.Forms.PictureBox pictureBoxAlbumPhotos;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonNewestAlbumSort;
        private System.Windows.Forms.Button buttonOldestAlbumSort;
    }
}