using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Animals
{
    public class GiraffeFactory : AnimalFactory
    {
        public override IAnimal Create(string name)
        {
            return new Giraffe(name);
        }
    }
}
