using System;
using System.Collections.Generic;
using System.Text;

namespace _06_interfaces.Classes
{
    using _06_interfaces.Interfaces;

    public class Robot : IDrive, ISpeak
    {
        public int SerialNumber { get; set; }
        public string Name { get; set; }

        public void Speak()
        {
            Console.WriteLine("console.log('Am I alive/)");
        }

        public string InsuranceInformation { get; set; }

        public void Drive(IDrivable drivable)
        {

            Console.WriteLine("I'm about to drive!");
            drivable.Start();
            Console.WriteLine("I'm about to turn");
            drivable.ChangeOrientation(45);
            Console.WriteLine("I'm about to turn");
            drivable.ChangeOrientation(45);
            Console.WriteLine("I'm about to turn");
            drivable.ChangeOrientation(45);
            Console.WriteLine("I'm about to turn");
            drivable.ChangeOrientation(45);
        }

        public string DriversLicense { get; set; }
    }
}
