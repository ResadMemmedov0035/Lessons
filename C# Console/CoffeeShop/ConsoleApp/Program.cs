using System;
using System.Collections.Generic;

namespace MainApp
{
    interface ICustomerManager
    {
        void Register(Customer customer);
    }

    interface ICheckCardNoService
    {
        bool CheckAzeCardNo(string cardNo);
    }

    class CheckCardNoService : ICheckCardNoService
    {
        public bool CheckAzeCardNo(string cardNo)
        {
            return true;
        }
    }

    interface IStorageService<T>
    {
        void Save(T data);
        
    }

    class CustomerStorage : IStorageService<Customer>
    {
        public void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " added to database.");
        }
    }

    abstract class BaseCustomerManager : ICustomerManager
    {
        private IStorageService<Customer> _storage;

        protected ICheckCardNoService _cardNoChecker;

        public BaseCustomerManager()
        {
            _storage = new CustomerStorage();
            _cardNoChecker = new CheckCardNoService();
        }

        public virtual void Register(Customer customer)
        {
            _storage.Save(customer);
        }
    }

    class StarbucksCustomerManager : BaseCustomerManager
    {
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

    }


    /// <Exercise>
    /// Ferqli storage-ler ucun kod yazin.
    /// </Exercise>

    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager manager = new StarbucksCustomerManager();

            manager.Register(new Customer
            {
                FirstName = "Resad",
                CardNo = "1234"
            });
        }
    }
}
