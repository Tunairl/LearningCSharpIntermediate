using Amazon;

namespace AccessModifiers
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            // Cannot be accessed bc of internal class
            //Amazon.RateCalculator calculator = new RateCalculator();
        }
    }
}