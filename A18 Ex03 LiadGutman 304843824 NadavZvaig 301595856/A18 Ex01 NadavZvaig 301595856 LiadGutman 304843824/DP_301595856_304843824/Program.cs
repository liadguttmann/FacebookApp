using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DP_301595856_304843824
{
    public static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}