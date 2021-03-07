using System;
using MainApp.Services;

namespace MainApp
{
    interface IStorageService<T>
    {
        void Save(T data);
    }

    class DBCustomerStorage : IStorageService<Customer>
    {
        public void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " has added to database.");
        }
    }

    class JsonStorage<T> : IStorageService<T>
    {
        public void Save(T data)
        {
            Console.WriteLine(data.ToString() + "saved to json");
        }
    }

    class JsonCustomerStorage : JsonStorage<Customer>
    {

    }


    interface ICustomerManager
    {
        void Register(Customer customer);
    }

    abstract class BaseCustomerManager : ICustomerManager
    {
        private IStorageService<Customer> _storage;

        public BaseCustomerManager(IStorageService<Customer> storage) => _storage = storage;

        public virtual void Register(Customer customer)
        {
            _storage.Save(customer);
        }
    }

    class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICheckCardNoService _cardNoChecker;

        public StarbucksCustomerManager(IStorageService<Customer> storage, ICheckCardNoService checkService)
            : base(storage) 
        {
            _cardNoChecker = checkService;
        }

        public override void Register(Customer customer)
        {
            if (_cardNoChecker.CheckAzeCardNo(customer.CardNo))
                base.Register(customer);
            else
                throw new Exception("Invalid card number!");
        }
    }

    class NeroCustomerManager : BaseCustomerManager
    {
        public NeroCustomerManager(IStorageService<Customer> storage) 
            : base(storage) { }

    }

    

    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager manager = new StarbucksCustomerManager(
                new JsonCustomerStorage(), new CheckCardNoService());

            manager.Register(new Customer
            {
                FirstName = "Resad",
                CardNo = "1234"
            });
        }
    }
}
