using BookingHotels;
using NUnit.Framework;

namespace BookingsTest
{
    [TestFixture]
    public class RatingTests
    {
        [Test]
        public void Compare_Hotel1BiggerRating_ReturnsHotel1()
        {
            Hotel hotel1 =  new HotelRidgewood(); // bigger rating
            Hotel hotel2 =  new HotelLakewood();

            Hotel result = Rating.Compare(hotel1, hotel2);

            Assert.AreEqual(hotel1, result);
        }
        
        [Test]
        public void Compare_Hotel1BiggerRating_ReturnsHotel2()
        {
            Hotel hotel1 =  new HotelRidgewood(); // bigger rating
            Hotel hotel2 =  new HotelLakewood();

            Hotel result = Rating.Compare(hotel1, hotel2);

            Assert.AreNotEqual(hotel2, result);
        }
        
        [Test]
        public void Compare_Hotel2BiggerRating_ReturnsHotel2()
        {
            Hotel hotel1 =  new HotelBridgewood();
            Hotel hotel2 = new HotelRidgewood(); // bigger rating

            Hotel result = Rating.Compare(hotel1, hotel2);

            Assert.AreEqual(hotel2, result);
        }
        
        [Test]
        public void Compare_Hotel2BiggerRating_ReturnsHotel1()
        {
            Hotel hotel1 =  new HotelBridgewood();
            Hotel hotel2 = new HotelRidgewood(); // bigger rating

            Hotel result = Rating.Compare(hotel1, hotel2);

            Assert.AreNotEqual(hotel1, result);
        }
        
    }
}
