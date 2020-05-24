using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    class Task2
    {
        enum TestCaseStatus { Pass, Fail, Blocked, Wp, Unexecuted };

        public void DemoTask2()
        {
            try
            {
                /*
                Identify enum TestCaseStatus (Pass, Fail, Blocked, WP, Unexecuted).
                Assign status “Pass” for the variable  test1Status and print the value of the variable console.
                 */
                var test1Status = TestCaseStatus.Pass;
                Console.WriteLine(test1Status);

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
                 Determine RGB structure that represents the color with fields red, green, blue (type byte).
                Identify two variables of this type and enter their fields for white and black colors.
 
                 */
                Console.WriteLine("How are you?");
                string answer = Console.ReadLine();
                Console.WriteLine($"You are {answer}");

                /*                 
                In method Main() write code for solving next task:
                read number of HTTP Error (400, 401,402, ...) and write the name of this error (Declare enum HTTPError)
                declare struct Dog with fields Name, Mark, Age.
                Declare variable myDog of Dog type and read values for it.
                Output myDos into console.
                (Declare method ToString in struct)
 
                 */
                Console.WriteLine(" Enter three type char values");

                Console.WriteLine("Enter first value:");
                char numberChar1 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter second value:");
                char numberChar2 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter third value:");
                char numberChar3 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine($"You enter: {numberChar1}, {numberChar2}, {numberChar3}");            

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
