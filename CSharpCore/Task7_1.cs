using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    class Task7_1
    {
        public void DemoTask7_1()
        {
            try
            {
                /*
                Create method Div(), which calculates the dividing of two int numbers.
                In Main read  two int numbers and call this method.
                Catch appropriative exceptions.
                Throwing exception if dividing of two double numbers.
                 */
                
                /*
                 Write a method ReadNumber(int start, int end),
                which reads from Console  integer numbers and returns it,
                if it is in the range [start...end]. If an invalid number or non-number text is read,
                the method should throw an exception. Using this method write a method Main(),
                that has to enter 10 numbers:
		        a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100

                 */
                


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AnnType()
        {
            var student = new
            {
                Id = 1,
                FirstName = "Jonn",
                LastName = "Lenon",
                Lists = new List<string> {                    }

            };
        }
    }
}
