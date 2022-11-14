using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZooSim.Animals;

namespace ZooSim
{

    public class Zoo : IZoo
    {
        // zoos have animals
        private List<IAnimal> _animals = new List<IAnimal>();


        public Zoo()
        {
            BuildZoo();
        }

        private void BuildZoo()
        {
            AnimalFactory ef = new ElephantFactory();
            AnimalFactory mf = new MonkeyFactory();
            AnimalFactory gf = new GiraffeFactory();

            
            _animals.Add(ef.Create("Ellie"));
            _animals.Add(mf.Create("Millie"));
            _animals.Add(gf.Create("Gerald"));

            _animals.Add(ef.Create("Edna"));
            _animals.Add(mf.Create("Marcus"));
            _animals.Add(gf.Create("George"));

            _animals.Add(ef.Create("Earl"));
            _animals.Add(mf.Create("Mike"));
            _animals.Add(gf.Create("Gareth"));

            _animals.Add(ef.Create("Ethan"));
            _animals.Add(mf.Create("Molly"));
            _animals.Add(gf.Create("Garr"));

            _animals.Add(ef.Create("Evan"));
            _animals.Add(mf.Create("Mavis"));
            _animals.Add(gf.Create("Goro"));

        }

        public List<string> GetStatus()
        {
            List<string> health = new List<string>();
            Visitor v = new HealthVisitor();
            foreach (IAnimal animal in _animals.Where(a => a.IsAlive()))
            {
                health.Add(animal.Accept(v));
            }
            return health;
        }

        // run the zoo routines, zoo assumes 1 hour has passed since la
        public void NextHour()
        {
            var r = new Random();
            foreach (Animal a in _animals.Where(a => a.IsAlive()))
            {
                var healthDeduction = r.Next(0, 20);
                a.ReduceHealthByPercent(healthDeduction);
            }
        }

        public List<string> FeedTheAnimals()
        {
            List<string> food = new List<string>();

            Visitor v = new FeedVisitor();
            foreach (IAnimal animal in _animals.Where(a => a.IsAlive()))
            {
                food.Add(animal.Accept(v));
            }
            return food;
        }



    }
}
