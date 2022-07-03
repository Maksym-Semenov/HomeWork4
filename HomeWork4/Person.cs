using System;

namespace HomeWork4
{
    internal class Person
    {
        string name;
        int birthdayYear;
        int age;
        public string Name { get { return name; } set { name = value; } }
        public int BirthdayYear { get { return birthdayYear; }  set { birthdayYear = value; } }
        public Person()
        {
            name = "";
            birthdayYear = 1900;
        }
        public Person(string name, int birthdayYear)
        {
            this.name = name;
            this.birthdayYear = birthdayYear;
        }
        public static Person Input()
        {
            Console.Write("Input person name:\t");
            string _name = Console.ReadLine();
            Console.Write("Input person birthday year:\t");
            int _birthdayYear = int.Parse(Console.ReadLine());
            Person person = new Person( _name, _birthdayYear);
            return person;
        }
        public int Age(int birthdayYear)
        {
            age = DateTime.Now.Year - birthdayYear;
            return age;
        }
        public void Output()
        {
            Console.WriteLine($"Info about person: name is {name}, age is {birthdayYear}");
        }
        public void ChangeName()
        {
            if (name == "Tim")
            {
                name = "Tom";
            }
        }
        public override string ToString()
        {
            return $"Personal account: name is {name}, age is {age}";
        }
        public static bool operator ==( Person first, Person second)
        {
            return first.name == second.name;
        }
        public static bool operator !=(Person first, Person second)
        {
            return !(first.name == second.name);
        }
    }
}
