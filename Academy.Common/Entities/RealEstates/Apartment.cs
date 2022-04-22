using System;

namespace Academy.Common.Entities.RealEstates
{
    public class Apartment : RealEstate 
    {
        public int Rooms { get; set; }
        public int Bathrooms { get; set; }

        public Apartment(string address, string city, Person owner)
        {
            Owner = owner;
            Address = address;
            City = city;
        }

        public override string GetInfo()
        {
            //TODO
            throw new NotImplementedException();
        }

        public override string GetInfoVirtual()
        {
            return base.GetInfoVirtual() + $" Rooms: {Rooms}";
        }

        public new string GetInfoOnBase()
        {
            return ""; //TODO
        }
    }

}
