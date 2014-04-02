using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partitionApp
{
    class Program
    {
        static void Main(String[] args)
        {
            Partitioner partitioner = new Partitioner();
            int numValue = -1;
            bool repeat = true;

            while (repeat == true)
            {
                Console.WriteLine("Enter a positive int number: ");
                string input = Console.ReadLine();

                try
                {
                    numValue = Convert.ToInt32(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input string is not a sequence of digits.");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The number cannot fit in an Int32.");
                }
                finally
                {
                    if (numValue < Int32.MaxValue)
                    {
                        partitioner.partition(numValue, numValue, "");
                        Console.WriteLine("number of lines:" + partitioner.numberOfPartitions);
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid number");
                    }
                }

                Console.WriteLine("Go again? Y/N");
                string go = Console.ReadLine();
                if (go == "Y" || go == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }
        }
    }
}
