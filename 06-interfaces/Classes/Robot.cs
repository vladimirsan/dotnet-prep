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

        public string Speak()
        {
            return "console.log('Am I alive?')";
        }

        public string InsuranceInformation()
        {
            throw new NotImplementedException();
        }

        public void Drive(IDrivable drivable)
        {
            throw new NotImplementedException();
        }

        void ISpeak.Speak()
        {
            throw new NotImplementedException();
        }

        public string DriversLicense { get; set; }
    }
}
