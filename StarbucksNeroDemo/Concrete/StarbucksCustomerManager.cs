using NeroStarbucks.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeroStarbucks.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
       
        private IPersonCheckService _personCheckService;

        public StarbucksCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {

                base.Save(customer);
            }
            else
            {
                Console.WriteLine("No man");
            }
        }

    }
}
