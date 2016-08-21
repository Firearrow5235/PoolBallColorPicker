using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolBallColorPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            String[] colors = new string[] { "Yellow", "Blue", "Red", "Purple", "Orange", "Green", "Maroon" };
            string input;
            short number;

            Console.Write("Enter a ball number: ");

            input = Console.ReadLine();

            while (running)
            {
                try
                {
                    number = Int16.Parse(input);

                    if (number > 15 || number < 1)
                    {
                        Console.WriteLine("A ball by that number does not exist.");
                    }
                    else if (number < 8)
                    {
                        Console.WriteLine("The " + number + " ball is: " + colors[number - 1]);
                    }
                    else if (number > 8)
                    {
                        Console.WriteLine("The " + number + " ball is: " + colors[number - 9] + "-White");
                    }
                    else
                    {
                        Console.WriteLine("The " + number + " ball is: Black");
                    }
                }
                catch (FormatException)
                {
                    if (input.ToLower() == "r" )
                    {
                        Random rand = new Random();
                        number = (short)rand.Next(1, 15);

                        Console.Write("(Random) ");

                        if (number < 8)
                        {
                            Console.WriteLine("The " + number + " ball is: " + colors[number - 1]);
                        }
                        else if (number > 8)
                        {
                            Console.WriteLine("The " + number + " ball is: " + colors[number - 9] + "-White");
                        }
                        else
                        {
                            Console.WriteLine("The " + number + " ball is: Black");
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Input is not a number.");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is invalid");
                }                  

                Console.Write("Enter another number or hit 'Enter' to quit: ");

                input = Console.ReadLine();

                if (input == "") 
                {
                    running = false;
                }
            }
        }
    }
}
