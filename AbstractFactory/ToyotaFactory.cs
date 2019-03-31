using System;

namespace AbstractFactory
{
    //Abstract Factory
    abstract class ToyotaFactory
    {
        abstract public Body MakeBody();
        abstract public Engine MakeEngine();
    }

    //Concrete Factory A
    class YarisFactory : ToyotaFactory
    {
        public override Body MakeBody()
        {
            return new YarisBody();
        }

        public override Engine MakeEngine()
        {
            return new YarisEngine();
        }
    }

    // Concrete Factory B
    class AvensisFactory : ToyotaFactory
    {
        public override Body MakeBody()
        {
            return new AvensisBody();
        }

        public override Engine MakeEngine()
        {
            return new AvensisEngine();
        }
    }

    // Abstract Product A
    abstract class Body
    {
        public int Weight { get; protected set; }
    }

    // Concrete Product A1
    class YarisBody : Body
    {
        public YarisBody()
        {
            Weight = 400;
        }
    }

    // Concrete Product A2
    class AvensisBody : Body
    {
        public AvensisBody()
        {
            Weight = 500;
        }
    }

    // Abstract Product B
    abstract class Engine
    {
        public abstract void Start();
    }

    // Concrete Product B1
    class YarisEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Vroom!");
        }
    }

    // Concrete Product B2
    class AvensisEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Vroooooooom!!");
        }
    }

    class Car
    {
        public Body Body { get; }
        public Engine Engine { get; }

        public Car(Body body, Engine engine)
        {
            Body = body;
            Engine = engine;
        }

        public void StartEngine()
        {
            Engine.Start();
        }

        public override string ToString()
        {
            return $"{Body} with a weight of {Body.Weight}kg and an {Engine}";
        }
    }

    // Client
    class ToyotaAssemblyLine
    {
        private ToyotaFactory _factory;

        public ToyotaAssemblyLine(ToyotaFactory factory)
        {
            _factory = factory;
        }

        public Car AssembleCar()
        {
            var body = _factory.MakeBody();
            var engine = _factory.MakeEngine();
            return new Car(body, engine);
        }
    }
}
