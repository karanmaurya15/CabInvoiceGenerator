using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenrator
{
    public class InvoiceGenratorcs
    {
        public double distance;
        public int time;
        public const int costPerKm = 10;
        public const int costPerMin = 1;
        public const int minimumFare = 5;
        public  double  CalculateCabFare(double distance, int time)
        {
            double totalFare = (distance * costPerKm) + (time * costPerMin);
            if (totalFare < minimumFare)
            {
                return minimumFare;
            }
            return totalFare;
        }
        public double CalculateCabFare(Rides[] ride)
        {
            double totalFare = 0;
            foreach (var data in ride)
            {
                totalFare += this.CalculateCabFare(data.distance, data.time);
            }
            return totalFare;
        }
        public InvoiceDetails CalculateInvoiceSummary(Rides[] ride)
        {
            double totalFare = this.CalculateCabFare(ride);
            InvoiceDetails summary = new InvoiceDetails();
            summary.TotalFare = totalFare;
            summary.TotalNumberOfRides = ride.Count();
            summary.CalculateAvergaeFare();
            return summary;
        }
    }
}

