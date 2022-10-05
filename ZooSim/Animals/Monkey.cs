using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Animals
{
    public class Monkey : Animal
    {
        public Monkey(string name) : base (name)
        {
            SetDeathThreshold(30);
        }


    }
}
