using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_lesson_4_parking.Models;

namespace oop_lesson_4_parking.Test
{
    public class Driver
    {
        public Driver()
        {
            Console.WriteLine("I am the code Driver");
        }
        public void CreateObjects()
        {
            CarPark carPark = new CarPark();
            carPark.listofcustomers.Add(new Customer("a",2));
            carPark.listofcustomers.Add(new Customer("b",3));
            carPark.listofcustomers.Add(new Customer("c",4));
            carPark.listofcustomers.Add(new Customer("d",5));
            carPark.listofcustomers.Add(new Customer("e",6));
            carPark.CalculateCharge();



            CarParkCharge carParkCharge = new CarParkCharge();
            Customer customer = new Customer("f",7);
            //call ToString()
            Console.WriteLine(carPark.ToString());
            Console.WriteLine(carParkCharge.ToString());
            Console.WriteLine(customer.ToString());

        }
       
    }
}
