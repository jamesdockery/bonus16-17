using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace carclassbonus16
{
    public class VehicleApp 
    {
        List<Vehicle> cars = new List<Vehicle>();


        int input = 0;


       public int GetInput(int input)
        {
            this.input = input;
            return input;
        }

        public void CreateVehicle()
        {
            try {
                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine("Enter year: ");
                   int year = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter Make: ");
                 string make = Console.ReadLine();
                Console.WriteLine("Enter Model: ");
                 string model = Console.ReadLine();
                 Console.WriteLine("Enter Price: ");
                 double price = Convert.ToDouble(Console.ReadLine());

                Vehicle a = new Vehicle(year, make, model, price);
                cars.Add(a);
                }

            } catch (ArgumentNullException)
            {
                throw new Exception("Please enter valid input data.");
            }

           
        }
            


        public void Inventory()
        {
            Console.WriteLine("Current Inventory: ");
            foreach (Vehicle e in cars)
            {
                Console.WriteLine(e.ToString());
            } 
           
        }

           
        }

   }

