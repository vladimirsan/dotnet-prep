using System;
using System.Collections.Generic;
using System.Text;

namespace _06_interfaces.Interfaces
{
    interface IDrive
    {
        // Vinicio - interfaces can have properties
        string DriversLicense { get; set; }

        // Vinicio - and methods (also known as member functions)
        string InsuranceInformation { get; set; }

        void Drive(IDrivable drivable);
    }
}