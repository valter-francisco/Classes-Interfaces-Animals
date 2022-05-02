using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Interfaces.Animals
{
    internal class Pig : Animal, IAnimal
    {
        public void Talk()
        {
            Console.WriteLine("The pig goes: oinc oinc!");
        }
    }
}
