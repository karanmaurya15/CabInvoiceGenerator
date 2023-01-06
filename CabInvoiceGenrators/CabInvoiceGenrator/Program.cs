namespace CabInvoiceGenrator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Cab Invoice Genrator Program\n");
            InvoiceGenratorcs invoiceGenratorcs = new InvoiceGenratorcs();
            Console.WriteLine(invoiceGenratorcs.CalculateCabFare(10, 10));
            Rides[] rides = { new Rides(7.0, 3), new Rides(6.5, 4) };
            Console.WriteLine(invoiceGenratorcs.CalculateCabFare(rides));
        }
    }
}