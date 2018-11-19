using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_301595856_304843824
{
    internal class UnsupportedFactoryTypeException : Exception
    {
        public UnsupportedFactoryTypeException(string i_Message) : base("Unsupported type: " + i_Message)
        {
        }
    }
}
