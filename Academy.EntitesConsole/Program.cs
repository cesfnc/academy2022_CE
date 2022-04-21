using Academy.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.EntitesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //metodo statico della class Person (non serve istanza)
            int ageS = Person.GetAgeStatic(new DateTime(1950, 4, 21));

            //nuova istanza, oggetto mario
            Person mario = new Person();
            mario.Name = "Mario";
            mario.Surname = "Gallo";

            //nuova istanza con assegnazione di proprietà inline
            var rodolfo = new Person("Rodolfo", "Tasso") { 
                DateOfBirth = new DateTime() 
            };

            var artemio = new Person() { 
                Name = "Artemio", 
                Surname = "Grillo", 
                DateOfBirth = new DateTime(1975, 7, 4) 
            };

            mario.DateOfBirth = new DateTime(1950, 4, 21);
            
            var giorgia = new Person();
            giorgia.Name = "Giorgia";
            giorgia.DateOfBirth = new DateTime(1930, 6, 18);

            mario.Mother = giorgia;

            mario.MyProperty = "test";

            //int age = person.Age;
            //int age2 = person.GetAge();

            int diff = giorgia.Age - mario.Age;

            var s = mario.MyProperty;

            Console.WriteLine($"Ciao sono {mario.Name} {mario.Surname}, ho {mario.Age} " +
                $"anni e mia madre è di {diff} anni più vecchia");

            Console.WriteLine(mario.GetDescription());

            //person.GetAgePrivate(); //inaccessibile

            Console.ReadKey();


        }
    }
}
