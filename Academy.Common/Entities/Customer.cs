namespace Academy.Common.Entities
{
    public class Customer : Person
    {
        public bool IsNewDriver { get; set; }

        public Customer(string cf, string name, string surname, bool isNewDriver)
        {
            Name = name;
            Surname = surname;
            CF = cf;
            IsNewDriver = isNewDriver;
        }

        public override string ToString()
        {
            string s;
            if (IsNewDriver)
                s = "Si";
            else
            {
                s = "No";
            }
            //oppure
            string newDriver = IsNewDriver ? "Si" : "No";

            return $"{Surname} {Name} CF.{CF} NeoPatentato? {newDriver}";
        }
    }
}
