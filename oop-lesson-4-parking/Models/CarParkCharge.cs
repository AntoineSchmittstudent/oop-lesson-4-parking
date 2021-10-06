using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.Models
{
    public class CarParkCharge
    {
        

        public int minFee { get; set; }
        public int minHours { get; set; }
        public CarParkCharge(int minfee=2, int minhours=3)
        {
            Console.WriteLine("I am the CarParkCharge()");
            minFee = minfee;
           minHours = minhours;
        }
        public override string ToString()
        {
            return "I am the CarParkCharge";
        }
        public int CalculateCharge(int hoursParked)
        {
            int calculatedFee = hoursParked < minHours ? minFee : hoursParked * minFee;
            return calculatedFee;
        }
    }
}
