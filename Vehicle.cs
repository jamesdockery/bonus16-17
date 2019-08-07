using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;


namespace carclassbonus16
{
    public class Vehicle
    {

        private int year;
        public int Year
        {
            get
            {
                return year;
            }
        }


        private string make;
        public string Make
        {
            get
            {
                return make;
            }
        }

        private string model;
        public string Model
        {
            get
            {
                return model;
            }
        }


        public double price;
        public double Price
        {
            get
            {
                return price;
            }
        }


        public Vehicle(int year, string make, string model, double price)
        {

           this.year = year;
            this.make = make;
            this.model = model;
            this.price = price; 
                       

        }

        public override string ToString()
        {

            return "Year: " + Year + " Make: " + Make + " Model: " + Model + " Price: " + price;
        }

    }
}
