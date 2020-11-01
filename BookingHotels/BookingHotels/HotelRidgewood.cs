using System;
using System.Collections.Generic;
using System.Text;

namespace BookingHotels
{
    public class HotelRidgewood : Hotel
    {

        public HotelRidgewood()
        {
            name = "Ridgewood";
            fee = new Fee(40, 100, 220, 150);
            rating = new Rating(5);
            bookedDates = new string[] { "16Mar2009(mon)", "17Mar2009(tues)", "17Mar2009(tues)" };
        }
    }
}
