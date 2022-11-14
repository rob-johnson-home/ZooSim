using System;

namespace ZooSim.Animals
{
    /// <summary>
    /// 
    /// abstract animal class implements some default behaviour for animals
    /// </summary>

    public abstract class Animal : IAnimal
    {
        private float _health;
        private float _deathThreshold;
        private float _timeDeathThresholdReached;
        private float _deathDelay;
        private string _name;

        protected float Health { get => _health; }
        protected float DeathThreshold { get => _deathThreshold; }
        protected float DeathDelay { get => _deathDelay; set => value = _deathDelay; }
        protected float TimeDeathThresholdReached { get => _timeDeathThresholdReached; }
        protected string Name { get => _name;  }

        public Animal(string name)
        {
            SetName(name);
            SetHealth(100);
        }

        public virtual void SetName(string name)
        {
            _name = name;
        }

        public virtual string GetName()
        {
            return Name;
        }

        public virtual void SetHealth(int v)
        {
            _health = v;
        }

        public virtual void SetDeathThreshold(int p)
        {
            _deathThreshold = p;
        }

        public virtual void ReduceHealthByPercent(float d)
        {
            float reduceBy = Health * d / 100;
            _health = Health - reduceBy;

        }

        public virtual void Feed(float d)
        {
            float increaseBy = Health * d / 100;
            _health = Math.Min(Health + increaseBy, 100);

        }
        public virtual string GetHealth()
        {
            return $"{Health}";
        }
        public virtual string GetStatus()
        {
            return IsAlive() ? "Alive" : "Dead";
        }
        public virtual bool IsAlive()
        {
            return Health >= DeathThreshold;
        }
        public string Accept(Visitor visitor)
        {
            return visitor.Visit(this);
        }

    }
}
        