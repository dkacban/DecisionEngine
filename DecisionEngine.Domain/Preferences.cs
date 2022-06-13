using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionEngine.Domain
{
    public class Preferences
    {
        public bool City { get; set; }
        public bool Roads { get; set; }
        public bool GravelRoads { get; set; }
        public bool Races { get; set; }
        public bool TripWithBag { get; set; }
        public bool Forest { get; set; }
        public bool HardTrails { get; set; }
        public bool Mountain { get; set; }
        public decimal MaxPrice { get; set; }

    }
}
