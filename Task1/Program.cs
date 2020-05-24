using System;


namespace CSharpCore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                SoftServe C# Core OOP Course: Tasks and Homework
                 */
                bool flag = true;
                while (flag) {
                    Console.WriteLine("Enter value tasks or homeworks in patern: T1 or H3" +
                        " from list: T1, T2, T3, H1, H3, H4");
                    string answer = Console.ReadLine();

                    switch (answer)
                    {
                        case "T1":
                            Task1 task1 = new Task1();
                            task1.DemoTask1();
                            flag = false;
                            break;
                        //case "T2":
                        //    Task2 demo = new Task2();
                        //    demo.DemoTask2();
                        //    break;

                        case "H1":
                            Homework1 homework1 = new Homework1();
                            homework1.DemoHomework1();
                            break;
                        default:
                            flag = true;
                            Console.WriteLine("This value was not found or not corect");
                            Console.WriteLine("Or press <ESC> to exit...");
                            break;
                    }
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                        break;
                }
                

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
