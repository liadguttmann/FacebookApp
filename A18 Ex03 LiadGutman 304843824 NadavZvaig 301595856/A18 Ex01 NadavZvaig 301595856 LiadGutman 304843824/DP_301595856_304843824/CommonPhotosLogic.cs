using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DP_301595856_304843824
{
    public class CommonPhotosLogic
    {
        public static LinkedList<Photo> MakeListOfCommonPhotos(FacebookObjectCollection<Album> i_UserAlbumsCollection, string i_TagToSearch)
        {
            LinkedList<Photo> photoList = new LinkedList<Photo>();

            foreach (Album currentAlbum in i_UserAlbumsCollection)
            {
                if (currentAlbum.Photos != null)
                {
                    searchAlbumForFriendTags(i_TagToSearch, currentAlbum, photoList);
                }
            }

            return photoList;
        }

        private static void searchAlbumForFriendTags(string i_TagToSearch, Album i_AlbumToCheck, LinkedList<Photo> i_PhotoList)
        {
            foreach (Photo currentPhoto in i_AlbumToCheck.Photos)
            {
                if (currentPhoto.Tags == null)
                {
                    continue;
                }

                foreach (PhotoTag currentTag in currentPhoto.Tags)
                {
                    if (currentTag.User.Name == i_TagToSearch)
                    {
                        i_PhotoList.AddLast(currentPhoto);
                    }
                }
            }
        }
    }
}
