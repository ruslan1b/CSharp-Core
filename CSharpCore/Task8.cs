using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    class Task8
    {
        /*
         * Add two classes Persons and Staff (use the presentation code)
        2. Create two classes Teacher and Developer, derived from Staff. 
        Add field subject for class Teacher; 
        Add field level for class Developer; 
        override method Print for both classes.
        3. In Main, specify a list of Person type and add objects of each type to it. Call for each item in the list method Print ().
        4. Enter the person's name. If this name present in  list - print information about this person
        5. Sort list by name, output to file
        6. Create a list of Employees and move only workers there. Sort them by salary.
        */
        
    }

    public class Person
    {
        private string name;

        public Person (string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public virtual void Print()
        {
            Console.WriteLine("Name : {}", this.name);
        }
    }

    public class Staff: Person
    {
        private int salary;

        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }

        public void Print()
        {
            Console.WriteLine("Person {} has salary: ${1}", Name, this.salary);
        }
    }

    //public class Teacher: Staff
    //{

    //}

    //public class Developer: Staff
    //{

    //}
}
