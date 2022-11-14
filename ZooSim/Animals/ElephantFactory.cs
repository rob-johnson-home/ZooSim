using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Animals
{
    public class ElephantFactory : AnimalFactory
    {
        public override IAnimal Create(string name)
        {
            return new Elephant(name);
        }
    }
}
