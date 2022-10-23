using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Adapters;
using InterfaceAndAbstractDemo.Concrete;
using InterfaceAndAbstractDemo.Entities;
using System;

namespace InterfaceAndAbstractDemo
{
    partial class Program
    {

        static void Main(string[] args)
        {
            //WithoutMernis();

            //FakeMernis();


            //With real mernis
            BaseCustomerManager starbucksCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            starbucksCustomerManager.Save(new Customer() { DateOfBirth = new DateTime(1999, 9, 19), FirstName = "Fatih", LastName = "Hazır", NationalityId = "9999999", Id = 1 });


            Console.ReadLine();
        }

        private static void WithoutMernis()
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer() { DateOfBirth = new DateTime(1999, 9, 19), FirstName = "Fatih", LastName = "Hazır", NationalityId = "111111111", Id = 1 });
        }

        private static void FakeMernis()
        {
            BaseCustomerManager starbucksCustomerManager = new StarbucksCustomerManager(new CustomerCheckManager());
            starbucksCustomerManager.Save(new Customer() { DateOfBirth = new DateTime(1999, 9, 19), FirstName = "Fatih", LastName = "Hazır", NationalityId = "9999999", Id = 1 });
        }
    }
}
