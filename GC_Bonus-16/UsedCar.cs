using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Bonus_16
{
    class UsedCar : Car
    {
        private double mileage;

        public double Mileage
        {
            set { mileage = value; }
            get { return mileage; }
        }
        public UsedCar(string mk, string md, int yr, double p, double ml): base(mk, md, yr, p)
        {
            Mileage = ml;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();//calls code from to the top
            Console.WriteLine($"(Used) {mileage} miles");//:c
        }
    }
}
