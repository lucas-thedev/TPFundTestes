using System;
using System.IO;

namespace BookingHotels
{
    public class Program
    {
        /// <summary>
        /// Receives an array of Hotel and a Client. Returns the cheapest Hotel based on Client type and dates. Response type: Hotel.
        /// </summary>
        /// <param name="hotelBookings"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        public static Hotel verifyCheaper (Hotel[] hotelBookings, Client client)
        {
            double hotelfee = 0.0;
            double cheapestFee = 999999;
            Hotel cheapestHotel = hotelBookings[0];

            for (int i = 0; i < 3; i++)
            {
                hotelfee = hotelBookings[i].fee.Calculate(client);
                if (hotelfee <= cheapestFee)
                {
                    cheapestHotel = Rating.Compare(cheapestHotel, hotelBookings[i]);
                    cheapestFee = hotelfee;
                }
            }

            return cheapestHotel;
        }
        public static void Main(string[] args)
        {
            string filePath = "C:/Users/jujua/source/repos/BookingHotels/File/bookings.txt";
            string[] lines = File.ReadAllLines(@filePath);
            string[] dates = new string[lines.Length];
            Hotel cheaper; // receives the final result for each client

            // HOTEL CLASSES -------------------------------------------------------------------

            Hotel lakewood = new HotelLakewood();
            Hotel bridgewood = new HotelBridgewood();
            Hotel ridgewood = new HotelRidgewood();
            Hotel[] hotelBookings = new Hotel[] { lakewood, bridgewood, ridgewood };

            // CLIENT CLASSES -------------------------------------------------------------------
            Client rewardType = new ClientReward(dates);
            Client regularType = new ClientRegular(dates);
            Client client;

            // MAIN -----------------------------------------------------------------------------

            string connectionString = "";


            foreach(string line in lines)
            {
                string[] splitClient = line.Split(':');
                string[] splitDates = splitClient[1].Split(',');
                if (splitClient[0] == "Regular")
                {
                    regularType.dates = splitDates;
                    client = regularType;
                } else if (splitClient[0] == "Reward")
                {
                    rewardType.dates = splitDates;
                    client = regularType;
                } else
                {
                    Console.WriteLine("Error: file couldn't be processed.");
                    break;
                }
                cheaper = verifyCheaper(hotelBookings, client);
                Console.WriteLine(cheaper.name);

            }
            
            Console.ReadKey();
        }
    }
}   
