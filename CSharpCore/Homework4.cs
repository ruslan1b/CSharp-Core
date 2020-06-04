using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    /// <summary>
    /// Create class Person.
    ///    Class Person should consists of
    ///             a) two private fields: name and birthYear(the birthday year).
    ///             As a type for this field you may use DataTime type.)
    ///              b) two properties for access to these fields (only get)
    ///              c) default constructor and constructor with 2 parameters
    ///              d) methods: -Age() - to calculate the age of person
    ///                        - Input() - to input information about person
    ///                        -ChangeName() - to change the name of person
    ///                           - ToString()
    ///                         - Output() - to output information about person(call ToString())
    ///                           - operator== (equal by name)
    ///     In the method Main() create 6 objects of Person type and input information about them.
    ///     Then calculate and write to console the name and Age of each person;
    ///     Change the name of persons,
    ///     which Age is less then 16, to "Very Young".
    ///Output information about all persons.
    ///Find and output information about Persons with the same names(use ==)
    /// </summary>
    class Homework4
    {
        List<PersonHW4> list = new List<PersonHW4>();
        PersonHW4 person1 = new PersonHW4("Alex", 46);
        PersonHW4 person2 = new PersonHW4("Jan", 58);
        PersonHW4 person3 = new PersonHW4("Lary", 15);
        PersonHW4 person4 = new PersonHW4("Kate", 29);
        PersonHW4 person5 = new PersonHW4("Marcy", 34);
        PersonHW4 person6 = new PersonHW4("Alex", 39);

        public void DemoHomework4()
        {
            try
            {
                list.Add(person1);
                list.Add(person2);
                list.Add(person3);
                list.Add(person4);
                list.Add(person5);
                list.Add(person6);

                Console.WriteLine($"Count of person: {list.Count}");

                for (int i = 0; i < list.Count; i++)
                {
                   Console.WriteLine( list[i].ToString());

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

    }

    class PersonHW4
    {
        private string name;
        private DateTime birthYear;

        public string Name
        {
            get { return name; }            
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public static bool operator == (PersonHW4 firstName, PersonHW4 secondName)
        {
            return firstName.name == secondName.name;
        }

        public static bool operator !=(PersonHW4 firstName, PersonHW4 secondName)
        {
            return !(firstName == secondName);
        }

        public PersonHW4() {}

        public PersonHW4 (string _name, int _age) 
        {
            this.name = _name;
            this.birthYear= Age(_age);

            

        }

        public DateTime Age()
        {
            Console.WriteLine("Input your BirthYear");
            int year = Convert.ToInt32(Console.ReadLine());
            
            DateTime dateTemp = new DateTime(year, 1, 1, 0, 0, 0); // 20.07.2015 18:30:25

            birthYear = DateTime.Today.AddYears(-year);
            return birthYear;
            
        }

        public DateTime Age(int year)
        {
            birthYear = DateTime.Today.AddYears(-year);
            return birthYear;

        }

        public void Input()
        {
            Console.WriteLine("Input your name");
            this.name = Console.ReadLine();
            this.Age();
        }

        public void ChangeName() 
        {
            Console.WriteLine("Input your name");

        }

        //override ToString
        public override string ToString()
        {

            return ($"Name: {Name}, birthYear: {BirthYear}");
        }
    }
}
