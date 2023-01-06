using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenrator
{
    public class InvoiceDetails
    {
        public int TotalNumberOfRides { get; set; }
        public double TotalFare { get; set; }
        public double AverageFarePerRide { get; set; }
        public void CalculateAvergaeFare()
        {
            this.AverageFarePerRide = this.TotalFare / this.TotalNumberOfRides;
        } 
    }
}
