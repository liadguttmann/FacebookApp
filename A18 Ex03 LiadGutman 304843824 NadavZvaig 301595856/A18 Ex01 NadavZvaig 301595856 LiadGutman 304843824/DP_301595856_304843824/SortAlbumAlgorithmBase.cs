using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace DP_301595856_304843824
{
    public abstract class SortAlbumAlgorithmBase
    {
        public List<Album> SortAlbumMethod(List<Album> unsortAlbum)
        {
            int i, j;
            int N = unsortAlbum.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (albumCompare(unsortAlbum[i], unsortAlbum[i + 1]))
                    {
                        exchangeValueInAlbumList(unsortAlbum, i, i + 1);
                    }
                }
            }

            return unsortAlbum;
        }

        protected abstract bool albumCompare(Album album1, Album album2);

        private void exchangeValueInAlbumList(List<Album> data, int m, int n)
        {
            Album temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
    }
}
