using System;
using Task1;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                Define integer variables a and b.
                Read values a and b from Console and calculate: a+b, a-b, a*b, a/b.
                Output obtained results.
                 */
                Console.WriteLine("Enter value tasks or homeworks in patern: T1 or H2");                
                string answer = Console.ReadLine();

                switch(answer)
                {
                    case "T1":
                        Task1 demo = new Task1();
                        demo.DemoTask1();
                        break;
                    //case "T2":
                    //    Task2 demo = new Task2();
                    //    demo.DemoTask2();
                    //    break;

                    //case "H1":
                    //    Homework2 demo = new Homework2();
                    //    demo.DemoHomework2();
                    //    break;
                }
                

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
