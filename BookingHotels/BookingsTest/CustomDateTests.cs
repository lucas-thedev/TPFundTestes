using BookingHotels;
using NUnit.Framework;

namespace BookingsTest
{
    [TestFixture]
    public class CustomDateTests
    {
        [Test]
        public void isWeekend_Saturday_ReturnsTrue()
        {
            string date = "20Mar2019(sat)";

            bool result = CustomDate.isWeekend(date);

            Assert.IsTrue(result);
        }
        
        [Test]
        public void isWeekend_Sunday_ReturnsTrue()
        {
            string date = "20Mar2019(sun)";

            bool result = CustomDate.isWeekend(date);

            Assert.IsTrue(result);
        }
        
        [Test]
        public void isWeekend_Monday_ReturnsFalse()
        {
            string date = "20Mar2019(mon)";

            bool result = CustomDate.isWeekend(date);

            Assert.IsFalse(result);
        }
        
        [Test]
        public void isWeekend_Thursday_ReturnsFalse()
        {
            string date = "20Mar2019(thur)";

            bool result = CustomDate.isWeekend(date);

            Assert.IsFalse(result);
        }
        
        [Test]
        public void isWeekend_Tuesday_ReturnsFalse()
        {
            string date = "20Mar2019(tues)";

            bool result = CustomDate.isWeekend(date);

            Assert.IsFalse(result);
        }
        
        [Test]
        public void isWeekend_Wednesday_ReturnsFalse()
        {
            string date = "20Mar2019(wed)";

            bool result = CustomDate.isWeekend(date);

            Assert.IsFalse(result);
        }
        
        [Test]
        public void isWeekend_Friday_ReturnsFalse()
        {
            string date = "20Mar2019(fri)";

            bool result = CustomDate.isWeekend(date);

            Assert.IsFalse(result);
        }
    }
}
