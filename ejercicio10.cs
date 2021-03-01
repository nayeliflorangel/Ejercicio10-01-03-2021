using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine("Escriba su nombre: ");
            person.Name = Console.ReadLine();

            Console.WriteLine("Escriba su edad: ");
            person.Age = int.Parse(Console.ReadLine());

            if (person.Age >= 18) { Console.WriteLine($"Nombre: {person.Name}.\nEdad: {person.Age}."); }
            else { Console.WriteLine("Usted es menor de edad."); }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
