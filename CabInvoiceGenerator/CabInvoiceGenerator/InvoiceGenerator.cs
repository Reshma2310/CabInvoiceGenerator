using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        private readonly double MINIMUM_COST_PER_KM = 10;
        private readonly int COST_PER_MINUTE = 1;
        private readonly double MINIMUM_FARE = 5;
        public double distance;
        public double time;
        public InvoiceGenerator(double distance, double time)
        {
            this.distance = distance;
            this.time = time;
        }
        public double CalculateFare()
        {
            double totalFare = 0;
            if (distance >= 0 && time >= 0)
            {
                totalFare = distance * MINIMUM_COST_PER_KM + time * COST_PER_MINUTE;
            }
            else
            {
                if (distance <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_DISTANCE, "Distance is Invalid");
                }
                if (time < 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_TIME, "Invalid Time");
                }
            }
            return totalFare;
        }
    }
}
