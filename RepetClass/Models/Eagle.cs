using System;
using System.Collections.Generic;
using System.Text;

namespace RepetClass.Models
{
    public class Eagle : Bird
    {
        public string Color { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eagle eating");
        }
    }
}
