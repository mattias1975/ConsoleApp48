using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp48
{
    class Person
    {
        public Person() { }//Zerro constructor
        public string Firstname { get; set; }
        public string lastname;
        int age;
        public void SayHello()
        {
            Console.Write("Ditt namn är" + " " + Firstname + " " + lastname);
            if(age>0)
            {
                Console.Write("im "+age+" years old");
            }
            Console.WriteLine();
        }
               
        public Person(string Firstname, string lastname)
        {
            this.Firstname = Firstname;
            this.lastname = lastname;
        }

        public Person(string Firstname, string lastname, int age): this(Firstname,lastname)
            
        {
            this.age = age;
        }
    }

}
