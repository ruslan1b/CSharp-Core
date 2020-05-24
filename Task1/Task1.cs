using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Task1
    {
        public void DemoTask1()
        {
            try
            {
                /*
                Define integer variables a and b.
                Read values a and b from Console and calculate: a+b, a-b, a*b, a/b.
                Output obtained results.
                 */
                Console.WriteLine("Enter value a");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value b");
                int b = Convert.ToInt32(Console.ReadLine());

                int sum = a + b;
                Console.WriteLine($"sum: {sum}");
                int sub = a - b;
                Console.WriteLine($"sub: {sub}");
                int mul = a * b;
                Console.WriteLine($"mul: {mul}");

                if (b > 0)
                {
                    int div = a / b;
                    Console.WriteLine($"div: {mul}");
                }
                else
                    Console.WriteLine("Сannot be divided by 0!");

                /*
                 Output question “How are you?“.
                Define string variable answer.
                Read the value answer and output: “You are (answer)". 
                 */
                Console.WriteLine("How are you?");
                string answer = Console.ReadLine();
                Console.WriteLine($"You are {answer}");

                /*
                 Read 3 variables of char type. Write message: “You enter (first char), (second char), (3 char)” 
                 */


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
