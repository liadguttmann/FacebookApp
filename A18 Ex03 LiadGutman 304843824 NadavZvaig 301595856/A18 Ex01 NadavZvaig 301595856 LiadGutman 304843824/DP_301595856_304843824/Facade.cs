using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace DP_301595856_304843824
{
    public class Facade
    {
        private HoroscopeLogic m_horoscope = new HoroscopeLogic();
        public AppLogic m_logic = new AppLogic();
        private string m_AppID;
        public string CurrentFriendNameForCommonPicsFeature;
        public List<string> ListFriendName = new List<string>();

        public FacebookObjectCollection<Page> UserLikedPagesCollection { get; set; }

        public FacebookObjectCollection<Event> UserEventsCollection { get; set; }

        public FacebookObjectCollection<Album> UserAlbumsCollection { get; set; }

        public void loginToFacebook(string AppID)
        {
            m_AppID = AppID;
            m_logic.loginToFacebook(m_AppID);
            setPropertiesToFacadeObjects();
        }

        public void setPropertiesToFacadeObjects()
        {
            ListFriendName = m_logic.ListFriendName;
            UserEventsCollection = m_logic.UserEventsCollection;
            UserLikedPagesCollection = m_logic.UserLikedPagesCollection;
            UserAlbumsCollection = m_logic.UserAlbumsCollection;
        }

        public bool isLoggedInUser()
        {
            if (m_logic.m_LoggedInUser != null)
            {
                return true;
            }

            return false;
        }

        public string getLoggedInUserFirstName()
        {
            return m_logic.m_LoggedInUser.FirstName;
        }

        public string getLoggedInUserLastName()
        {
            return m_logic.m_LoggedInUser.LastName;
        }

        public string getLoggedInUserPictureNormalURL()
        {
            return m_logic.m_LoggedInUser.PictureNormalURL;
        }

        public string getLoggedInUserCoverPictureURL()
        {
            return m_logic.m_LoggedInUser.Cover.SourceURL;
        }

        public string getLoggedInUserGender()
        {
            return m_logic.m_LoggedInUser.Gender.ToString();
        }

        public string getLoggedInUserBirthday()
        {
            return m_logic.m_LoggedInUser.Birthday;
        }

        public string getLoggedInUserRelationshipStatus()
        {
            return m_logic.m_LoggedInUser.RelationshipStatus.ToString();
        }

        public void PostStatus(string status)
        {
            m_logic.m_LoggedInUser.PostStatus(status);
        }

        public bool logOut()
        {
            try
            {
                FacebookService.Logout(nullFunction);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void nullFunction()
        {
        }

        public string getFriendPicUrl(string friendName)
        {
            return m_logic.getFriendPicUrl(friendName);
        }

        public string getHoroscopeText()
        {
            int month = m_horoscope.dateConvert(m_logic.m_LoggedInUser.Birthday, 0, 2);
            int day = m_horoscope.dateConvert(m_logic.m_LoggedInUser.Birthday, 3, 2);
            string horoscopeText = m_horoscope.GetHoroscopeByDateOfBirth(day, month);
            return horoscopeText;
        }

        public string getCurrentFriendNameForCommonPicsFeature()
        {
            CurrentFriendNameForCommonPicsFeature = m_logic.CurrentFriendNameForCommonPicsFeature;
            return CurrentFriendNameForCommonPicsFeature;
        }

        public List<string> getCommonPhotoNameList(string friendName)
        {
           return m_logic.getCommonPhotoNameList(friendName);
        }

        public string getCommonPictureUrl(string pictureName)
        {
            return m_logic.getCommonPictureUrl(pictureName);
        }

        public void saveImageToFile(string filename, string url)
        {
            m_logic.saveImageToFile(filename, url);
        }

        public List<string> getSortedCommonPhotoNameList(string friendName, int sortType)
        {
            return m_logic.getSortedCommonPhotoNameList(friendName, sortType);
        }
    }
}
