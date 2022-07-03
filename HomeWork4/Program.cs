using System;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input info about persons
            Console.Write("Input number of person:\t");
            int number = int.Parse(Console.ReadLine());
            var person = new Person[number];
            for (int i = 0; i < person.Length; i++)
            {
                person[i] = Person.Input();
            }
            Console.WriteLine();
            for (int i = 0; i < person.Length; i++)
            {
                person[i].Output();
            }
            Console.WriteLine();
            //Change name person, if his name is Tim
            Console.WriteLine("Type Enter, if you need change name Tim for Tom");
            Console.ReadKey();
            for (int i = 0; i < person.Length; i++)
            {
                person[i].ChangeName();
            }
            Console.WriteLine();
            for (int i = 0; i < person.Length; i++)
            {
                person[i].Output();
            }
            Console.WriteLine();

            //Find person, who's age < 16
            Console.Write("Input age for find very young person:\t");
            Console.WriteLine();
            int age = int.Parse(Console.ReadLine());
            for (int i = 0; i < person.Length; i++)
            {
                if ( person[i].Age(person[i].BirthdayYear) < age )
                {
                    person[i].Name = "Very Young";
                    Console.WriteLine(person[i]);
                }
            }
            //Output info about all persons
            for (int i = 0; i < person.Length; i++)
            {
                person[i].ToString();
            }
            Console.WriteLine();
            //Persons with same name
            Console.WriteLine("If you can find persons with same name? type Enter");
            Console.WriteLine();
            Console.ReadKey();
            for (int i = 0; i < person.Length - 1; i++)
            {
                for (int j = i + 1; j < person.Length; j++)
                {
                    if (person[i].Name == person[j].Name)
                    {
                        Console.WriteLine($"Name person { i } is equals name person { j }");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
