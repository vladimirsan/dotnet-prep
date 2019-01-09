namespace _06_interfaces.Classes
{
    using System;
    using _06_interfaces.Interfaces;

    class Bicycle : IDrivable
    {
        public string Handlebars { get; set; }

        public string[] Wheels()
        {
            string[] wheels = { "Wheel", "Wheel" };
            return wheels;
        }

        public void Start()
        {
            Console.WriteLine("BIKE : Starting");
        }

        public void Stop()
        {
            Console.WriteLine("BIKE : Stopping");
        }

        public void ChangeOrientation(float angle)
        {
            Console.WriteLine($"BIKE : Changing orientation by {angle} degrees");
        }
    }
}
