using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonCalculator.Models
{
    public class Art
    {
        public string Name { get; set; }
        public string TravelFrom { get; set; }
        public string TravelTo { get; set; }
        public double CO2Emmision { get; set; } = 0;
    }
}
