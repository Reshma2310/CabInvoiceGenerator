using CabInvoiceGenerator;
namespace CabInvoiceTesting
{
    public class Tests
    {
        /*UC1-Test Case
        [Test]
        public void GivenDistanceAndTime_CalculatingFare_ShouldReturnExpectedTotalFare()
        {
            double distance = 15;
            int time = 10, expected = 160;
            CabInvoiceGenerator.InvoiceGenerator fare = new CabInvoiceGenerator.InvoiceGenerator(distance, time);
            Assert.AreEqual(expected, fare.CalculateFare());
        }
        UC2-TestCases
        [Test]
        public void DistanceAndTimeInput_CalculateForMultipleRides_ShouldReturnExpectedTotalFare()
        {
            double distance = 15;
            int time = 10, expected = 160;
            InvoiceGenerator fare = new InvoiceGenerator();
            Ride ride = new Ride(distance, time);
            Assert.AreEqual(expected, fare.CalculateFare(ride));
        }
        [Test]
        public void MultipleRideData_CalculateForMultipleRides_ShouldReturnExpectedTotalFare()
        {
            int expected = 415;
            CabInvoiceGenerator.InvoiceGenerator fare = new CabInvoiceGenerator.InvoiceGenerator();
            Ride[] ride = { new Ride(20, 7), new Ride(10, 5), new Ride(10, 3) };
            Assert.AreEqual(expected, fare.MultipleRides(ride));
        }*/
        [Test]
        public void MultipleRideData_CalculateTotalFare_NoOfRides_AvgFare_ShouldReturnExpectedValues()
        {
            InvoiceGenerator fare = new InvoiceGenerator();
            Ride[] ride = { new Ride(20, 7), new Ride(10, 5), new Ride(10, 3) };
            double TotalFare = 415, NoOfRides = ride.Length, AvgFare = TotalFare / NoOfRides;
            EnhancedInvoiceClass result = fare.MultipleRides(ride);
            Assert.AreEqual(TotalFare, result.TotalFare);
            Assert.AreEqual(AvgFare, result.AvgFare);
            Assert.AreEqual(NoOfRides, result.NoOfRides);
        }
        [Test]
        public void GivenUserID_ShouldReturnExpectedTotalFare_numberOfRides_AverageFare()
        {
            RideRepository fare = new RideRepository();
            Ride[] ride = { new Ride(20, 7), new Ride(10, 5), new Ride(10, 3) };
            double TotalFare = 415, NoOfRides = ride.Length, AvgFare = TotalFare / NoOfRides;
            fare.AddRides("First", ride);
            var result = fare.UserInvoice("First");
            Assert.AreEqual(TotalFare, result.TotalFare);
            Assert.AreEqual(AvgFare, result.AvgFare);
            Assert.AreEqual(NoOfRides, result.NoOfRides);
        }
    }
}