namespace CabInvoiceTesting
{
    public class Tests
    {        
        [Test]
        public void GivenDistanceAndTime_CalculatingFare_ShouldReturnExpectedTotalFare()
        {
            double distance = 15;
            int time = 10, expected = 160;
            CabInvoiceGenerator.InvoiceGenerator fare = new CabInvoiceGenerator.InvoiceGenerator(distance, time);
            Assert.AreEqual(expected, fare.CalculateFare());
        }        
    }
}