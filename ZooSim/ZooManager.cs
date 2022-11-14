using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim
{

    public class ZooManager
    {
        private int _zooTime = 0;
        private IZoo _myZoo = new Zoo();

        public void PassTime()
        {
            // time passes
            _zooTime++;
            _myZoo.NextHour();
            
        }

        
        public List<string> GetZooStatus()
        {
            return _myZoo.GetStatus();
        }


        public List<string> FeedTheAnimals()
        {
            return _myZoo.FeedTheAnimals();
        }

        internal string GetZooTime()
        {
            return $"{_zooTime} hours have passed";
        }
    }
}
