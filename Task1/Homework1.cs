using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    class Homework1
    {
        public void DemoHomework1()
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
                Console.WriteLine(" Enter three type char values");

                Console.WriteLine("Enter first value:");
                char numberChar1 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter second value:");
                char numberChar2 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter third value:");
                char numberChar3 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine($"You enter: {numberChar1}, {numberChar2}, {numberChar3}");

                /*
                 Enter 2 integer numbers.
                Check if they are both positive – use bool expression
                 */
                Console.WriteLine(" Enter two type int values");

                Console.WriteLine("Enter first value:");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second value:");
                int number2 = Convert.ToInt32(Console.ReadLine());
                if (number1 > 0 && number2 > 0)
                {
                    Console.WriteLine("Two numbers are poitive");
                }
                else
                {
                    Console.WriteLine("One fron number or both are negativ");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
