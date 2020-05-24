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
                Define integer variable a.
                Read the value of a from console and calculate area and perimetr of square with length a.
                Output obtained results
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
                 Define string variable name and integer value age.
                Output question "What is your name?";
                Read the value name and output next question: "How old are you,(name)?".
                Read age and write whole information. 
                 */
                Console.WriteLine("How are you?");
                string answer = Console.ReadLine();
                Console.WriteLine($"You are {answer}");

                /*
                 Read double number r and calculate the length (l=2*pi*r),
                area (S=pi*r*r) and volume (4/3*pi*r*r*r) of a circle of given r 2. 
 
                 */
                Console.WriteLine(" Enter three type char values");

                Console.WriteLine("Enter first value:");
                char numberChar1 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter second value:");
                char numberChar2 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter third value:");
                char numberChar3 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine($"You enter: {numberChar1}, {numberChar2}, {numberChar3}");

                
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
