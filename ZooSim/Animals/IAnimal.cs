namespace ZooSim.Animals
{
    public interface IAnimal
    {
        string GetHealth();
        string GetStatus();
        string GetName();
        bool IsAlive();
        void ReduceHealthByPercent(float d);
        string Accept(Visitor visitor);
        void Feed(float d);
    }
}