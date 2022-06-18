using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RideRepository cabInvoice = new RideRepository();
            Ride[] ride = { new Ride(15, 3), new Ride(10, 5), new Ride(20, 7), new Ride(20, 10) };
            cabInvoice.AddRides("Ride1", ride);
            Ride[] rides = { new Ride(15, 3), new Ride(10, 5), new Ride(20, 7), new Ride(20, 10) };
            cabInvoice.AddRides("Ride2", rides);
            var generator = cabInvoice.UserInvoice("Ride2");
            Console.WriteLine("TotalFare: " + generator.TotalFare + "\nNumberOfRides: " + generator.NoOfRides + "\nAverage Fare: " + generator.AvgFare);
        }
    }
}