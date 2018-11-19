namespace DP_301595856_304843824
{
    public partial class FormMain
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label descriptionLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.TextProfile = new System.Windows.Forms.TextBox();
            this.listBoxAboutMe = new System.Windows.Forms.ListBox();
            this.buttonShowFriends = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxLikePages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonShowEvents = new System.Windows.Forms.Button();
            this.buttonLikePages = new System.Windows.Forms.Button();
            this.buttonHoroscopeFeature = new System.Windows.Forms.Button();
            this.buttonCommonPhotosFeature = new System.Windows.Forms.Button();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.pictureBoxCommonPhoto = new System.Windows.Forms.PictureBox();
            this.listBoxCommonPhoto = new System.Windows.Forms.ListBox();
            this.comboBoxAppId = new System.Windows.Forms.ComboBox();
            this.DownloadSelectedPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppId = new System.Windows.Forms.Label();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.panelEventDetails = new System.Windows.Forms.Panel();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.panelPageDetails = new System.Windows.Forms.Panel();
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox1 = new System.Windows.Forms.PictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelFriendPicBackGround = new System.Windows.Forms.Panel();
            this.buttonMyAlbums = new System.Windows.Forms.Button();
            this.buttonUpSort = new System.Windows.Forms.Button();
            this.buttonDownSort = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.panelEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.panelPageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panelFriendPicBackGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(5, 96);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Location = new System.Drawing.Point(3, 104);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(93, 20);
            descriptionLabel1.TabIndex = 0;
            descriptionLabel1.Text = "Description:";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(173, 219);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(165, 43);
            this.ButtonLogin.TabIndex = 2;
            this.ButtonLogin.Text = "Facebook Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Crimson;
            this.buttonLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(1166, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(106, 59);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Facebook Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // PictureBoxProfile
            // 
            this.PictureBoxProfile.BackColor = System.Drawing.SystemColors.Highlight;
            this.PictureBoxProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxProfile.BackgroundImage")));
            this.PictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxProfile.Location = new System.Drawing.Point(12, 86);
            this.PictureBoxProfile.Name = "PictureBoxProfile";
            this.PictureBoxProfile.Size = new System.Drawing.Size(149, 144);
            this.PictureBoxProfile.TabIndex = 5;
            this.PictureBoxProfile.TabStop = false;
            // 
            // TextProfile
            // 
            this.TextProfile.BackColor = System.Drawing.Color.White;
            this.TextProfile.Enabled = false;
            this.TextProfile.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextProfile.Location = new System.Drawing.Point(12, 236);
            this.TextProfile.Name = "TextProfile";
            this.TextProfile.Size = new System.Drawing.Size(149, 26);
            this.TextProfile.TabIndex = 6;
            // 
            // listBoxAboutMe
            // 
            this.listBoxAboutMe.FormattingEnabled = true;
            this.listBoxAboutMe.ItemHeight = 20;
            this.listBoxAboutMe.Location = new System.Drawing.Point(12, 268);
            this.listBoxAboutMe.Name = "listBoxAboutMe";
            this.listBoxAboutMe.Size = new System.Drawing.Size(326, 144);
            this.listBoxAboutMe.TabIndex = 7;
            // 
            // buttonShowFriends
            // 
            this.buttonShowFriends.Location = new System.Drawing.Point(517, 804);
            this.buttonShowFriends.Name = "buttonShowFriends";
            this.buttonShowFriends.Size = new System.Drawing.Size(119, 39);
            this.buttonShowFriends.TabIndex = 8;
            this.buttonShowFriends.Text = "Show Friends";
            this.buttonShowFriends.UseVisualStyleBackColor = true;
            this.buttonShowFriends.Click += new System.EventHandler(this.buttonShowFriends_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(517, 614);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(220, 184);
            this.listBoxFriends.TabIndex = 9;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(767, 614);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(220, 184);
            this.listBoxEvents.TabIndex = 10;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // listBoxLikePages
            // 
            this.listBoxLikePages.DataSource = this.pageBindingSource;
            this.listBoxLikePages.DisplayMember = "Name";
            this.listBoxLikePages.FormattingEnabled = true;
            this.listBoxLikePages.ItemHeight = 20;
            this.listBoxLikePages.Location = new System.Drawing.Point(1017, 611);
            this.listBoxLikePages.Name = "listBoxLikePages";
            this.listBoxLikePages.Size = new System.Drawing.Size(220, 184);
            this.listBoxLikePages.TabIndex = 11;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // buttonShowEvents
            // 
            this.buttonShowEvents.Location = new System.Drawing.Point(767, 804);
            this.buttonShowEvents.Name = "buttonShowEvents";
            this.buttonShowEvents.Size = new System.Drawing.Size(123, 36);
            this.buttonShowEvents.TabIndex = 12;
            this.buttonShowEvents.Text = "Show Events";
            this.buttonShowEvents.UseVisualStyleBackColor = true;
            this.buttonShowEvents.Click += new System.EventHandler(this.buttonShowEvents_Click);
            // 
            // buttonLikePages
            // 
            this.buttonLikePages.Location = new System.Drawing.Point(1017, 801);
            this.buttonLikePages.Name = "buttonLikePages";
            this.buttonLikePages.Size = new System.Drawing.Size(115, 39);
            this.buttonLikePages.TabIndex = 13;
            this.buttonLikePages.Text = "Show Pages";
            this.buttonLikePages.UseVisualStyleBackColor = true;
            this.buttonLikePages.Click += new System.EventHandler(this.buttonLikePages_Click);
            // 
            // buttonHoroscopeFeature
            // 
            this.buttonHoroscopeFeature.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHoroscopeFeature.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHoroscopeFeature.BackgroundImage")));
            this.buttonHoroscopeFeature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHoroscopeFeature.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHoroscopeFeature.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonHoroscopeFeature.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHoroscopeFeature.Location = new System.Drawing.Point(342, 269);
            this.buttonHoroscopeFeature.Name = "buttonHoroscopeFeature";
            this.buttonHoroscopeFeature.Size = new System.Drawing.Size(149, 144);
            this.buttonHoroscopeFeature.TabIndex = 14;
            this.buttonHoroscopeFeature.Text = "Horoscope";
            this.buttonHoroscopeFeature.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHoroscopeFeature.UseVisualStyleBackColor = false;
            this.buttonHoroscopeFeature.Click += new System.EventHandler(this.buttonHoroscopeFeature_Click);
            // 
            // buttonCommonPhotosFeature
            // 
            this.buttonCommonPhotosFeature.Location = new System.Drawing.Point(12, 565);
            this.buttonCommonPhotosFeature.Name = "buttonCommonPhotosFeature";
            this.buttonCommonPhotosFeature.Size = new System.Drawing.Size(449, 43);
            this.buttonCommonPhotosFeature.TabIndex = 15;
            this.buttonCommonPhotosFeature.Text = "Common Photo with:";
            this.buttonCommonPhotosFeature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCommonPhotosFeature.UseVisualStyleBackColor = true;
            this.buttonCommonPhotosFeature.Click += new System.EventHandler(this.buttonCommonPhotosFeature_Click);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(387, 442);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(104, 32);
            this.buttonPostStatus.TabIndex = 16;
            this.buttonPostStatus.Text = "Post Status";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(214, 189);
            this.pictureBoxFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriends.TabIndex = 17;
            this.pictureBoxFriends.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(12, 445);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(326, 92);
            this.textBoxStatus.TabIndex = 20;
            // 
            // pictureBoxCommonPhoto
            // 
            this.pictureBoxCommonPhoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxCommonPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCommonPhoto.Location = new System.Drawing.Point(12, 614);
            this.pictureBoxCommonPhoto.Name = "pictureBoxCommonPhoto";
            this.pictureBoxCommonPhoto.Size = new System.Drawing.Size(228, 184);
            this.pictureBoxCommonPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommonPhoto.TabIndex = 21;
            this.pictureBoxCommonPhoto.TabStop = false;
            // 
            // listBoxCommonPhoto
            // 
            this.listBoxCommonPhoto.FormattingEnabled = true;
            this.listBoxCommonPhoto.ItemHeight = 20;
            this.listBoxCommonPhoto.Location = new System.Drawing.Point(246, 614);
            this.listBoxCommonPhoto.Name = "listBoxCommonPhoto";
            this.listBoxCommonPhoto.Size = new System.Drawing.Size(215, 184);
            this.listBoxCommonPhoto.TabIndex = 22;
            this.listBoxCommonPhoto.SelectedIndexChanged += new System.EventHandler(this.listBoxCommonPhoto_SelectedIndexChanged);
            // 
            // comboBoxAppId
            // 
            this.comboBoxAppId.FormattingEnabled = true;
            this.comboBoxAppId.Items.AddRange(new object[] {
            "1450160541956417  ",
            "140687806576513"});
            this.comboBoxAppId.Location = new System.Drawing.Point(342, 236);
            this.comboBoxAppId.Name = "comboBoxAppId";
            this.comboBoxAppId.Size = new System.Drawing.Size(149, 28);
            this.comboBoxAppId.TabIndex = 23;
            this.comboBoxAppId.SelectedIndexChanged += new System.EventHandler(this.comboBoxAppId_SelectedIndexChanged);
            // 
            // DownloadSelectedPicture
            // 
            this.DownloadSelectedPicture.Enabled = false;
            this.DownloadSelectedPicture.Location = new System.Drawing.Point(13, 804);
            this.DownloadSelectedPicture.Name = "DownloadSelectedPicture";
            this.DownloadSelectedPicture.Size = new System.Drawing.Size(148, 46);
            this.DownloadSelectedPicture.TabIndex = 25;
            this.DownloadSelectedPicture.Text = "Download Picture";
            this.DownloadSelectedPicture.UseVisualStyleBackColor = true;
            this.DownloadSelectedPicture.Click += new System.EventHandler(this.DownloadSelectedPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 45);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // AppId
            // 
            this.AppId.Location = new System.Drawing.Point(344, 216);
            this.AppId.Name = "AppId";
            this.AppId.Size = new System.Drawing.Size(140, 28);
            this.AppId.TabIndex = 24;
            this.AppId.Text = "AppId Combo Box";
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Location = new System.Drawing.Point(50, -1);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(952, 211);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 27;
            this.coverPictureBox.TabStop = false;
            // 
            // panelEventDetails
            // 
            this.panelEventDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelEventDetails.Controls.Add(this.imageNormalPictureBox);
            this.panelEventDetails.Controls.Add(descriptionLabel);
            this.panelEventDetails.Controls.Add(this.descriptionTextBox);
            this.panelEventDetails.Location = new System.Drawing.Point(767, 373);
            this.panelEventDetails.Name = "panelEventDetails";
            this.panelEventDetails.Size = new System.Drawing.Size(220, 235);
            this.panelEventDetails.TabIndex = 30;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(43, 3);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(129, 90);
            this.imageNormalPictureBox.TabIndex = 31;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 123);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(214, 112);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // panelPageDetails
            // 
            this.panelPageDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelPageDetails.Controls.Add(descriptionLabel1);
            this.panelPageDetails.Controls.Add(this.descriptionTextBox1);
            this.panelPageDetails.Controls.Add(this.imageNormalPictureBox1);
            this.panelPageDetails.Location = new System.Drawing.Point(1017, 370);
            this.panelPageDetails.Name = "panelPageDetails";
            this.panelPageDetails.Size = new System.Drawing.Size(220, 235);
            this.panelPageDetails.TabIndex = 32;
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.descriptionTextBox1.Location = new System.Drawing.Point(0, 127);
            this.descriptionTextBox1.Multiline = true;
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.Size = new System.Drawing.Size(217, 105);
            this.descriptionTextBox1.TabIndex = 1;
            // 
            // imageNormalPictureBox1
            // 
            this.imageNormalPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox1.Location = new System.Drawing.Point(40, 6);
            this.imageNormalPictureBox1.Name = "imageNormalPictureBox1";
            this.imageNormalPictureBox1.Size = new System.Drawing.Size(134, 90);
            this.imageNormalPictureBox1.TabIndex = 3;
            this.imageNormalPictureBox1.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // panelFriendPicBackGround
            // 
            this.panelFriendPicBackGround.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelFriendPicBackGround.Controls.Add(this.pictureBoxFriends);
            this.panelFriendPicBackGround.Location = new System.Drawing.Point(517, 376);
            this.panelFriendPicBackGround.Name = "panelFriendPicBackGround";
            this.panelFriendPicBackGround.Size = new System.Drawing.Size(220, 229);
            this.panelFriendPicBackGround.TabIndex = 33;
            // 
            // buttonMyAlbums
            // 
            this.buttonMyAlbums.Location = new System.Drawing.Point(517, 289);
            this.buttonMyAlbums.Name = "buttonMyAlbums";
            this.buttonMyAlbums.Size = new System.Drawing.Size(228, 53);
            this.buttonMyAlbums.TabIndex = 34;
            this.buttonMyAlbums.Text = "My Albums";
            this.buttonMyAlbums.UseVisualStyleBackColor = true;
            this.buttonMyAlbums.Click += new System.EventHandler(this.buttonMyAlbums_Click);
            // 
            // buttonUpSort
            // 
            this.buttonUpSort.Location = new System.Drawing.Point(360, 804);
            this.buttonUpSort.Name = "buttonUpSort";
            this.buttonUpSort.Size = new System.Drawing.Size(101, 49);
            this.buttonUpSort.TabIndex = 35;
            this.buttonUpSort.Text = "Most Likes";
            this.buttonUpSort.UseVisualStyleBackColor = true;
            this.buttonUpSort.Click += new System.EventHandler(this.buttonUpSort_Click);
            // 
            // buttonDownSort
            // 
            this.buttonDownSort.Location = new System.Drawing.Point(246, 804);
            this.buttonDownSort.Name = "buttonDownSort";
            this.buttonDownSort.Size = new System.Drawing.Size(108, 49);
            this.buttonDownSort.TabIndex = 36;
            this.buttonDownSort.Text = "Least Likes";
            this.buttonDownSort.UseVisualStyleBackColor = true;
            this.buttonDownSort.Click += new System.EventHandler(this.buttonDownSort_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1314, 881);
            this.Controls.Add(this.buttonDownSort);
            this.Controls.Add(this.buttonUpSort);
            this.Controls.Add(this.buttonMyAlbums);
            this.Controls.Add(this.panelPageDetails);
            this.Controls.Add(this.panelEventDetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DownloadSelectedPicture);
            this.Controls.Add(this.comboBoxAppId);
            this.Controls.Add(this.listBoxCommonPhoto);
            this.Controls.Add(this.pictureBoxCommonPhoto);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.buttonCommonPhotosFeature);
            this.Controls.Add(this.buttonHoroscopeFeature);
            this.Controls.Add(this.buttonLikePages);
            this.Controls.Add(this.buttonShowEvents);
            this.Controls.Add(this.listBoxLikePages);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.buttonShowFriends);
            this.Controls.Add(this.listBoxAboutMe);
            this.Controls.Add(this.TextProfile);
            this.Controls.Add(this.PictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.coverPictureBox);
            this.Controls.Add(this.AppId);
            this.Controls.Add(this.panelFriendPicBackGround);
            this.Name = "FormMain";
            this.Text = "Facebook Application Nadav & Liad";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.panelEventDetails.ResumeLayout(false);
            this.panelEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.panelPageDetails.ResumeLayout(false);
            this.panelPageDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panelFriendPicBackGround.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox PictureBoxProfile;
        private System.Windows.Forms.TextBox TextProfile;
        private System.Windows.Forms.ListBox listBoxAboutMe;
        private System.Windows.Forms.Button buttonShowFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxLikePages;
        private System.Windows.Forms.Button buttonShowEvents;
        private System.Windows.Forms.Button buttonLikePages;
        private System.Windows.Forms.Button buttonHoroscopeFeature;
        private System.Windows.Forms.Button buttonCommonPhotosFeature;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.PictureBox pictureBoxCommonPhoto;
        private System.Windows.Forms.ListBox listBoxCommonPhoto;
        private System.Windows.Forms.ComboBox comboBoxAppId;
        private System.Windows.Forms.Button DownloadSelectedPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AppId;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Panel panelEventDetails;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Panel panelPageDetails;
        private System.Windows.Forms.TextBox descriptionTextBox1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Panel panelFriendPicBackGround;
        private System.Windows.Forms.Button buttonMyAlbums;
        private System.Windows.Forms.Button buttonUpSort;
        private System.Windows.Forms.Button buttonDownSort;
    }
}