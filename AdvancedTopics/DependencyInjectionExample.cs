using System;

namespace AdvancedTopics
{
    public class DependencyInjectionExample
    {
        public static void Run()
        {
            IService service = new Service();
            Client client = new Client(service);
            client.PerformTask();
        }
    }

    public interface IService
    {
        void Execute();
    }

    public class Service : IService
    {
        public void Execute() => Console.WriteLine("Dich vu dang thuc thi...");
    }

    public class Client
    {
        private readonly IService _service;

        public Client(IService service)
        {
            _service = service;
        }

        public void PerformTask() => _service.Execute();
    }
}
