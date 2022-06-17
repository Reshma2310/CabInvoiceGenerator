using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class EnhancedInvoiceClass
    {
        public double NoOfRides;
        public double TotalFare;
        public double AvgFare;
        public EnhancedInvoiceClass(double NoOfRides, double TotalFare)
        {
            this.NoOfRides = NoOfRides;
            this.TotalFare = TotalFare;
            this.AvgFare = this.TotalFare / this.NoOfRides;
        }
    }
}
