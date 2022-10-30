using System;
using System.Collections.Generic;
using System.Text;

namespace RepetClass.Models
{
    public class Shark : Fish
    {
        public string Color { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Shark eating");
        }
    }
}
