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
            bool tryInput = true;
            bool run = true;
            double radius = 0;
            double numberOfCircles = 0;

            Console.WriteLine("Welcome to the Circle Tester!");
           
            //This loop runs until the Continue method returns a false value for run.
            while (run)
            {
                //This loop runs until a valid value for the radius (any humber > 0).
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
                //Instaniate a Circle object using the user's radius
                Circle round = new Circle(radius); 
                                               
                round.PrintCircumference();
                round.PrintArea();
                tryInput = true;

                //Add one to the numberOfCircles counter so the correct value can be
                //passed to the Format method if user wants to quit

                numberOfCircles++;
                run = Continue();
                if (run == false)
                {
                    Console.WriteLine("Goodbye! You created " + round.Format(numberOfCircles) + " circles.");
                }
            }
            Console.ReadLine();           
          }
        
        //This method allows the user to repeat the circle calculator ad infinitium.

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

