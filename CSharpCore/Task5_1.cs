using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    class Task5_1
    {
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

            }
        }

        class Plane : IFlyable
        {
            string mark;
            int highFly;

            public int Fly()
            {

            }

        }


    }

    
    
}
