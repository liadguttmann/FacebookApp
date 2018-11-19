using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace DP_301595856_304843824
{
    public sealed class UpSortAlbumByDate : SortAlbumAlgorithmBase
    {
        protected override bool albumCompare(Album album1, Album album2)
        {
            return album1.CreatedTime < album2.CreatedTime;
        }
    }
}
