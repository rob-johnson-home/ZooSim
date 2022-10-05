namespace ZooSim.Animals
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal Create(string name);
    }
}