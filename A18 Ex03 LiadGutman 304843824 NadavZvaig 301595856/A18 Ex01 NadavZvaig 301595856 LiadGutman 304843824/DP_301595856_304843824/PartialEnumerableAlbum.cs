using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace DP_301595856_304843824
{
    public class PartialEnumerableAlbum : IEnumerable<string>
    {
        public Album Album { get; set; }

        public int AlbumSize { get; set; }

        public PartialEnumerableAlbum(Album i_Album)
        {
            Album = i_Album;
            AlbumSize = Album.Photos.Count;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (Photo currentPhoto in Album.Photos)
            {
                yield return currentPhoto.PictureNormalURL;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
