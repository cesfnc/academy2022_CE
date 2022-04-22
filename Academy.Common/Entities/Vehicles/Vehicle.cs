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
            return $"{Brand} {Model}";
        }
    }
}
