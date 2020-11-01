using System;
using System.Collections.Generic;
using System.Text;

namespace BookingHotels
{
    public class HotelLakewood : Hotel 
    {
        public HotelLakewood ()
        {
            name = "Lakewood";
            fee = new Fee(80, 80, 110, 90);
            rating = new Rating(3);
            bookedDates = new string[] { "16Mar2009(mon)", "17Mar2009(tues)", "17Mar2009(tues)" };
        }
    }
}
