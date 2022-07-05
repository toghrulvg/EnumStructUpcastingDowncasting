using System;
using System.Collections.Generic;
using System.Text;

namespace EnumStructUpcastingDowncasting.Models
{
    class Eagle : Bird
    {
        public int age { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eagle eating");
        }
    }
}
