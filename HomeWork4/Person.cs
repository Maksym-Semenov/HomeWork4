using System;

namespace HomeWork4
{
    internal class Person
    {
        static string name;
        static int birthdayYear;
        int age;
        public string Name { get; set; }
        public int BirthdayYear { get; set; }

        public Person()
        {
            name = "";
            birthdayYear = 1900;
        }
        public Person(string name, int birthdayYear)
        {
            Person.name = name;
            Person.birthdayYear = birthdayYear;
        }
        public static Person Input(int i)
        {
            Person person = new Person();
            Console.Write("Input person name:\t");
            name = Console.ReadLine();
            Console.Write("Input person birthday year:\t");
            birthdayYear = int.Parse(Console.ReadLine());
            return person;
        }
        public int Age(int birthdayYear)
        {
            age = DateTime.Now.Year - birthdayYear;
            return age;
        }
        public void Output()
        {
            Console.WriteLine($"Info about person: name is {name}, age is {age}");
        }
    }
}
