using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();

            if (int.TryParse(userNumber, out int num))
            {
                if (num == 0)
                {
                    // exit the loop when the user enters 0
                    break; 
                }
                    // add the number to the list
                numbers.Add(num); 
            }
            else
            {
                // if nan is given
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        if (numbers.Count > 0)
        {
            // sum of the numbers
            int sum = numbers.Sum();
            Console.WriteLine($"The sum of the numbers is: {sum}");

            // average of the numbers
            double average = numbers.Average();
            Console.WriteLine($"The average of the numbers is: {average}");

            // find the maximum number
            int max = numbers.Max();
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            // if no numbers were entered
            Console.WriteLine("No numbers were entered.");
        }
       
    }
}