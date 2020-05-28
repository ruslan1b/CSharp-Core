using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    class Task3
    {
        public void DemoTask3()
        {
            try
            {
                /*
                Input a and b are two integers.
                Calculate how many integers in the range [a..b] are divided by 3 without remainder
                 */

                Console.WriteLine("****************\n");

                /*
                 Input a character string. Print each second character
                 */
                Console.WriteLine("Enter same text");
                string sameText = Console.ReadLine();

                //int count = 0;
                //foreach (char ch in sameText)
                //{
                //    if (count%2!=0)
                //        Console.WriteLine($"Count characters in the text: {sameText[ch]}");
                //    count++;
                //}

                for (int i= 0;i< sameText.Length;i++)
                {
                    if (sameText[i] % 2 == 0)
                        Console.WriteLine($"Count characters in the text: {sameText[i]}");
                    //count++;
                }

                
                
                Console.WriteLine("****************\n");

                /*                 
                Input the name of the drink (coffee, tea, juice, water).
                Print the name of the drink and its price
                 */

                Console.WriteLine("****************\n");

                /*
                 Input a sequence of positive integers (to the first negative).
                Calculate the arithmetic average of the entered numbers.

                */



                /*
                 Check whether the entered year is a leap 
                 */
                Console.WriteLine("Enter the year");
                int yearUser = Convert.ToInt32(Console.ReadLine());
                               
                if (yearUser % 4 == 0 && (yearUser % 100 != 0 || yearUser % 400 == 0))
                    Console.WriteLine($"{yearUser} is leap");
                else
                    Console.WriteLine($"{yearUser} isn't leap");

                Console.WriteLine("****************\n");

                /*
                 Find the sum of digits of the entered integer number 
                 */

                /*
                 Check whether the entered integer number contains only odd numbers
                */


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
