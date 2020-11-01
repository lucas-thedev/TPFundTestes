using System;
using System.Collections.Generic;
using System.Text;

namespace BookingHotels
{
    public class ClientReward : Client
    {
        public ClientReward (string [] date)
        {
            typeName = "reward";
            dates = date;
        }
    }
}
