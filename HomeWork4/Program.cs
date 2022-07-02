using System;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of person:\t");
            int number = int.Parse(Console.ReadLine());
            Person person = new Person();
            var person = new Person[number];
            for (int i = 0; i < person.Length; i++)
            {
                person[i] = Person.Input(i);
            }
            for (int i = 0; i < person.Length; i++)
            {
                person[i].Output();
            }
            Console.ReadLine();
        }
    }
}
