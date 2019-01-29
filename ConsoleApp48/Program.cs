using System;
using System.Collections.Generic;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)

        {
            List<Person> people = new List<Person>();//gör en lista med namnet person
            /*
            people.Add(new Person("Mattias", "Gustavsson", 43));//lägger till personer i listan
            people.Add(new Person("Ariella", "Landqvist", 41));
            people.Add(new Person("Leif", "Gustavsson", 0));
            people.Add(new Person("Inger", "Gustavsson", 66));
            people.Add(createPersson());

            people.ForEach(p => p.SayHello());//skriver ut från sayhello sen namnet

            /* Person Mattias = new Person();
            Mattias.Firstname = "Mattias";
            Mattias.lastname = "Gustavsson";
            Mattias.SayHello();
            Console.ReadKey();
            Person Ariella = new Person("Ariella", "Landqvist");
            Ariella.SayHello();*/
            bool keepAlive=true;

            while(keepAlive)
            {
                Console.WriteLine("---People Menu--- \n" +
                    "1.Add Person to list \n" +
                    "2. show list \n" +
                    "0. Exit program"
                    );
                int selcetion = AskUserForNumberX("select");

                switch (selcetion)
                {
                    case 1:
                        people.Add(createPersson());
                        break;

                    case 2:
                        PrintList(people);
                        break;

                    case 0:
                        keepAlive = false;
                        Console.WriteLine("Thanska for using this program")
;                        break;

                    default:
                        Console.WriteLine("Not a valid selection");
                        break;
                }
                Console.WriteLine("Press any key to Continue");
                Console.ReadKey(true);//Dose not print key to screen
                Console.Clear();
            }
            
        }

        static void PrintList(List<Person> people)

        {
            people.ForEach(p => p.SayHello());
        }

        static Person createPersson()
        {
            string firstname = AskUserForX("First name ");
            string lastName = AskUserForX("last name ");
            int age = AskUserForNumberX("age");
            return new Person(firstname, lastName, age);

        }

        static string AskUserForX(string x)
        {
            string input = "";
            while (input.Length == 0)
            {
                Console.Write("please input" + x + ": ");
                input = Console.ReadLine();

            }
            return input;
        }

        static int AskUserForNumberX(string x)
        {
            int number = 0;
            bool Nonum = true;

            while (Nonum)
            {
                try
                {
                    number = Convert.ToInt32(AskUserForX(x));
                    Nonum = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("not a number, Please try oone mmore.");

                }
            }
            return number;

        }
    }
}


