using System;
using System.Collections.Generic;
using System.Text;

namespace BookingHotels
{
    public class HotelBridgewood : Hotel
    {
        public HotelBridgewood ()
        {
            name = "Bridgewood";
            fee = new Fee(50, 110, 160, 60);
            rating = new Rating(4);
        }
    }
}
