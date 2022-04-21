using Academy.Common.Enums;

namespace Academy.Common.Entities
{
    //sealed: non può essere derivata 
    public sealed class Bicycle : Vehicle
    {
        public Bicycle(string brand, string model) : base(brand, model)
        {

        }
        /* 
         equivale, ma non consigliato
         
        public Bicycle(string brand, string model)
        {
            Brand = brand;
            Model = model;

        }*/

        public Bike Type { get; set; }

        //(new) hiding metodo classe base
        public new string GetDescription() 
        {
            return $"{Type} {Brand}-{Model}, year {Year}";

        }

    }
}
