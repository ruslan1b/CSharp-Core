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
                Console.WriteLine("Enter a length the side of the square:");
                int a = Convert.ToInt32(Console.ReadLine());

                
                int areaSquare = a * a;
                Console.WriteLine($"The area a square is: {areaSquare}");
               
                int perimetrSquare = a *4;
                Console.WriteLine($"The perimetr a square is: {perimetrSquare}");
               

                /*
                 Define string variable name and integer value age.
                Output question "What is your name?";
                Read the value name and output next question: "How old are you,(name)?".
                Read age and write whole information. 
                 */
                Console.WriteLine("What is your name?");
                string answerName = Console.ReadLine();

                Console.WriteLine($"How old are you, {answerName}?");
                int answerAge = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"You name is {answerName}");
                Console.WriteLine($"You age is {answerAge}");

                /*
                 Read double number r and calculate the length (l=2*pi*r),
                area (S=pi*r*r) and volume (4/3*pi*r*r*r) of a circle of given r 2. 
 
                 */
                Console.WriteLine(" Enter a radius of the circle");
                
                double radius = Convert.ToDouble(Console.ReadLine());

                var lenghtCircle = 2 * (Math.PI) * radius;
                var areaCircle = (Math.PI) * radius * radius;
                var volumeCircle = 4 / 3 * (Math.PI) * radius * radius * radius;                

                Console.WriteLine($"A circle of radius {radius} has: lenght: {lenghtCircle}, area: {areaCircle}, volume: {volumeCircle}");


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
