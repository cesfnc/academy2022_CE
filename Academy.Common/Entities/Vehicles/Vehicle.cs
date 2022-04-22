using System;

namespace Academy.Common.Entities.Vehicles
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string Plate { get; set; }

        public int DailyPrice { get; set; }

        public bool IsForNewDriver { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - Year;
        }


        public virtual string GetDescription()
        {
            return $"{Brand}-{Model}, year {Year}";
        }


        public override string ToString()
        {
            string s1 = string.Format("Marca {0}, Modello {1}", Brand, Model);
            string s2 = string.Concat("Marca ", Brand, ", Modello ", Model);
            string s3 = $"Marca {Brand}, Modello {Model}";

            string s4 = @"Marca {Brand}
Modello {Model}
Anno {Year}
Colore
";

            string s5 = $@"Marca {Brand}
Modello {Model}
Anno {Year}
Colore
";

            return $"{Brand} {Model}";
        }
    }
}
