using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public enum RideType { NORMAL, PREMIUM }
    public class InvoiceGenerator
    {
        private readonly double MINIMUM_COST_PER_KM = 10;
        private readonly int COST_PER_MINUTE = 1;
        private readonly double MINIMUM_FARE = 5;
        public InvoiceGenerator(RideType rideType)
        {
            try
            {
                if (rideType.Equals(RideType.NORMAL))
                {
                    this.MINIMUM_COST_PER_KM = 10;
                    this.COST_PER_MINUTE = 1;
                    this.MINIMUM_FARE = 5;
                }
                if (rideType.Equals(RideType.PREMIUM))
                {
                    this.MINIMUM_COST_PER_KM = 15;
                    this.COST_PER_MINUTE = 2;
                    this.MINIMUM_FARE = 20;
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDE_TYPE, "Invalid Ride Type");
            }
        }
        public double distance;
        public int time;
        public double CalculateFare(Ride ride)
        {
            double TotalFare = 0;
            if (ride.distance >= 0 && ride.time >= 0)
            {
                TotalFare = ride.distance * MINIMUM_COST_PER_KM + ride.time * COST_PER_MINUTE;
            }
            else
            {
                if (ride.distance <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_DISTANCE, "Invalid Distance");
                }
                if (ride.time < 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_TIME, "Invalid Time");
                }
            }
            return Math.Max(TotalFare, MINIMUM_FARE);
        }
        public EnhancedInvoiceClass MultipleRides(Ride[] rides)
        {
            double TotalFare = 0;
            try
            {
                foreach (var ride in rides)
                {
                    TotalFare += CalculateFare(ride);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "Rides Are Null");
            }
            return new EnhancedInvoiceClass(rides.Length, TotalFare);
        }
    }
    
    /*public class InvoiceGenerator
    {
        
        public InvoiceGenerator(RideType rideType)
        {
            
        }
        public double CalculateFare(Ride ride)
        {
            double totalFare = 0;
            if (ride.distance >= 0 && ride.time >= 0)
            {
                totalFare = ride.distance * MINIMUM_COST_PER_KM + ride.time * COST_PER_TIME;
            }
            else
            {
                if (ride.distance <= 0)
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_DISTANCE, "Invalid Distance");
                }
                if (ride.time < 0)
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_TIME, "Invalid Time");
                }
            }
            return Math.Max(totalFare, MINIMUM_FARE);
        }
        public EnhancedInvoice MultipleRides(Ride[] rides)
        {
            double totalFare = 0;
            try
            {
                foreach (var ride in rides)
                {
                    totalFare += CalculateFare(ride);
                }
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_RIDES, "Rides Are Null");
            }
            return new EnhancedInvoice(rides.Length, totalFare);
        }

    }*/
}
