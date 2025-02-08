using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfacesLab3
{
    public abstract class Animal
    {
        // Properties
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

        // Abstract method
        public abstract void Eat();
    }
}
