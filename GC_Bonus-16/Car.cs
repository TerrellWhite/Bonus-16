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
                    throw new Exception("years is not vaild!");
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
    }
}
