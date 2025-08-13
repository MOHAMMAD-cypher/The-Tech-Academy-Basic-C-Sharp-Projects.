using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt for package weight
            Console.WriteLine("Please enter the package weight:");
            string weightInput = Console.ReadLine(); // Read user input for weight
            double weight = Convert.ToDouble(weightInput); // Convert input to a number

            // Check if weight exceeds the limit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program
            }

            // Prompt for package width
            Console.WriteLine("Please enter the package width:");
            string widthInput = Console.ReadLine(); // Read user input for width
            double width = Convert.ToDouble(widthInput); // Convert input to a number

            // Prompt for package height
            Console.WriteLine("Please enter the package height:");
            string heightInput = Console.ReadLine(); // Read user input for height
            double height = Convert.ToDouble(heightInput); // Convert input to a number

            // Prompt for package length
            Console.WriteLine("Please enter the package length:");
            string lengthInput = Console.ReadLine(); // Read user input for length
            double length = Convert.ToDouble(lengthInput); // Convert input to a number

            // Calculate total dimensions
            double dimensionTotal = width + height + length;

            // Check if dimensions exceed the limit
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program
            }

            // Calculate quote using formula: (width * height * length * weight) / 100
            double quote = (width * height * length * weight) / 100;

            // Display the quote formatted as currency
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thank you!");
        }
    }
}
