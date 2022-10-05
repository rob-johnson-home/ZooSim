using System.Collections.Generic;

namespace ZooSim
{
    public interface IZoo
    {
        void NextHour();
        List<string> GetStatus();
        List<string> FeedTheAnimals();
    }
}