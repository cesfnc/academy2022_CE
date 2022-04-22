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

        #region Properties
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


        public string CF { get; set; }
        #endregion

        public Person()
        {
            DateOfBirth = new DateTime(1901, 1, 1);
        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        public Person(string name, string surname) : this()
        {
            #warning sarebbe bello avere anche un costruttore con data di nascita

            Name = name;
            Surname = surname;
        }

        #region private methods

        private int GetAgePrivate()
        {
            var interval = DateTime.Now - DateOfBirth;
            var age = (int)Math.Round(interval.TotalDays / 365, 0);
            return age;
        }

        #endregion

        #region public methods
        public int GetAge()
        {
            var interval = DateTime.Now - DateOfBirth;
            var age = (int)Math.Round(interval.TotalDays / 365, 0);
            return age;
        }

        /// <summary>
        /// Get Age by Date of birth
        /// </summary>
        /// <param name="dateOfBirth">Date of birth</param>
        /// <returns>the age</returns>
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
        #endregion

    }
}
