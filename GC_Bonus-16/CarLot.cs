using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Bonus_16
{
    class CarLot
    {
        public List<Car> Lot { set; get; }

        public CarLot()
        {
            Lot = new List<Car>();
        }

    }
}
