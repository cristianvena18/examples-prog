using System;
using Ejercicio5.Entities;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un nombre: ");
            string name = Console.ReadLine();

            Console.Write("Ingrese un apellido: ");
            string surname = Console.ReadLine();


            Console.Write("Ingrese una altura: ");
            double heigth = double.Parse(Console.ReadLine());


            var persona = new Persona(name, surname)
                .setHeigth(heigth);

            var ayrton = new Persona("ayrton", "cravero")
                .setAge(21);

            Console.WriteLine(persona.Mostrar());
            Console.WriteLine(ayrton.Mostrar());
            Console.ReadKey();
        }
    }
}
