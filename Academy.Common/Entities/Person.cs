using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Common.Entities
{
    public class Person
    {
        private string myVar;

        public string MyProperty
        {
            get 
            { 
                return myVar.ToUpper(); 
            }
            set 
            { 
                myVar = value; 
            }
        }


        //nome, cognome, data di nascita, età (calcolata)
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person Mother { get; set; }

        public Car Car { get; set; }

        public int Age
        {
            get 
            {
                return GetAgePrivate();
            }
        }

        public int GetAge()
        {
            var interval = DateTime.Now - DateOfBirth;
            var age = (int)Math.Round(interval.TotalDays / 365, 0);
            return age;
        }

        private int GetAgePrivate()
        {
            var interval = DateTime.Now - DateOfBirth;
            var age = (int)Math.Round(interval.TotalDays / 365, 0);
            return age;
        }

        public static int GetAgeStatic(DateTime dateOfBirth)
        {
            var interval = DateTime.Now - dateOfBirth;
            var age = (int)Math.Round(interval.TotalDays / 365, 0);
            return age;
        }


        public string GetDescription()
        {
            return $"Ciao sono {Name} {Surname} e ho {Age} anni";
        }


    }
}
