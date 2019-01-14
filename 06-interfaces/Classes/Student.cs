namespace _06_interfaces.Classes
{
    using System;

    using _06_interfaces.Interfaces;

    class Student : Human, IDrive
    {
        public string DriversLicense { get; set; }
        public string InsuranceInformation { get; set; }

        public void Study()
        {
             Console.WriteLine("I'm studying all the content!");
        }

        public override void Speak()
        {
            Console.WriteLine("(As Kylo Ren) I want to be free of this pain");
        }

        public void Drive(IDrivable drivable)
        {
            Console.WriteLine("I'm about to drive!");
            drivable.Start();
            Console.WriteLine("I'm about to turn");
            drivable.ChangeOrientation(45);
            Console.WriteLine("I'm about to stop");
            drivable.Stop();
        }
    }
}
