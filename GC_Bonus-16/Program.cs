using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            //List<Car> carlist = new List<Car>() { t1, t2, t3, t4, t5, t6 };

            CarLot GC = new CarLot();

            GC.Lot.Add(t1);
            GC.Lot.Add(t2);
            GC.Lot.Add(t3);
            GC.Lot.Add(t4);
            GC.Lot.Add(t5);
            GC.Lot.Add(t6);
            string ans;
            do 
            {
                foreach (Car emp in GC.Lot)
                {
                    emp.PrintInfo();
                }
                Console.WriteLine("Which car would you like to buy a car (Enter a num 1-6). Or do you want to add a new car (enter add) ");
                string addOrNo = Console.ReadLine();
                bool goAgain = true;
                do
                {
                    #region Add
                    if (Regex.IsMatch(addOrNo, "[aA][dD][dD]"))
                    {
                        do
                        {
                            Console.WriteLine("Is the car new or used");
                            string newUsed = Console.ReadLine();
                            //int next = 0;
                            #region New
                            if (newUsed.ToLower() == "new")
                            {
                                Console.WriteLine("What is the make of the car.");
                                string make = Console.ReadLine();
                                Console.WriteLine("What is the model of the car.");
                                string model = Console.ReadLine();
                                Console.WriteLine("What is the year om the car.");
                                int year = int.Parse(Console.ReadLine());
                                Console.WriteLine("What is the Price of the car.");
                                double price = double.Parse(Console.ReadLine());
                                Car b1 = new Car(make, model, year, price);
                                GC.Lot.Add(b1);
                                foreach (Car emp in GC.Lot)
                                {
                                    emp.PrintInfo();
                                }
                            }
                            #endregion
                            #region Used
                            if (newUsed.ToLower() == "used")
                            {
                                Console.WriteLine("What is the make of the car.");
                                string make = Console.ReadLine();
                                Console.WriteLine("What is the model of the car.");
                                string model = Console.ReadLine();
                                Console.WriteLine("What is the year om the car.");
                                int year = int.Parse(Console.ReadLine());
                                Console.WriteLine("What is the Price of the car.");
                                double price = double.Parse(Console.ReadLine());
                                Console.WriteLine("How many miles are on the car.");
                                double miles = double.Parse(Console.ReadLine());
                                UsedCar b1 = new UsedCar(make, model, year, price, miles);
                                GC.Lot.Add(b1);
                                foreach (Car emp in GC.Lot)
                                {
                                    emp.PrintInfo();
                                }
                            }
                            #endregion
                            Console.WriteLine("Replace another? (y/n)");
                            ans = Console.ReadLine();
                        } while (ans.ToLower() == "y");
                        goAgain = false;
                       
                    }
                    #endregion
                    #region Buy
                    else if (Regex.IsMatch(addOrNo, "^[bB][uU][yY]$"))
                    {
                        int howMany = 5;
                        do
                        {
                            Console.WriteLine($"What which car are you buying (0-{howMany})");
                            int index = int.Parse(Console.ReadLine());
                            Console.WriteLine($"{GC.Lot[index].Price} {GC.Lot[index].Make} {GC.Lot[index].Model} {GC.Lot[index].Year} ");
                            GC.Lot.RemoveAt(index);
                            howMany -= 1;
                            Console.WriteLine("Buy another? (y/n)");
                            ans = Console.ReadLine();
                            foreach (Car emp in GC.Lot)
                            {
                                emp.PrintInfo();
                            }
                        } while (ans.ToLower() == "y");
                        goAgain = false;
                    }
                    #endregion
                    #region Remove
                    else if (Regex.IsMatch(addOrNo, "[rR][eE][mM][oO][vV][eE]"))
                    {
                        do
                        {
                            Console.WriteLine("Which one would you like to remove");
                            int input = int.Parse(Console.ReadLine());
                            GC.Lot.RemoveAt(input-1);
                            Console.WriteLine("Remove another? (y/n)");
                            ans = Console.ReadLine();
                        } while (ans.ToLower() == "y");
                        goAgain = false;
                    }
                    #endregion
                    #region Replace
                    else if (Regex.IsMatch(addOrNo, "[rR][eE][pP][lL][aA][cC][eE]"))
                    {
                        do
                        {
                            Console.WriteLine("Which one would you like to replace (0 - 5)");
                            int input = int.Parse(Console.ReadLine());
                            GC.Lot.RemoveAt(input);
                            Console.WriteLine("Is the car new or used");
                            string newUsed = Console.ReadLine();
                            //int next = 0;
                            #region New
                            if (newUsed.ToLower() == "new")
                            {
                                Console.WriteLine("What is the make of the car.");
                                string make = Console.ReadLine();
                                Console.WriteLine("What is the model of the car.");
                                string model = Console.ReadLine();
                                Console.WriteLine("What is the year om the car.");
                                int year = int.Parse(Console.ReadLine());
                                Console.WriteLine("What is the Price of the car.");
                                double price = double.Parse(Console.ReadLine());
                                Car b1 = new Car(make, model, year, price);
                                GC.Lot.Insert(input, b1);
                                foreach (Car emp in GC.Lot)
                                {
                                    emp.PrintInfo();
                                }
                            }
                            #endregion
                            #region Used
                            if (newUsed.ToLower() == "used")
                            {
                                Console.WriteLine("What is the make of the car.");
                                string make = Console.ReadLine();
                                Console.WriteLine("What is the model of the car.");
                                string model = Console.ReadLine();
                                Console.WriteLine("What is the year om the car.");
                                int year = int.Parse(Console.ReadLine());
                                Console.WriteLine("What is the Price of the car.");
                                double price = double.Parse(Console.ReadLine());
                                Console.WriteLine("How many miles are on the car.");
                                double miles = double.Parse(Console.ReadLine());
                                UsedCar b1 = new UsedCar(make, model, year, price, miles);
                                GC.Lot.Insert(input, b1); 
                                foreach (Car emp in GC.Lot)
                                {
                                    emp.PrintInfo();
                                }
                            }
                            #endregion
                            Console.WriteLine("Add another? (y/n)");
                            ans = Console.ReadLine();
                            ans = Console.ReadLine();
                        } while (ans.ToLower() == "y");
                        goAgain = false;
                    }
                    #endregion
                    #region Wrong Input
                    else
                    {
                        while (!(Regex.IsMatch(addOrNo, "^[rR][eE][mM][oO][vV][eE]|[1-6]{1}|[aA][dD][dD]$")))
                        {
                            Console.WriteLine("Put in the right input");
                            addOrNo = Console.ReadLine();
                        }

                    }
                    #endregion
                } while (goAgain);

                Console.WriteLine("Go Again (y/n)");
                ans = Console.ReadLine();
                
            } while (ans.ToLower() == "y");
        }
    }
}
