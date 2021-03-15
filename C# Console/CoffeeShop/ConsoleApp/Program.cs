using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using MainApp.Services;

namespace MainApp
{
    interface IStorageService<T>
    {
        void Save(T data);

        IList<T> Load();
    }

    class DBCustomerStorage : IStorageService<Customer>
    {
        private string path;

        public DBCustomerStorage(string path)
        {
            this.path = path;
        }

        public IList<Customer> Load()
        {
            throw new NotImplementedException(); // database-le islemeyi bilmirik
        }

        public void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + $" has added to {path}.");
        }
    }

    class JsonStorage<T> : IStorageService<T>
    {
        private string path;
        private List<T> list;

        public JsonStorage(string path)
        {
            this.path = path;

            if (File.Exists(path))
            {
                ReadFromFile();
            }
            else list = new List<T>();
        }

        public IList<T> Load()
        {
            return list;
        }

        public void Save(T data)
        {
            list.Add(data);
            WriteToFile();
        }

        private void ReadFromFile()
        {
            string json = File.ReadAllText(path);
            list = JsonSerializer.Deserialize<List<T>>(json);
        }

        private void WriteToFile()
        {
            string json = JsonSerializer.Serialize(list);
            File.WriteAllText(path, json);
        }
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

        public void PrintAllCustomers()
        {
            var customers = _storage.Load();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
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
                new JsonStorage<Customer>("StarBucksJsonStorage.json"), new CheckCardNoService());

            manager.Register(new Customer
            {
                ID = 10,
                FirstName = "Resad",
                LastName = "Mememdov",
                BirthDate = new DateTime(2003, 10, 21),
                CardNo = "AA03270ui48"
            });

        }
    }
}
