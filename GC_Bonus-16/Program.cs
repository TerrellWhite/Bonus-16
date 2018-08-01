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
            Car t1 = new Car("Ford", "Focus", 2001, 7000000);
            Car t2 = new Car("Tesla", "Focus", 2002, 7000001);
            Car t3 = new Car("Ford", "Focus", 2001, 7000000);
            UsedCar t4 = new UsedCar("Terrrela", "Focus", 2030, 20001, 44444);
            UsedCar t5 = new UsedCar("Ford", "Fusion", 2231, 70000, 4000000);
            Car t6 = new UsedCar("Errrela", "Focus", 2030, 20001, 440000);

            List<Car> carlist = new List<Car>() { t1, t2, t3, t4, t5, t6 };
            foreach (Car emp in carlist)
            {
                emp.PrintInfo();
            }
            string ans;
            do
            {
                Console.WriteLine("Which car would you like to buy (0-6)");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine($"{carlist[index].Price} {carlist[index].Make} {carlist[index].Model} {carlist[index].Year} ");
                carlist.RemoveAt(index);
                Console.WriteLine("Buy another? (y/n)");
                ans = Console.ReadLine();
            } while (ans.ToLower() == "y");
            //used to add new employees to the list
            //while (true)
            //{
            //    Car temp = new Car();
            //    Console.WriteLine("Please Provide the Make:");
            //    temp.Make = Console.ReadLine();
            //    Console.WriteLine("Please Provide the Model:");
            //    temp.Model = Console.ReadLine();
            //    Console.WriteLine("Please Provide the Year:");
            //    temp.Year = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Please Provide the Price:");
            //    temp.Price = double.Parse(Console.ReadLine());

            //    cars.Add(temp); //add the temp object to the employees list
            //    Console.WriteLine("Do you want to add more cars?");
            //    string choice = Console.ReadLine();
            //    if (choice.ToLower() == "n")
            //    {
            //        break;
            //    }       
            //}

        }
    }
}
