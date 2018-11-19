using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_301595856_304843824
{
    internal class CriterionSelection
    {
        public static IPopularCriterion GetCriteriaOfType(int i_Type)
        {
            IPopularCriterion result;

            switch (i_Type)
            {
                case 0:
                    result = new MostLikesCountCriterion();
                    break;
                case 1:
                    result = new MostUnlikesCountCriterion();
                    break;
                default:
                    throw new UnsupportedFactoryTypeException(i_Type.ToString());
            }

            return result;
        }
    }
}
