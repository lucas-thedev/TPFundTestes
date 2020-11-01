using System;
using System.Collections.Generic;
using System.Text;

namespace BookingHotels
{
    public class ClientRegular : Client
    {
        public ClientRegular (string[] date)
        {
            typeName = "regular";
            dates = date;
        }
    }
}
