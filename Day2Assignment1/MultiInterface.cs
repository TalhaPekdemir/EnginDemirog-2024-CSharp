namespace Assignment1
{
    internal class MultiInterface
    {}
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void Salary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager has ate.");
        }

        public void Salary()
        {
            Console.WriteLine("Manager has paid.");
        }

        public void Work()
        {
            Console.WriteLine("Manager is working.");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker has ate.");
        }

        public void Salary()
        {
            Console.WriteLine("Worker has paid.");
        }

        public void Work()
        {
            Console.WriteLine("Worker is working.");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Manager is working.");
        }
    }
}
