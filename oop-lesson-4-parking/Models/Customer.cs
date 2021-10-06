using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.Models
{
    public class Customer
    {
        public int hoursParked { get; set; }
        public string Registration { get; set; }

        public Customer(string registration,int hoursparked )
        {
            Console.WriteLine("I am the Customer()");
            hoursParked = hoursparked;
            Registration = registration;
        }
        public override string ToString()
        {
            return "I am the Customer";
        }
    }
}
