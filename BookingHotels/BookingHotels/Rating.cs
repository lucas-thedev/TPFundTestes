using System;
using System.Collections.Generic;
using System.Text;

namespace BookingHotels
{
    public class Rating
    {
        private int _value;

        public int value {
            get { return _value; }
            set { 
                if (value >= 1 || value <= 5)
                {
                    _value = value;
                }else
                {
                    value = 1;
                }
            }
        } 

        public Rating (int classificationValue)
        {
            value = classificationValue;
        }

        /// <summary>
        /// Receive two hotels as parameter and returns the one with the highest rating. Response type: Hotel.
        /// </summary>
        /// <param name="hotel1"></param>
        /// <param name="hotel2"></param>
        /// <returns></returns>
        public static Hotel Compare(Hotel hotel1, Hotel hotel2)
        {
            if (hotel1.rating.value >= hotel2.rating.value)
            {
                return hotel1;
            } else
            {
                return hotel2;
            }
        }

    }
}
