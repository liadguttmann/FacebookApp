using System.Net;
using System.IO;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using Facebook;

namespace DP_301595856_304843824
{
    public partial class FormHoroscope : Form
    {
        public FormHoroscope(string horoscopeText)
        {
            InitializeComponent();
            Image myimage = new Bitmap(@"C:\Users\user\Documents\Visual Studio 2017\Projects\DP_301595856_304843824\DP_301595856_304843824\pics\zodiac-love-2017.jpg");
            myimage = (Image)(new Bitmap(myimage, new Size(950, 420)));
            this.BackgroundImage = myimage;
            string[] splitHoroscope = horoscopeText.Split('.', '?');
            foreach (string subStringHoroscope in splitHoroscope)
            {
                this.listBoxHoroscope.Items.Add(subStringHoroscope.Trim());
            }
        }
    }
}
