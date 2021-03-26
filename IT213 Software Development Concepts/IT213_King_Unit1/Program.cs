using System;

namespace IT213_KingJeremy_Unit1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit 1 Project --- Name and Tuition \n\n");

            // Initialize Variables

            string name = "John Smith";
            string address = "101 N. Main Street";
            string city = "AnyTown";
            string state = "TX";
            string zipCode = "11111";
            String unitsTaken = "19";

            const double pricePerUnit = 100.50;
            const double discount = 150;

            // Processing

            int intUnitsTaken = Convert.ToInt32(unitsTaken);
            intUnitsTaken++; //accumulator

            double tuition = pricePerUnit * intUnitsTaken;
            double afterDiscount = tuition - discount;
            double monthlyPayment = afterDiscount / 12;

            // Display Results

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Zip Code: " + zipCode);

            Console.WriteLine("The number of units taken is: " + intUnitsTaken);
            Console.WriteLine(string.Format("The tuition before discount is {0:C}", tuition));
            Console.WriteLine(string.Format("The tuition after discount is {0:C}", afterDiscount));
            Console.WriteLine(string.Format("Your monthly payment is: {0:C}", monthlyPayment));

            // End of Program
            Console.Read();
        }
    }
}