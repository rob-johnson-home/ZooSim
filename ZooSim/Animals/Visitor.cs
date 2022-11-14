using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Animals
{
    public abstract class Visitor
    {
        public abstract string Visit(IAnimal animal);
    }
}
