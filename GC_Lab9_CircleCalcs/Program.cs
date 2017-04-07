using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab9_CircleCalcs
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 0;
            double numberOfCircles = 0;
            Console.WriteLine("Welcome to the Circle Tester!");
            bool tryInput = true;
            bool run = true;
            while (run)
            {
                while (tryInput)
                {
                    tryInput = false;
                    Console.Write("Enter radius: ");
                    try
                    {
                        radius = double.Parse(Console.ReadLine());
                        if (radius <= 0)
                        {
                            throw new IndexOutOfRangeException();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You did not put in a number! Please try again.");
                        tryInput = true;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("You did not put in a number larger than 0! Please try again.");
                        tryInput = true;
                    }
                }
                Circle round = new Circle(radius);                
                round.PrintCircumference();
                round.PrintArea();
                tryInput = true;
                numberOfCircles++;
                run = Continue();
                if (run == false)
                {
                    Console.WriteLine("Goodbye! You created " + round.Format(numberOfCircles) + " circles.");
                }
            }
            Console.ReadLine();           
          }

        public static Boolean Continue()
        {
            Console.Write("\nDo you want to calculate another area and circumference? (y/n): ");
            string input = Console.ReadLine();
            Boolean run = true;
            input = input.ToLower();

            if (input == "n")
            {               
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
                run = Continue();
            }
            return run;
        }
    }
    }

