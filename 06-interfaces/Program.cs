using _06_interfaces.Classes;
using _06_interfaces.Interfaces;
using System;

namespace _06_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Student student = new Student();
            Robot robot = new Robot();

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            // ------------------------------------------------------------
            // Using objects as interfaces
            // ------------------------------------------------------------
            IDrive iDrive = student;
            iDrive.Drive(car);
            iDrive.Drive(bicycle);
            // Vinicio - now change this to a robot
            // ------------------------------------------------------------
            ISpeak[] interfaceArray = new ISpeak[3];
            interfaceArray[0] = human;
            interfaceArray[1] = student;
            interfaceArray[2] = robot;

            Conference(interfaceArray);
        }

        static void Conference(ISpeak[] speakers)
        {
            Console.WriteLine("--------------------------");
            foreach(ISpeak speaker in speakers)
            {
                speaker.Speak();
            }
            Console.WriteLine("--------------------------");
        }
    }
}
