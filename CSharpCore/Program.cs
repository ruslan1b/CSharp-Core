﻿using System;


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
                    Console.ForegroundColor = ConsoleColor.White;
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

                        case "T2":
                            Task2 task2 = new Task2();
                            task2.DemoTask2();
                            break;

                        case "T3":
                            Task3 task3 = new Task3();
                            task3.DemoTask3();
                            break;

                        case "T71":
                            Task7_1 task7_1 = new Task7_1();
                            task7_1.DemoTask7_1();
                            break;

                        case "T72":
                            Task7_2 task7_2 = new Task7_2();
                            task7_2.DemoTask7_2();
                            break;

                        case "T9":
                            Task9 task9 = new Task9();
                            task9.DemoTask9();
                            break;

                        case "H1":
                            Homework1 homework1 = new Homework1();
                            homework1.DemoHomework1();
                            break;

                        case "H3":
                            Homework3 homework3 = new Homework3();
                            homework3.DemoHomework3();
                            break;

                        case "H4":
                            Homework4 homework4 = new Homework4();
                            homework4.DemoHomework4();
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
