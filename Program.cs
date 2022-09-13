using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace iterativeStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try-catch block
            try
            {
                // Ask user to choose for an integer and number series
                Console.WriteLine("Please enter an integer between 1 and 100: ");
                // Assign variables
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 1 && n < 100)
                {
                    Console.WriteLine("Please choose either even or odd: ");
                    string series = Console.ReadLine();

                    //Conditional statement
                    if (series == "odd")
                    {
                        Console.WriteLine("You have selected the odd series. The numbers between 1 and " + n + " are: ");
                        for (int i = 1; i < n; i = i + 2)
                            Console.WriteLine(i);
                    }
                    else if (series == "even")
                    {
                        Console.WriteLine("You have selected the even series. The numbers between 1 and " + n + " are: ");
                        for (int i = 2; i < n; i = i + 2)
                            Console.WriteLine(i);
                    }
                    else
                    {
                        Console.WriteLine("Please enter either odd or even for chosen series.");
                        Console.ReadKey(true);
                    }
                }
                else
                {
                    Console.WriteLine("Your number is not within the range from 1 to 100. Please choose again!");
                }
            }
            catch
            {
                Console.WriteLine("Please only enter a valid integer from 1 to 100.");
                Console.ReadKey(true);
            }
        }
    }
}