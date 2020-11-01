using System;
using System.Collections.Generic;
using System.Text;

namespace BookingHotels
{
    public class Fee
    {
        private double _weekendFeeReward;

        public double weekendFeeReward {
            get { return _weekendFeeReward; }
            set {
                if (value >= 0)
                {
                    _weekendFeeReward = value;
                } else
                {
                    _weekendFeeReward = 0;
                }
            }
        }

        private double _weekdayFeeReward;

        public double weekdayFeeReward {
            get { return _weekdayFeeReward; }
            set { 
                if(value >= 0)
                {
                    _weekdayFeeReward = value;
                } else
                {
                    _weekdayFeeReward = 0;
                }
                
            }
        }

        private double _weekendFeeRegular;

        public double weekendFeeRegular {
            get { return _weekendFeeRegular; }
            set {
                if (value >= 0)
                {
                    _weekendFeeRegular = value;
                } else
                {
                    _weekendFeeRegular = 0;
                }
                
            }
        }

        private double _weekdayFeeRegular;

        public double weekdayFeeRegular {
            get { return _weekdayFeeRegular; }
            set { 
                if (value >= 0)
                {
                    _weekdayFeeRegular = value;
                } else
                {
                    _weekdayFeeRegular = 0;
                }
               
            }
        }

        public Fee(double weekendFReward, double weekdayFReward, double weekdayFRegular, double weekendFRegular)
        {
            weekdayFeeRegular = weekdayFRegular;
            weekendFeeRegular = weekendFRegular;
            weekdayFeeReward = weekdayFReward;
            weekendFeeReward = weekendFReward;
        }

        /// <summary>
        /// Receive a client and returns the total fee. Response type: double.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public double Calculate(Client client)
        {
            double finalPrice = 0.0;
            if (client.typeName == "reward")
            {
                
                foreach (string date in client.dates)
                {
                    if (CustomDate.isWeekend(date))
                   {
                        finalPrice += weekendFeeReward;
                   } else
                   {
                        finalPrice += weekdayFeeReward;
                   }
                }
            }
            if (client.typeName == "regular")
            {
                foreach (string date in client.dates)
                {
                   if (CustomDate.isWeekend(date))
                   {
                        finalPrice += weekendFeeRegular;
                   } else
                   {
                        finalPrice += weekdayFeeRegular;
                   }
                }
            }
            return finalPrice;
        }

    }
}
