
using MernisServiceReference;
using NeroStarbucks;
using NeroStarbucks.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

namespace StarbucksNeroDemo.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.TcNo), customer.firstName, customer.lastName, customer.dateYear.Year).Result;
            
            bool check = result.Body.TCKimlikNoDogrulaResult;
            return check;

        }
    }
}
