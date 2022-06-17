using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            InvoiceGenerator cabInvoice = new InvoiceGenerator();
            Ride[] ride = { new Ride(15, 3), new Ride(10, 5), new Ride(20, 7), new Ride(20, 10) };
            EnhancedInvoiceClass generator= cabInvoice.MultipleRides(ride);
            Console.WriteLine("TotalFare: " + generator.TotalFare + "\nNumberOfRides: " + generator.NoOfRides + "\nAverage Fare: " + generator.AvgFare);
        }
    }
}