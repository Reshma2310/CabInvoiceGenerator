using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            InvoiceGenerator cabInvoice = new InvoiceGenerator(RideType.PREMIUM);
            double distance = 15;
            int time = 10;
            Ride ride = new Ride(distance, time);
            double result = cabInvoice.CalculateFare(ride);
            Console.WriteLine("Total Fare: " + result);
        }
    }
}