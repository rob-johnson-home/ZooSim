using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Animals
{
    public class HealthVisitor : Visitor
    {
        public override string Visit(IAnimal animal)
        {
            return $"{animal.GetName()} the {animal.GetType().Name} has {animal.GetHealth()}% health and is {(animal.GetStatus())}";
        }
    }
}
