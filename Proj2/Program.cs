using System;

namespace Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car Ford = new Car();
                Ford.Input();
                Ford.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            
        }
    }    
}
