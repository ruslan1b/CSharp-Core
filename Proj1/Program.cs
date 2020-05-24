using System;

namespace Task2
{
    class Program
    {
        enum TestCaseStatus { Pass, Fail, Blocked, Wp, Unexecuted };



        static void Main(string[] args)
        {
            var test1Status =  TestCaseStatus.Pass;
            Console.WriteLine(test1Status);
        }
    }
}
