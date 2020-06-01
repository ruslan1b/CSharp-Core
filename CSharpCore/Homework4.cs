using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    /// <summary>
    /// Create class Person.
    ///    Class Person should consists of
    ///             a) two private fields: name and birthYear(the birthday year).As a type for this field you may use DataTime type.)
    ///              b) two properties for access to these fields (only get)
    ///              c) default constructor and constructor with 2 parameters
    ///              d) methods: -Age() - to calculate the age of person
    ///                        - Input() - to input information about person
    ///                        -ChangeName() - to change the name of person
    ///                           - ToString()
    ///                         - Output() - to output information about person(call ToString())
    ///                           - operator== (equal by name)
    ///     In the method Main() create 6 objects of Person type and input information about them.Then calculate and write to console the name and Age of each person; Change the name of persons, which Age is less then 16, to "Very Young".
    ///Output information about all persons.
    ///Find and output information about Persons with the same names(use ==)
    /// </summary>
    class Homework4
    {
    }

    class PersonHW4
    {
        private string name;
        private DateTime birthYear;

        public PersonHW4() {}

        public PersonHW4 (string _name, DateTime _bithYear) { }

        public void Age()
        {

        }

        public void Input()
        {

        }

        public void ChangeName() { }

        //override ToString
        public override string ToString()
        {

            return ($"");
        }
    }
}
