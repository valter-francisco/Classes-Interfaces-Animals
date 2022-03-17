using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Interfaces.Animals
{
    internal class Sheep : IAnimal
    {
        public void Talk()
        {
            Console.WriteLine("The sheep goes: méé méé!");
        }
    }
}
