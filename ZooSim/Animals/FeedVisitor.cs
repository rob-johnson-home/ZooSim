using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Animals
{
    /// <summary>
    /// the Feed visitor can feed a random amount to an animal
    /// </summary>
    public class FeedVisitor : Visitor
    {
        public override string Visit(IAnimal animal)
        {

            var r = new Random();
            var food = r.Next(10, 25);
            animal.Feed(food);
            return $"Fed {animal.GetName()} with {food}%";
        }
    }
}
