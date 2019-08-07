
using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace carclassbonus16
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            bool co = true;

                ArrayList Carlot = new ArrayList();
                Console.WriteLine("Welcome to the Grand Circus Motor Company!");

                Vehicle car1 = new Vehicle(2002, "Chevy", "Malibu", 3);
                Vehicle car2 = new Vehicle(2009, "Dodge", "Caravan", 4);
                Vehicle car3 = new Vehicle(2013, "Ford", "Taurus", 35);
                Vehicle car4 = new UsedVehicle(2005, "Dodge", "Charger", 302, 200000);
                Vehicle car5 = new UsedVehicle(2007, "Chrysler", "300", 2000, 4300);
                Vehicle car6 = new UsedVehicle(2003, "Saturn", "ion", 300, 35000);


                Carlot.Add(car1);
                Carlot.Add(car2);
                Carlot.Add(car3);
                Carlot.Add(car4);
                Carlot.Add(car5);
                Carlot.Add(car6);
            while (co)
            {
                int i = 0;
                foreach (Vehicle a in Carlot)
                {
                    i++;
                    Console.WriteLine(i + ". " + a.ToString());
                }



                Console.WriteLine("Which Car would you like?");

                int input = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine(Carlot[input - 1]);

                Console.WriteLine("Would you like to buy this car? Y or N:");
                string response = Console.ReadLine();

                response.Trim().ToLower();

                if (response == "y")
                {
                    Carlot.RemoveAt(input-1);
                    Console.WriteLine("Excellent! Our finance department will be in touch shortly.");
                }



                Console.WriteLine("Would you like to continue? Y or N:");

                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    co = true;
                }
                else 
                {
                    co = false;
                    Console.WriteLine("Thank you for shopping with us! Enjoy your vehicle.");
                }
            }


        }
    }
}
