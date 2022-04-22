using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Common.Entities.RealEstates
{
    public abstract class RealEstate
    {
        public string Address { get; set; }

        public string City { get; set; }

        public string CAP { get; set; }

        public double SurfaceArea { get; set; }

        public Person Owner { get; set; }

        public abstract string GetInfo();

        public virtual string GetInfoVirtual()
        {
            return ""; //TODO
        }

        public string GetInfoOnBase()
        {
            return ""; //TODO
        }
    }

}
