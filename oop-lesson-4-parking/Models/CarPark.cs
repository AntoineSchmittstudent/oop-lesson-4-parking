using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.Models
{
    public class CarPark
    {
        public List<Customer> listofcustomers = new List<Customer>();
        public CarParkCharge carParkCharge = new CarParkCharge();
        public CarPark()
        {
            Console.WriteLine("I am the CarPark()");
        }
        public override string ToString()
        {
            return "I am the CarPark";
        }
        public void CalculateCharge()
        {
            foreach(Customer customer in listofcustomers)
            {
                int calculatedcharge = carParkCharge.CalculateCharge(customer.hoursParked);
                Console.WriteLine($"Calculating charges : \nThe charge is {calculatedcharge} for registration : {customer.Registration}");
            }
        }
    }
}
