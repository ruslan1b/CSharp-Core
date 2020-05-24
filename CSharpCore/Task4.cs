using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    class Task4
    {
        class Car
        {
            public string name, color;
            public double price;
            private const string CompanyName = "ChernivtsiCar";


            public string Color
            {
                get { return color; }
                set { color = value; }
            }

            public Car()
            {

            }

            public Car(string _name, string _color, double _price)
            {
                _name = name;
                _color = color;
                _price = price;
            }

            public void Input()
            {
                //public object[] = {name,color,price};


                Console.WriteLine("Enter car name");
                name = Console.ReadLine();
                Console.WriteLine("Enter car color");
                color = Console.ReadLine();
                Console.WriteLine("Enter car price");
                price = Convert.ToDouble(Console.ReadLine());

            }

            public void Print()
            {
                Console.WriteLine($"Car name:{name}, color:{color}, price{price}");
            }

            public double ChangePrice(double new_price)
            {
                new_price = price;
                double old_price = 5;
                double change = (price * 100) / old_price;
                return change;
            }
        }
        Car Ford = new Car();
        Ford.Input();
                Ford.Print();
    }
}
