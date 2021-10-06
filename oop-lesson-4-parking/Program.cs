using System;
using System.Collections.Generic;
using oop_lesson_4_parking.Test;

namespace oop_lesson_4_parking
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Car Park Solution\n");
            Driver driver = new Driver();
            driver.CreateObjects();
        }
    }
}
