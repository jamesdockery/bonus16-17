using System;
using System.Collections.Generic;

namespace carclassbonus16
{
    public class UsedVehicle : Vehicle
    {


        private double mileage;
        public double Mileage
        {
            get
            {
                return mileage;
            }
        }
       

        public UsedVehicle(int year, string make, string model, double price, double mileage) : base(year, make, model, price)
        {
            this.mileage = mileage;
        }

        public override string ToString()
        {
      
                return "Year: " + Year + " Make: " + Make + " Model: " + Model + " Price: " + price + "Mileage: " + mileage + " Used ";
          
           
        }
    }
}
