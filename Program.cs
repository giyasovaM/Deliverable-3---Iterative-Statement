/*
 * Author: Madina Giyasova
 * Date: 01/30/2023
 * Description: Deliverable 3 - Iterative Statement
 * 
 * 
 */

using System;
namespace Deliverable__3_;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integral number between 1 and 100: ");
        try
        {
            int input = int.Parse(Console.ReadLine());

            Console.Write("Specify the series tye: Even or Odd ");
            string series = Console.ReadLine();

            if (series == "Odd")
            {
                Console.Write("You have selected " + series + " series. The number between 0 and " + input + " are:");
                for (int i = 1; i < input; i = i + 2)
                {
                    Console.WriteLine(i);

                }
            }
            if (series == "Even")
            {
                Console.Write("You have selected " + series + " series. The number between 0 and " + input + " are:");
                for (int i = 0; i < input; i = i + 2)
                {
                    Console.WriteLine(i);

                }
            }
        }

        catch
        {
            Console.WriteLine("Enter in a numeric value");
        }



    }
}

