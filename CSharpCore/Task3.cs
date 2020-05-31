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
                Console.WriteLine("Input a and b are two integers.\n");
                Console.WriteLine("Enter first number\n");
                int firstNumber = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Enter second number\n");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                int volume = secondNumber - firstNumber + 1;
                int[] sample = new int[volume];
                
                for(int i=0; i<sample.Length;i++)
                {
                    sample[i] = i;
                }

                int countNumber = 0;

                foreach (int x in sample)
                {
                    if (x%3 ==0)                    
                        countNumber++;                    
                }

                Console.WriteLine($"In range [{firstNumber}..{secondNumber}] is {countNumber} number are divided by 3 without remainder.");
                Console.WriteLine("****************\n");

                /*
                 Input a character string. Print each second character
                 */
                Console.WriteLine("Enter same text");
                string sameText = Console.ReadLine();               

                for (int i= 0;i< sameText.Length;i++)
                {                    
                    if ((i + 1) % 2 == 0)
                    {
                        Console.WriteLine($"{sameText[i]}");                        

                    }                    
                }             
                
                Console.WriteLine("****************\n");

                /*                 
                Input the name of the drink (coffee, tea, juice, water).
                Print the name of the drink and its price
                 */
                Console.WriteLine("Input the name of the drink (coffee, tea, juice, water).\n");
                string namedrink = Console.ReadLine();

                switch(namedrink)
                {
                    case "coffee":
                        Console.WriteLine($" Price of {namedrink}: 35 hrn.");
                        break;
                    case "tea":
                        Console.WriteLine($" Price of {namedrink}: 15 hrn.");
                        break;
                    case "juice":
                        Console.WriteLine($" Price of {namedrink}: 40 hrn.");
                        break;
                    case "water":
                        Console.WriteLine($" Price of {namedrink}: 5 hrn.");
                        break;
                    default:
                        Console.WriteLine($" Name drink {namedrink} isn't correct.");
                        break;
                }

                Console.WriteLine("****************\n");

                /*
                 Input a sequence of positive integers (to the first negative).
                Calculate the arithmetic average of the entered numbers.

                */
                Console.WriteLine("Input a sequence of positive integers (to the first negative).\n");
                Console.WriteLine("How much numbets do you need enter?.\n");
                int count = Convert.ToInt32( Console.ReadLine());
                bool flag = true;
                int[] nums = new int[count];
                int index = 0;

                while (flag)
                {
                    if (index < count)
                    {
                        Console.WriteLine("Input number\n");
                        int num = Convert.ToInt32(Console.ReadLine());

                        nums[index] = num;
                        index++;

                        //Console.WriteLine($"{nums[index]}\n");
                    }
                    else
                        flag = false;
                }

                int sumNumber = 0;
                
                foreach (int x in nums)
                {
                    sumNumber += x;
                    Console.WriteLine($"{sumNumber}\n");
                }

                double res = Convert.ToDouble( sumNumber / count);
                Console.WriteLine($"Arithmetic average of the entered numbers is: {res}\n");
                Console.WriteLine("****************\n");

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

                Console.WriteLine("Input integer number.\n");
                
                string numberInt = Console.ReadLine();
                int sumNumberInt = 0;
               
                foreach (int x in numberInt)
                {
                    sumNumberInt += Convert.ToInt32(x);
                }

                Console.WriteLine($"The sum entered integer number is: {sumNumberInt}\n");
                Console.WriteLine("****************\n");

                /*
                 Check whether the entered integer number contains only odd numbers
                */
                Console.WriteLine("Input integer number.\n");

                string numberIntCheckOdd = Console.ReadLine();
                

                foreach (int x in numberInt)
                {
                    sumNumberInt += Convert.ToInt32(x);
                }

                Console.WriteLine($"The sum entered integer number is: {sumNumberInt}\n");
                Console.WriteLine("****************\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
