using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GC_Bonus_16
{
    class Car
    {
         #region Fields
        private string make;
        private string model;
        private int year;
        private double price;

        #endregion

        #region Properties
        public CarLot CarLot { set; get; }
        public string Make
        {
            set { make = value; }
            get { return make; }
        }
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        public int Year
        {
            set
            {
                if (!Regex.IsMatch(Convert.ToString(value), @"^\d{4}$"))
                {
                    throw new Exception("Year is not vaild!");
                }
                else
                {
                    year = value;
                }
                year = value;
            }
            get { return year; }
        }
        public double Price
        {
            set
            {
                if (!Regex.IsMatch(Convert.ToString(value), @"^\d{4,}$"))
                {
                    throw new Exception("Price is not vaild!");
                }
                else
                {
                    price = value;
                }
                price = value;
            }
            get { return price; }
        }

        #endregion
        public Car() // default constructor (no-argument constructor)
        {
            Year = 2000;
            Make = "not assigned";
            Price = 40000;
            Model = "000-00-0000";

        }
        //overoaded constructor
        public Car(string mk, string md, int yr, double p)
        {

            Year = yr;
            Make = mk;
            Price = p;
            Model = md;

        }
        //Methods
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Make}, {Model}, {Year}, Price: {Price:C}");
        }
    }
}
