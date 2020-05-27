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
                Console.WriteLine("****************\n");

                /*
                 Ask user to enter the number of month.
                Read the value and write the amount of days in this month.
                 */
                Console.WriteLine("Enter the number of the month");
                int month = Convert.ToInt32(Console.ReadLine());
                var year = DateTime.Today.ToString("yyyy");
                double currentYear = Convert.ToDouble(year);
                int ammount;

                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 11)
                {
                    ammount = 31;
                }
                else if (month == 2)
                {
                    if (currentYear % 4 == 0 && (currentYear % 100 != 0 || currentYear % 400 == 0))
                        ammount = 29;
                    else
                        ammount = 28;
                }
                else
                {
                    ammount = 30;
                }

                Console.WriteLine(ammount);
                Console.WriteLine("****************\n");

                /*
                 Input 10 integer numbers.
                Calculate the sum of first 5 elements if they are positive or product of last 5 element in  the other case.
                 */
                int[] nums = new int[10];

                for(int i=0; i<10; i++)
                {
                    Console.WriteLine($"Enter the number {i}");
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }

                int sum = 0;
                int prod =1;

                

                foreach(int x in nums)
                {
                    if (nums[x] > 0)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            sum = 0;
                            while (nums[i] > 0)
                            {
                                sum = sum + nums[i];
                            }
                        }
                    }
                    Console.WriteLine(x);
                    if ()
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
