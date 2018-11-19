using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace DP_301595856_304843824
{
    public class AppLogic
    {
        public User m_LoggedInUser;

        private string currentSelectedFriendName = null;
        private LinkedList<Photo> currentCommonPhotoLinkedList = null;

        public LoginResult m_Result;

        public List<string> ListEventName = new List<string>();
        public List<string> ListFriendName = new List<string>();
        public List<string> ListLikedPageName = new List<string>();

        private IPopularCriterion m_Criteria;

        public void loginToFacebook(string AppID)
        {   
            m_Result = FacebookService.Login(
                AppID,
                "public_profile",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",
                "publish_pages",
                "publish_actions",
                "rsvp_event");
            m_LoggedInUser = m_Result.LoggedInUser;
            setPropertiesAfterLogin();
        }

        public string CurrentFriendNameForCommonPicsFeature { get; set; } = null;

        public string UserName { get; set; }

        public string UserPicURL { get; set; }

        public FacebookObjectCollection<User> UserFriendsCollection { get; set; }

        public FacebookObjectCollection<Event> UserEventsCollection { get; set; }

        public FacebookObjectCollection<Page> UserLikedPagesCollection { get; set; }

        public FacebookObjectCollection<Album> UserAlbumsCollection { get; set; }

        private void setPropertiesAfterLogin()
        {
            UserName = m_LoggedInUser.Name;
            UserPicURL = m_LoggedInUser.PictureNormalURL;
            UserFriendsCollection = m_LoggedInUser.Friends;
            UserLikedPagesCollection = m_LoggedInUser.LikedPages;
            UserAlbumsCollection = m_LoggedInUser.Albums;
            UserEventsCollection = m_LoggedInUser.Events;

            foreach (User friend in UserFriendsCollection)
            {
                ListFriendName.Add(friend.Name);
            }
        }

        public string getFriendPicUrl(string friendName)
        {
            foreach (User user in UserFriendsCollection)
            {
                if (friendName == user.Name)
                {
                    return user.PictureNormalURL;
                }
            }

            return null;
        }

        public List<string> getCommonPhotoNameList(string friendName)
        {
            List<string> commonPhotoNameList = new List<string>();
            currentSelectedFriendName = friendName;
            currentCommonPhotoLinkedList = CommonPhotosLogic.MakeListOfCommonPhotos(UserAlbumsCollection, friendName);
            foreach (Photo currentPhoto in currentCommonPhotoLinkedList)
            {
                commonPhotoNameList.Add(currentPhoto.CreatedTime.ToString());
            }

            return commonPhotoNameList;
        }

        public string getCommonPictureUrl(string pictureName)
        {
            foreach (Photo currentPhoto in currentCommonPhotoLinkedList)
            {
                if (currentPhoto.CreatedTime.ToString() == pictureName)
                {
                    return currentPhoto.PictureNormalURL;
                }
            }

            return string.Empty;
        }

        public void saveImageToFile(string filename, string url)
        {
            FileUtiles.GetInstance.saveImgToFile(filename, url);
        }

        public void CreateConcretePopularCriteria(int i_Type)
        {
            m_Criteria = CriterionSelection.GetCriteriaOfType(i_Type);
        }

        public void sort(Photo postedItem1, Photo postedItem2)
        {
            if (m_Criteria.Compare(postedItem1, postedItem2))
            {
                postedItem1 = postedItem2;
            }
        }

        private void exchangeValueInList(List<Photo> data, int m, int n)
        {
            Photo temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        private void ListPhotoBubbleSort(List<Photo> photoList)
        {
            int i, j;
            int N = photoList.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (m_Criteria.Compare(photoList[i], photoList[i + 1]))
                    {
                        exchangeValueInList(photoList, i, i + 1);
                    }
                }
            }
        }

        public List<string> getSortedCommonPhotoNameList(string friendName, int sortType)
        {
            CreateConcretePopularCriteria(sortType);

            List<string> commonPhotoNameList = new List<string>();
            currentSelectedFriendName = friendName;
            currentCommonPhotoLinkedList = CommonPhotosLogic.MakeListOfCommonPhotos(UserAlbumsCollection, friendName);

            List<Photo> currentCommonPhotoList = currentCommonPhotoLinkedList.ToList();

            ListPhotoBubbleSort(currentCommonPhotoList);

            foreach (Photo currentPhoto in currentCommonPhotoList)
            {
                String photoName = String.Format("{0}", currentPhoto.CreatedTime.ToString());
                commonPhotoNameList.Add(photoName);
            }

            return commonPhotoNameList;
        }
    }
}
