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
    public class HoroscopeLogic
    {
        public string GetHoroscopeText(string httpUrl)
        {
            string horoscopeText = "Date is invaild";
            HttpAdapter httpAdp = new HttpAdapter();
            string responseString = httpAdp.httpGetData(httpUrl);
            var dateTime = DateTime.Today;

            CultureInfo convertMonthName = CultureInfo.GetCultureInfoByIetfLanguageTag("Eng");
            string month = convertMonthName.DateTimeFormat.GetMonthName(dateTime.Month);
            string markString = dateTime.DayOfWeek.ToString() + ", " + month + " " + dateTime.Day.ToString() + ", " + dateTime.Year.ToString();

            if (responseString.Contains(markString))
            {
                int markIndex = responseString.IndexOf(markString);
                int startIdx = responseString.IndexOf("<p>", markIndex) + 3;
                int endIdx = responseString.IndexOf("</p>", startIdx);
                horoscopeText = responseString.Substring(startIdx, endIdx - startIdx);
            }

            return horoscopeText;
        }

        public string GetHoroscopeByDateOfBirth(int day, int month)
        {
            string horoscopeText;
            string httpUrl;
            switch (month)
            {
                case 1:
                    if (day <= 19)
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/capricorn-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }
                    else
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/aquarius-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }

                case 2:
                    if (day <= 18)
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/aquarius-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }
                    else
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/pisces-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }

                case 3:
                    if (day <= 20)
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/pisces-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }
                    else
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/aries-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }

                case 4:
                    if (day <= 19)
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/aries-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }
                    else
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/taurus-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }

                case 5:
                    if (day <= 20)
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/taurus-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }
                    else
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/gemini-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }

                case 6:
                    if (day <= 20)
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/gemini-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }
                    else
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/cancer-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }

                case 7:
                    if (day <= 22)
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/cancer-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }
                    else
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/leo-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }

                case 8:
                    if (day <= 22)
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/leo-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }
                    else
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/virgo-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }

                case 9:
                    if (day <= 22)
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/virgo-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }
                    else
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/libra-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }

                case 10:
                    if (day <= 22)
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/libra-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }
                    else
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/scorpio-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }

                case 11:
                    if (day <= 21)
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/scorpio-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }
                    else
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/sagittarius-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }

                case 12:
                    if (day <= 21)
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/sagittarius-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }
                    else
                    {
                        httpUrl = "http://astrostyle.com/daily-horoscopes/capricorn-daily-horoscope/";
                        horoscopeText = GetHoroscopeText(httpUrl);
                        return horoscopeText;
                    }
            } 

                return string.Empty;
        }

        public int dateConvert(string date, int startIndex, int endIndex)
        {
            bool isConvertSuccess;
            int newDate;
            string subString = date.Substring(startIndex, endIndex);
            isConvertSuccess = int.TryParse(subString, out newDate);
            return newDate;
        }
    }
}
