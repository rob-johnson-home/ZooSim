using System;
using System.Threading;

namespace ZooSim
{
    class Program
    {
        private static ZooManager _zooMan = new ZooManager();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Zoo!");
            while (true)
            {

                DisplayAnimalStatusAndAskAboutFeeding();
                Thread.Sleep(20000);
                var kp = Console.KeyAvailable;

                _zooMan.PassTime();
                if (kp)
                {
                    RunTheFeedingRoutine();
                    Console.ReadKey();
                }
            }
        }

        private static void DisplayAnimalStatusAndAskAboutFeeding()
        {
            var time = _zooMan.GetZooTime();
            var status = _zooMan.GetZooStatus();
            Console.WriteLine(time);
            Console.WriteLine(string.Join("\r\n", status));
            Console.WriteLine("hit any key if you wan to feed the animals");
        }

        private static void RunTheFeedingRoutine()
        {
            var status = _zooMan.FeedTheAnimals();
            Console.WriteLine(string.Join("\r\n", status));
        }
    }
}
