using System;
namespace ConsoleUI
{
    public class Motorcyle : Vehicle
    {
        public Motorcyle()
        {
        }
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"This motorcyle can go up to 300mph!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This motorcyle needs a driver to operate.");
        }
    }
}

