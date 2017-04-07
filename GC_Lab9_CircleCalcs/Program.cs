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
            int radius = 0;
            Console.WriteLine("Welcome to the Circle Tester!");
            Console.Write("Enter radius: ");
            
            try
            {
                radius = int.Parse(Console.ReadLine());
                if (radius <= 0)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You did not put in a number! Please try again.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("You did not put in a number larger than 0! Please try again.");
            }
            Circle round = new Circle(radius);

            Console.WriteLine("Circumference: " + round.GetFormattedCircumference());
            Console.WriteLine("Area: " + round.GetFormattedArea());
            Console.ReadLine();
        }

        }
    }

