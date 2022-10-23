using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        //Fake mernis
        async Task<bool> ICustomerCheckService.CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
