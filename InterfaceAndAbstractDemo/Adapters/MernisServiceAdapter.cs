using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;

namespace InterfaceAndAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {

        async Task<Boolean> ICustomerCheckService.CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            TCKimlikNoDogrulaResponse responseBody = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
            return responseBody.Body.TCKimlikNoDogrulaResult;
        }
    }
}
