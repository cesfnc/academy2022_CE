namespace Academy.Common.Entities.Vehicles
{
    public class Track : Vehicle
    {
        public int KgCapacity { get; set; }

        public override string GetDescription()
        {
            return base.GetDescription() + $" Capacità {KgCapacity} kg";
        }
    }
}
