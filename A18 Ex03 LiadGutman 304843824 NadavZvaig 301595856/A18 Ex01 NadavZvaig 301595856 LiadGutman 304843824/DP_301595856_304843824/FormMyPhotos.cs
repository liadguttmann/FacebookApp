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
    public partial class FormMyPhotos : Form
    {
        public static IEnumerator<string> m_CurrentPartialEnumerableAlbumEnumerator;

        public FacebookObjectCollection<Album> m_AlbumCollection { get; set; }

        public FormMyPhotos(FacebookObjectCollection<Album> AlbumCollection)
        {
             m_AlbumCollection = AlbumCollection;
             InitializeComponent();
        }

        private void buttonShowAlbums_Click(object sender, EventArgs e)
        {
            showAlbumsListInListbox();
        }

        private void showAlbumsListInListbox()
        {
            buttonShowAlbums.Enabled = false;
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";

            try
            {
                foreach (Album currentAlbum in m_AlbumCollection)
                {
                    listBoxAlbums.Items.Add(currentAlbum);
                }

                if (listBoxAlbums.Items.Count == 0)
                {
                    MessageBox.Show("You Have No Albums Yet");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            buttonShowAlbums.Enabled = true;
        }

        private void setPartialEnumerableAlbumEnumerator()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                m_CurrentPartialEnumerableAlbumEnumerator = (new PartialEnumerableAlbum(listBoxAlbums.SelectedItem as Album)).GetEnumerator();
            }
        }

        private void buttonNextPhoto_Click(object sender, EventArgs e)
        {
            showNextPhotoInPictureBoxAlbums();
        }

        private void showNextPhotoInPictureBoxAlbums()
        {
            try
            {
                if (m_CurrentPartialEnumerableAlbumEnumerator.MoveNext())
                {
                    pictureBoxAlbumPhotos.LoadAsync(m_CurrentPartialEnumerableAlbumEnumerator.Current);
                }
                else
                {
                    MessageBox.Show("You Have No More Pictures To Show");
                }
            }
            catch
            {
                MessageBox.Show("NO ALBUM SELECTED");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            setPartialEnumerableAlbumEnumerator();
            showNextPhotoInPictureBoxAlbums();
        }

        private void buttonNewestAlbumSort_Click(object sender, EventArgs e)
        {
            try
            {
                SortAlbumAlgorithmBase newestAlbumSort = new UpSortAlbumByDate();
                List<Album> sortedNewestAlbumCollection = newestAlbumSort.SortAlbumMethod(m_AlbumCollection.ToList());
                listBoxAlbums.Items.Clear();
                foreach (Album currentAlbum in sortedNewestAlbumCollection)
                {
                    listBoxAlbums.Items.Add(currentAlbum);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonOldestAlbumSort_Click(object sender, EventArgs e)
        {
            try
            {
                SortAlbumAlgorithmBase oldestAlbumSort = new DownSortAlbumByDate();
                List<Album> sortedOldestAlbumCollection = oldestAlbumSort.SortAlbumMethod(m_AlbumCollection.ToList());
                listBoxAlbums.Items.Clear();
                foreach (Album currentAlbum in sortedOldestAlbumCollection)
                {
                    listBoxAlbums.Items.Add(currentAlbum);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
