using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Animals
{
    public class Giraffe : Animal
    {
        public Giraffe(string name) : base (name)
        {
            SetDeathThreshold(50);
        }


    }
}
