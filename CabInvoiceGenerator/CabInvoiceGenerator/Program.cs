using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ride[] ride = { new Ride(20, 7), new Ride(10, 5) };
            InvoiceGenerator cabInvoice = new InvoiceGenerator();
            double fare = cabInvoice.MultipleRides(ride);            
        }
    }
}