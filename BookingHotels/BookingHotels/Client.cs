using System;
using System.Collections.Generic;
using System.Text;

namespace BookingHotels
{
    public class Client
    {
        protected string[] _dates;

        public string[] dates {
            get { return _dates; }
            set { _dates = value; }
        }

        protected string _typeName;

        public string typeName {
            get { return _typeName; }
            set { _typeName = value; }
        }

    }
}
