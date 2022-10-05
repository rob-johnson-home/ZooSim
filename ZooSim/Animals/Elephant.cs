using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Animals
{
    public class Elephant :Animal
    {
        public Elephant(string name) : base (name)
        {
            SetDeathDelay(1);
            SetDeathThreshold(70);
        }

        private void SetDeathDelay(int v)
        {
            DeathDelay = v;
        }

        public override bool IsAlive()
        {
            return (Health >= DeathThreshold || 
                DeathDelay >= 0);
        }

        public override void ReduceHealthByPercent(float d)
        {
            base.ReduceHealthByPercent(d);
            if (Health < 70) DeathDelay--;
        }

        public override string GetStatus()
        {
            return (IsAlive() ? "Alive" : "Dead") + " and " + (Health >= DeathThreshold ? "mobile" : "immobile") ;
        }

    }
}
