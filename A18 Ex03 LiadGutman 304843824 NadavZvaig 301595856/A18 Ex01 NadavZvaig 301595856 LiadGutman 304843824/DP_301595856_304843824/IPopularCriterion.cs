using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DP_301595856_304843824
{
    internal interface IPopularCriterion
    {
        bool Compare(Photo i_First, Photo i_Second);
    }
}
