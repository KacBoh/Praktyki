using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarządzane_ulem
{
    public class Bee
    {
        public const double HoneyUnitsConsumedperMg = .25;
        public Double WeightMg { get; private set; }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        virtual public double HoneyUnitConsumtionRate()
        {
            return WeightMg * HoneyUnitsConsumedperMg;
        }
    }
}
