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
                    Console.WriteLine("Enter value tasks or homeworks in patern: T1 or H2");
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
                            Console.WriteLine("This value was not found or not corect");
                            flag = true;
                            break;
                    }
                }
                

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
