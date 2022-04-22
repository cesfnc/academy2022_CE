namespace Academy.Common.Entities.RealEstates
{
    public class Villa : Apartment 
    {
        public Villa(string address, string city, Person owner, double gardenArea) 
            : base(address, city, owner)
        {
            GardenArea = gardenArea;
        }

        public double GardenArea { get; set; }
    }

}
