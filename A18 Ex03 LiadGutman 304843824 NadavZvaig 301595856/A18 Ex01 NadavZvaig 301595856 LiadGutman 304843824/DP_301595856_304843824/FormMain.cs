using System.Threading;
using System.Net;
using System.IO;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace DP_301595856_304843824
{   
    public partial class FormMain : Form
    {
        private Facade m_facade = new Facade();
        private string m_currentAppID;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                m_facade.loginToFacebook(m_currentAppID);
                doAfterLogIn();
                if (m_facade.isLoggedInUser())
                {
                    this.ButtonLogin.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "You didn't chose AppId" + Environment.NewLine + "Please choose AppId in the ComboBox first");
            }
        }

        private void doAfterLogIn()
        {
            comboBoxAppId.Enabled = false;
            this.TextProfile.Text = "Hello: " + m_facade.getLoggedInUserFirstName() + " " + m_facade.getLoggedInUserLastName();
            this.PictureBoxProfile.ImageLocation = m_facade.getLoggedInUserPictureNormalURL();
            coverPictureBox.LoadAsync(m_facade.getLoggedInUserCoverPictureURL());
            this.listBoxAboutMe.Items.Add("About Me:");
            this.listBoxAboutMe.Items.Add("Gender: " + m_facade.getLoggedInUserGender());
            this.listBoxAboutMe.Items.Add("Birthdate: " + m_facade.getLoggedInUserBirthday());
            this.listBoxAboutMe.Items.Add("Relationship status: " + m_facade.getLoggedInUserRelationshipStatus());
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            postStatus();
        }

        private void postStatus()
        {
            try
            {
                m_facade.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Your status has been posted!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void logOut()
        {
            if (m_facade.logOut())
            {
                Close();
            }
            else
            {
                MessageBox.Show("You havent logged in yet");
            }
        }

        private void buttonShowFriends_Click(object sender, EventArgs e)
        {
            showFriends();
        }

        private void showFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            try
            {
                foreach (string friendName in m_facade.ListFriendName)
                {
                    listBoxFriends.Items.Add(friendName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            string friendName = listBoxFriends.SelectedItem.ToString();
            string friendPicUrl = m_facade.getFriendPicUrl(friendName);
            pictureBoxFriends.LoadAsync(friendPicUrl);
            buttonCommonPhotosFeature.Text = "Common Photo with:" + friendName;
        }

        private void buttonShowEvents_Click(object sender, EventArgs e)
        {
            showEvents();
        }

        private void showEvents()
        {
            try
            {
                eventBindingSource.DataSource = m_facade.UserEventsCollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void buttonLikePages_Click(object sender, EventArgs e)
        {
            showPages();
        }

        private void showPages()
        {
            try
            {
                pageBindingSource.DataSource = m_facade.UserLikedPagesCollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHoroscopeFeature_Click(object sender, EventArgs e)
        {
            showHoroscope();
        }

        private void showHoroscope()
        {
            try
            {
                string horoscopeText = m_facade.getHoroscopeText();

                FormHoroscope form = new FormHoroscope(horoscopeText);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCommonPhotosFeature_Click(object sender, EventArgs e)
        {
            new Thread(() => showCommonPhotos()).Start();
        }

        private void showCommonPhotos()
        {
            listBoxCommonPhoto.Invoke((MethodInvoker)(() => 
            {
                listBoxCommonPhoto.Items.Clear();
                listBoxCommonPhoto.DisplayMember = "CreatedTime";
                try
                {
                    addCommonPicturesToListBox();
                    if (listBoxCommonPhoto.Items.Count == 0)
                    {
                        MessageBox.Show(string.Format("You have no common photos with {0}", m_facade.getCurrentFriendNameForCommonPicsFeature()));
                    }
                }
                catch
                {
                    MessageBox.Show("You have no albums");
                }
            }));
        }

        private void addCommonPicturesToListBox()
        {
            List<string> photoNameList = m_facade.getCommonPhotoNameList(listBoxFriends.SelectedItem.ToString());
            foreach (string currentPhotoName in photoNameList)
            {
                listBoxCommonPhoto.Items.Add(currentPhotoName);
            }
        }

        private void listBoxCommonPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DownloadSelectedPicture.Enabled = true;
            string selectedPhotoName = listBoxCommonPhoto.SelectedItem as string;
            string selectedPhotoUrl = m_facade.getCommonPictureUrl(selectedPhotoName);
            pictureBoxCommonPhoto.LoadAsync(selectedPhotoUrl);
        }

        private void comboBoxAppId_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_currentAppID = comboBoxAppId.SelectedItem.ToString();
        }

        private void DownloadSelectedPicture_Click(object sender, EventArgs e)
        {
            saveImageToFile();
        }

        private void saveImageToFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            DialogResult saveBrowserDialogResult = saveFileDialog.ShowDialog();
            
            if (saveBrowserDialogResult == DialogResult.OK)
            {
                string filename = string.Format("{0}.jpg", saveFileDialog.FileName);
                string url = pictureBoxCommonPhoto.ImageLocation;
                m_facade.saveImageToFile(filename, url);
            }
        }

        private void buttonMyAlbums_Click(object sender, EventArgs e)
        {
            showMyPhotos();
        }

        private void showMyPhotos()
        {
            try
            {
                FormMyPhotos form = new FormMyPhotos(m_facade.UserAlbumsCollection);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpSort_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxCommonPhoto.Items.Clear();
                List<string> photoNameList = m_facade.getSortedCommonPhotoNameList(listBoxFriends.SelectedItem.ToString(), 0);

                foreach (string currentPhotoName in photoNameList)
                {
                    listBoxCommonPhoto.Items.Add(currentPhotoName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDownSort_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxCommonPhoto.Items.Clear();
                List<string> photoNameList = m_facade.getSortedCommonPhotoNameList(listBoxFriends.SelectedItem.ToString(), 1);

                foreach (string currentPhotoName in photoNameList)
                {
                    listBoxCommonPhoto.Items.Add(currentPhotoName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
