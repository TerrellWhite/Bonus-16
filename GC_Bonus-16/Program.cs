using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Bonus_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of Employees
            List<Car> cars = new List<Car>();

            //used to add new employees to the list
            while (true)
            {
                Car temp = new Car();
                Console.WriteLine("Please Provide the Make:");
                temp.Make = Console.ReadLine();
                Console.WriteLine("Please Provide the Model:");
                temp.Model = Console.ReadLine();
                Console.WriteLine("Please Provide the Year:");
                temp.Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Provide the Price:");
                temp.Price = double.Parse(Console.ReadLine());

                cars.Add(temp); //add the temp object to the employees list
                Console.WriteLine("Do you want to add more cars?");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "n")
                {
                    break;
                }       
            }
            foreach (Car e in cars)
            {
                Console.WriteLine($"{e.Make} {e.Model} \n${e.Price} {e.Year}");
                Console.WriteLine("=====================");

            }
        }
    }
}
