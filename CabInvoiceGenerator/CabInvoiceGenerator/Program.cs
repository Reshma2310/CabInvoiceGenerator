using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter distance you want to Ride");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time of your journey in minutes");
            int time = Convert.ToInt32(Console.ReadLine());
            InvoiceGenerator cabInvoice = new InvoiceGenerator(distance, time);
            double fare = cabInvoice.CalculateFare();
            Console.WriteLine("Total Fare is: " + fare);
        }
    }
}