
namespace _06_interfaces.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using _06_interfaces.Interfaces;

    public class Car : IDrivable
    {
        public string Engine { get; set; }
        public string SteeringWheel { get; set; }

        public string[] Wheels()
        {
            string[] wheels = { "Wheel", "Wheel", "Wheel", "Wheel" };
            return wheels;
        }

        public void Start()
        {
            Console.WriteLine("CAR : Starting");
        }

        public void Stop()
        {
            Console.WriteLine("CAR : Stopping");
        }

        public void ChangeOrientation(float angle)
        {
            Console.WriteLine($"CAR : Changing our orientation by {angle} degrees");

        }
    }
}
