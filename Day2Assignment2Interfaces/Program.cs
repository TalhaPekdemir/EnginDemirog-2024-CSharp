namespace Day2Assignment2Interfaces;

internal class Program
{
    static void Main(string[] args)
    {
        IPersonManager customerManager = new CustomerManager();
        //customerManager.Add();

        IPersonManager employeeManager = new EmployeeManager();
        //employeeManager.Add();

        IPersonManager internManager = new InternManager();

        ProjectManager projectManager = new ProjectManager();
        projectManager.Add(customerManager);
        projectManager.Add(employeeManager);
        projectManager.Add(internManager);
    }

    // instance oluşturulamaz
    interface IPersonManager
    {
        void Add();
        void Update();
    }

    // class     -> inherits
    // interface -> implements
    class CustomerManager:IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Added customer");
        }
        public void Update()
        {
            Console.WriteLine("Updated customer");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Added employee");
        }
        public void Update()
        {
            Console.WriteLine("Updated employee");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Added intern");
        }
        public void Update()
        {
            Console.WriteLine("Updated intern");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
