using System;
using System.Collections.Generic;
using System.Text;

namespace BookingHotels
{
    public static class CustomDate
    {
       public static bool isWeekend(string original)
        {
            string[] auxWeekendSplit = original.Split('(');
            string[] auxWeekendSplit2 = auxWeekendSplit[1].Split(')');
            if (auxWeekendSplit2[0] == "sun" || auxWeekendSplit2[0] == "sat")
            {
                return  true;
            } else
            {
                return false;
            }
        }


    }
}
