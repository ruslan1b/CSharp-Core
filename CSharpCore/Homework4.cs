using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

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
        public void DemoHomework4()
        {
            try
            {
                List<PersonHW4> list = new List<PersonHW4>();
                PersonHW4 person1 = new PersonHW4("Alex", 46);
                PersonHW4 person2 = new PersonHW4("Jan", 58);
                PersonHW4 person3 = new PersonHW4("Lary", 15);
                PersonHW4 person4 = new PersonHW4("Kate", 29);
                PersonHW4 person5 = new PersonHW4("Marcy", 34);
                PersonHW4 person6 = new PersonHW4("Alex", 39);

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
                Console.WriteLine("****************\n");

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].BirthYear.Year > DateTime.Today.Year-16)
                        list[i].ChangeName();
                    Console.WriteLine(list[i].ToString());
                }
                Console.WriteLine("****************\n");

                for (int i = 0; i < list.Count; i++)
                {
                    PersonHW4 temp = list[i];
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (temp.Name == list[j].Name)
                            
                        Console.WriteLine(temp.ToString()+ " is same person with "+list[j].ToString());
                    }
                }
                Console.WriteLine("****************\n");

                BinaryFormat(person1, $"{person1.Name}.bin");

                PersonXml personXml = new PersonXml("Marcy", 34);
                XmlFormat(personXml, $"{personXml.Name}.xml");

                PersonXml personJSON = new PersonXml("Alex", 39);
                JSONFormat(personJSON, $"{personJSON.Name}.json");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void BinaryFormat(object obj, string name)
        {
            BinaryFormatter bin = new BinaryFormatter();
            using (Stream myStream = new FileStream(name, FileMode.Create, FileAccess.Write))
            {
                bin.Serialize(myStream, obj);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Serialization bin successful");
                Console.WriteLine("****************\n");
                myStream.Close();
            }
        }

        static void XmlFormat(object obj, string name)
        {
            XmlSerializer xml = new XmlSerializer(typeof(PersonXml));
            using (Stream myStream = new FileStream(name, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(myStream, obj);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Serialization xml successful");
                Console.WriteLine("****************\n");
                myStream.Close();
            }
        }

        static void JSONFormat(object obj, string name)
        {            
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {                
                JsonSerializer.Serialize(obj, typeof(PersonXml));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Serialization JSON successful");
                Console.WriteLine("****************\n");
            }
        }
    }

    [Serializable]
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
            
            DateTime dateTemp = new DateTime(year, 1, 1, 0, 0, 0);

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
            this.name = "Very Young";

        }

        //override ToString
        public override string ToString()
        {
            int age = DateTime.Today.Year - BirthYear.Year;
            return ($"Name: {Name}, age: {age}");
        }
    }

    [Serializable]
    public class PersonXml
    { 
    public string name;
    public DateTime birthYear;

    public string Name
    {
        get { return name; }
    }

    public DateTime BirthYear
    {
        get { return birthYear; }
    }

    public static bool operator ==(PersonXml firstName, PersonXml secondName)
    {
        return firstName.name == secondName.name;
    }

    public static bool operator !=(PersonXml firstName, PersonXml secondName)
    {
        return !(firstName == secondName);
    }

    public PersonXml() { }

    public PersonXml(string _name, int _age)
    {
        this.name = _name;
        this.birthYear = Age(_age);

    }

    public DateTime Age()
    {
        Console.WriteLine("Input your BirthYear");
        int year = Convert.ToInt32(Console.ReadLine());

        DateTime dateTemp = new DateTime(year, 1, 1, 0, 0, 0);

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
        this.name = "Very Young";

    }

    //override ToString
    public override string ToString()
    {
        int age = DateTime.Today.Year - BirthYear.Year;
        return ($"Name: {Name}, age: {age}");
    }
}
}
