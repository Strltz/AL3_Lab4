using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    public class Car
    {
        public string Name { get; set; }
        public int ProductionYear { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string name, int year, int speed)
        {
            Name = name;
            ProductionYear = year;
            MaxSpeed = speed;
        }

        public void print_all()
        {
            Console.WriteLine($"{Name} {ProductionYear} {MaxSpeed}\n");
        }
    }
}
