using System;
using System.Collections.Generic;
using System.Text;

namespace BookingHotels
{
    public abstract class Hotel
    {
        public static int hotelCounter;
        protected string _name;

        public string name {
            get { return _name; }
            set { _name = value; }
        }

        protected Fee _fee;

        public Fee fee {
            get { return _fee; }
            set { _fee = value; }
        }

        private Rating _rating;

        public Rating rating {
            get { return _rating; }
            set { _rating = value; }
        }

        private string[] _bookedDates;

        public string[] bookedDates {
            get { return _bookedDates; }
            set { _bookedDates = value; }
        }


        public Hotel ()
        {
            hotelCounter++;
        }

    }
}
