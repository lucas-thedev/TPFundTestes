using BookingHotels;
using NUnit.Framework;

namespace BookingsTest
{
    [TestFixture]
    public class MainTests
    {
        [Test]
        public void Main_CheaperHotelRegular_RetursLakewood ()
        {
            string[] dates = new string[] { "26Mar2009(thur)", "27Mar2009(fri)", "28Mar2009(sat)" };
            Hotel lakewood = new HotelLakewood();
            Hotel bridgewood = new HotelBridgewood();
            Hotel ridgewood = new HotelRidgewood();
            Hotel[] hotelBookings = new Hotel[] { lakewood, bridgewood, ridgewood };
            Client client = new ClientRegular(dates);

            Hotel result = Program.verifyCheaper(hotelBookings, client);

            Assert.AreEqual(lakewood, result);

        }
        
        [Test]
        public void Main_CheaperHotelRegular2_RetursBridgewood ()
        {
            string[] dates = new string[] { "26Mar2009(sat)", "27Mar2009(sun)", "28Mar2009(mon)" };
            Hotel lakewood = new HotelLakewood();
            Hotel bridgewood = new HotelBridgewood();
            Hotel ridgewood = new HotelRidgewood();
            Hotel[] hotelBookings = new Hotel[] { lakewood, bridgewood, ridgewood };
            Client client = new ClientRegular(dates);

            Hotel result = Program.verifyCheaper(hotelBookings, client);

            Assert.AreEqual(bridgewood, result);

        }
        
        [Test]
        public void Main_CheaperHotelRegular3_RetursLakewood ()
        {
            string[] dates = new string[] { "26Mar2009(mon)", "27Mar2009(tues)", "28Mar2009(wed)" };
            Hotel lakewood = new HotelLakewood();
            Hotel bridgewood = new HotelBridgewood();
            Hotel ridgewood = new HotelRidgewood();
            Hotel[] hotelBookings = new Hotel[] { lakewood, bridgewood, ridgewood };
            Client client = new ClientRegular(dates);

            Hotel result = Program.verifyCheaper(hotelBookings, client);

            Assert.AreEqual(lakewood, result);

        }
        
        [Test]
        public void Main_CheaperHotelReward_RetursRidgewood ()
        {
            string[] dates = new string[] { "26Mar2009(thur)", "27Mar2009(fri)", "28Mar2009(sat)" };
            Hotel lakewood = new HotelLakewood();
            Hotel bridgewood = new HotelBridgewood();
            Hotel ridgewood = new HotelRidgewood();
            Hotel[] hotelBookings = new Hotel[] { lakewood, bridgewood, ridgewood };
            Client client = new ClientReward(dates);

            Hotel result = Program.verifyCheaper(hotelBookings, client);

            Assert.AreEqual(ridgewood, result);

        }
        
        [Test]
        public void Main_CheaperHotelReward2_RetursBridgewood ()
        {
            string[] dates = new string[] { "26Mar2009(sat)", "27Mar2009(sun)", "28Mar2009(mon)" };
            Hotel lakewood = new HotelLakewood();
            Hotel bridgewood = new HotelBridgewood();
            Hotel ridgewood = new HotelRidgewood();
            Hotel[] hotelBookings = new Hotel[] { lakewood, bridgewood, ridgewood };
            Client client = new ClientReward(dates);

            Hotel result = Program.verifyCheaper(hotelBookings, client);

            Assert.AreEqual(ridgewood, result);

        }
        
        [Test]
        public void Main_CheaperHotelReward3_RetursLakewood ()
        {
            string[] dates = new string[] { "26Mar2009(mon)", "27Mar2009(tues)", "28Mar2009(wed)" };
            Hotel lakewood = new HotelLakewood();
            Hotel bridgewood = new HotelBridgewood();
            Hotel ridgewood = new HotelRidgewood();
            Hotel[] hotelBookings = new Hotel[] { lakewood, bridgewood, ridgewood };
            Client client = new ClientReward(dates);

            Hotel result = Program.verifyCheaper(hotelBookings, client);

            Assert.AreEqual(lakewood, result);

        }
    }
}