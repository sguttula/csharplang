using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //public virtual Employee Leader { get; set; }

        public override string ToString()
        {
            return $"[{Id}, {Name}, {Age}]";
        }
    }
}
