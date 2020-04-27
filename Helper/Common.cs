using Seating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace Seating.Helper
{
    public class Common
    {
        public static List<string> getTimes()
        {
            //you can add as much you want
            List<string> times = new List<string>();
            var dt = DateTime.Now;
            if (dt.Hour >= 02 && dt.Hour < 04)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 8, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 9, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 9, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("HH:mm"));
            }

            if (dt.Hour >= 04 && dt.Hour < 06)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 8, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 9, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 9, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("HH:mm"));
            }

            if (dt.Hour >= 06 && dt.Hour < 08)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("HH:mm"));
            }
            if (dt.Hour >= 08 && dt.Hour < 10)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("HH:mm"));
            }
            if (dt.Hour >= 10 && dt.Hour < 12)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("HH:mm"));
            }
            if (dt.Hour >= 12 && dt.Hour < 14)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("HH:mm"));
            }

            if (dt.Hour >= 14 && dt.Hour < 16)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("HH:mm"));
            }

            if (dt.Hour >= 16 && dt.Hour < 18)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }
            if (dt.Hour >= 18 && dt.Hour < 20)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 20 && dt.Hour < 23 && dt.Minute < 59)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 00 && dt.Hour < 02)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).ToString("HH:mm"));
            }


            return times;

        }
        public static List<string> getTimesOver()
        {
            //you can add as much you want
            List<string> times = new List<string>();
            var dt = DateTime.Now;
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }
            return times;
        }
    }
}
