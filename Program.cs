using System;

namespace Lecture02Exercise01
{
    class MainClass
    {
        static void Main(string[] args)
        // method printing text
        {
            Console.WriteLine("Welcome to my first program");
            Console.WriteLine("I am going to build the best calculator in the world\n");

            Console.WriteLine("Choose 1 to add numbers, 2 for devision and 3 for remainder functionality, 4 for quit:");
            int function = int.Parse(Console.ReadLine());
            if (function == 1)
            {
                MainClass.AddFourNumbers();
            }

            if (function == 1)
            {
                MainClass.DivideVals();
            }

            if (function == 1)
            {
                MainClass.GetRemainder();
            }

            if (function == 4)
            {
                Console.WriteLine("Thank you for using my Application.");
                Console.WriteLine("See you next time.");
            }
        }

        public static void AddFourNumbers()
            // method taking four decimal numbers and returning one decimal
        {
            Console.WriteLine("Now I will add four decimals.");


            Console.WriteLine("Please type first decimal.");
            double dec1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please type second decimal.");
            double dec2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please type third decimal.");
            double dec3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please type fourth  decimal.");
            double dec4 = double.Parse(Console.ReadLine());

            double result = dec1 + dec2 + dec3 + dec4;
            Console.WriteLine($"The result is: {result}");

            Console.WriteLine("For trying again press 1.");
            int again = int.Parse(Console.ReadLine());
            if (again == 1)
            {
                Main(null);
            }

        }

        
        public static void DivideVals()
            // method accepting two decimal values as parameters and returning devision value
        {
            Console.WriteLine("Now I will divide two numbers.");


            Console.WriteLine("Please type first decimal.");
            double dec1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please type second decimal.");
            double dec2 = double.Parse(Console.ReadLine());

            double result = dec1 / dec2;
            Console.WriteLine($"The result is: {result}");

            Console.WriteLine("For trying again press 1.");
            int again = int.Parse(Console.ReadLine());
            if (again == 1)
            {
                Main(null);
            }
        }

        
        public static void GetRemainder()
            // method accepting two decimal values as parameters and returning devision value
        {
            Console.WriteLine("Now I will give you the reminder of two numbers.");

            Console.WriteLine("Please type first decimal.");
            double dec1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please type second decimal.");
            double dec2 = double.Parse(Console.ReadLine());

            double result = dec1 % dec2;
            Console.WriteLine($"The remainder is: {result}");

            Console.WriteLine("For trying again press 1.");
            int again = int.Parse(Console.ReadLine());
            if (again == 1)
            {
                Main(null);
            }
        }
        
    }
}
