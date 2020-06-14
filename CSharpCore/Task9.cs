using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpCore
{
    class Task9
    {
        public void DemoTask9()
        {
            /*
             Create a collection of 10 integers numders
            Get and display only negative numbers on the console
            Get and display only positive numbers on the console
            Get the largest and smallest elements from the array,
            and find the sum of all elements of the array.
            Get the first largest element in array 
            that is smaller than the Average of elements in array 
            Sort the array using OrderBy
            */

            List<int> numberList = new List<int> { 13, 469, 131, 133, 77, -32, 941, -951, 751, 1004 };

            List<int> numberNegativ = new List<int>();
            List<int> numberPositive = new List<int>();
            int sum = 0;
            foreach (int x in numberList)
            {
                if (x < 0)
                    numberNegativ.Add(x);
                else
                    numberPositive.Add(x);
                sum = +x;
            }

            PrintValues(numberNegativ, '\t');
            PrintValues(numberPositive, '\t');
            Console.WriteLine("****************\n");
            
            Console.WriteLine("Max element: "+numberList.Max());
            Console.WriteLine("Min element: " + numberList.Min());
            Console.WriteLine("Sum all elements: " + sum);

            var average = numberList.Average();

            var smaller = from n in numberList
                          where n < average
                          orderby n
                          select n;
            Console.WriteLine("Find element: " + smaller.Max());
        }

        public static void PrintValues(IEnumerable myList, char mySeparator)
        {
            foreach (Object obj in myList)
                Console.Write("{0}{1}", mySeparator, obj);
            Console.WriteLine();
        }        
    }
}
