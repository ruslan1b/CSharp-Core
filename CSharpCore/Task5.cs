using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    class Task5
    {
        /*
         * Develop interface IFlyable with method Fly().
        Create two classes Bird (with fields: name and canFly) 
        and Plane  (with fields: mark and highFly) , which implement interface IFlyable.
        Create List of IFlyable objects and add some Birds and Planes to it.
        Call Fly() method for every item from the list of it. 
        */
        public interface IFlyable
        {
            int Fly();
        }

        class Bird : IFlyable
        {
            string name;
            bool canFly;
            public int Fly()
            {
                return 5;
            }
        }

        class Plane : IFlyable
        {
            string mark;
            int highFly;

            public int Fly()
            {
                return 6;
            }

        }


    }

    class Task5_2
    {
        /*
         * Develop interface IFlyable with method Fly().
        Create two classes Bird (with fields: name and canFly) and Plane  (with fields: mark and highFly) , which implement interface IFlyable.
        Create List of IFlyable objects and add some Birds and Planes to it. Call Fly() method for every item from the list of it. 

        Declare myColl of 10 integers and fill it from Console.
	        1) Find and print all positions of element -10 in the collection
	        2) Remove from collection elements, which are greater then 20.  Print collection
	        3) Insert elements 1,-3,-4 in positions 2, 8, 5. Print collection
	        4) Sort and print collection 
        Use next Collections for this tasks: List or ArrayList

         */
    }



}
