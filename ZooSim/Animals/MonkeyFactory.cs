using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Animals
{
    public class MonkeyFactory : AnimalFactory
    {
        public override IAnimal Create(string name)
        {
            return new Monkey(name);
        }
    }
}
