using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Xml.Serialization;

namespace DP_301595856_304843824
{
    public class FileUtiles
    {
        public static FileUtiles GetInstance
        {
            get { return GenericSingleton<FileUtiles>.Instance; }
        }

        private FileUtiles()
        {
        }

        public void saveImgToFile(string i_FileName, string i_Url)
        {
            using (WebClient Client = new WebClient())
            {
                Uri uri = new Uri(i_Url);
                Client.DownloadFile(uri, i_FileName);
            }
        }
    }
}
