using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    class Homework3
    {
        public void DemoHomework3()
        {
            try
            {
                /*
                Read the text as a string value and calculate the counts of characters 'a', 'o', 'i', 'e' in this text.
                 */
                Console.WriteLine("Enter same text");
                string sameText = Console.ReadLine();

                int count = 0;
                foreach (char ch in sameText)
                {                 
                    if (ch == 'a' || ch == 'o' || ch == 'i' || ch == 'e')
                        count++;
                }

                Console.WriteLine($"Count characters in the text: {count}");

                /*
                 Ask user to enter the number of month.
                Read the value and write the amount of days in this month.
                 */
                

                /*
                 Input 10 integer numbers.
                Calculate the sum of first 5 elements if they are positive or product of last 5 element in  the other case.
                 */
                


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
