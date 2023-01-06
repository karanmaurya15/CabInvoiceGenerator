using CabInvoiceGenrator;

namespace CabInvoiceGeneratorTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void GivenDistanceAndTime_WhenCalculate_ShouldReturnTotalFare()
        {
            InvoiceGenratorcs invoice = new InvoiceGenratorcs();
            double result = invoice.CalculateCabFare(5.0, 2);
            double expected = 52;
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void GivenMultipleRides_WhenCalculate_ShouldReturnTotalFare()
        {
            Rides[] rides = { new Rides(7.0, 3), new Rides(6.5, 4) };
            InvoiceGenratorcs invoice = new InvoiceGenratorcs();
            double result = invoice.CalculateCabFare(rides);
            double expected = 142;
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void GivenSummary_WhenCalculate_ShouldReturnAverageFare()
        {
            Rides[] rides = { new Rides(7.0, 3), new Rides(6.5, 4) };
            InvoiceGenratorcs invoice = new InvoiceGenratorcs();
            InvoiceDetails summary = new InvoiceDetails();
            InvoiceDetails result = invoice.CalculateInvoiceSummary(rides);
            summary.TotalFare = 142;
            summary.TotalNumberOfRides = 2;
            summary.CalculateAvergaeFare();
            if (result.TotalFare == summary.TotalFare && result.TotalNumberOfRides == summary.TotalNumberOfRides && result.AverageFarePerRide == summary.AverageFarePerRide)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}