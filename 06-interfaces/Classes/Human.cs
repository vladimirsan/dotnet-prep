namespace _06_interfaces.Classes
{
    using System;

    using _06_interfaces.Interfaces;

    class Human : ISpeak
    {
        public void Live()
        {
             Console.WriteLine("I'm living!");
        }
    
        public void Eat()
        {
             Console.WriteLine("I'm eating all the yummy foods");
        }

        public virtual void Speak()
        {
             Console.WriteLine("I'm eager to live my life to the fullest!");
        }

    }
}
