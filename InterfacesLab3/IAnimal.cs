using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesLab3;


namespace InterfacesLab3
{

    //public interface 
    public interface IAnimal
    {
        // Properties getters and setters
        string Name { get; set; }
        string Colour { get; set; }
        int Height { get; set; }
        int Age { get; set; }

        //Methods
        void Eat();       
        string Cry();     
    }
}



