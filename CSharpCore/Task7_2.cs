using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    class Task7_2
    {
        public void DemoTask7_2()
        {
            try
            {
                /*
                Create method Div(), which calculates the dividing of two int numbers.
                In Main read  two int numbers and call this method.
                Catch appropriative exceptions.
                Throwing exception if dividing of two double numbers.
                 */
                try
                {
                    Console.WriteLine($"Input first number.");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Input second number.");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());
                    Div(firstNumber, secondNumber);
                    
                    Console.WriteLine("****************\n");

                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("EXEPTION:\n");
                    throw;
                }
                /*
                 Write a method ReadNumber(int start, int end),
                which reads from Console  integer numbers and returns it,
                if it is in the range [start...end]. If an invalid number or non-number text is read,
                the method should throw an exception. Using this method write a method Main(),
                that has to enter 10 numbers:
		        a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100

                 */
                Console.WriteLine($"Input start number.");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Input end number.");
                int end = Convert.ToInt32(Console.ReadLine());
                ReadNumber(start, end);

                Console.WriteLine("****************\n");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int Div(int _firstNumber, int _secondNumber)
        {

            return _firstNumber / _secondNumber;            
        }

        public void ReadNumber(int start, int end)
        {
            try
            {
                if (start == end)
                    throw new Exception("The beginning and end of the range cannot be the same number");
                if (start > end)
                    throw new Exception("The end of the range cannot be less than the beginning");
                if (end-start < 10)
                    throw new Exception("The end of the range must be at least 10 digits larger than the beginning");
                
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ERROR: {e.Message}");
            }
            
        }
    }
}

