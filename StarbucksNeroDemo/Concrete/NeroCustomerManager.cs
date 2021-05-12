using NeroStarbucks.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeroStarbucks.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {

        private IPersonCheckService _customerCheckService;

        public NeroCustomerManager(IPersonCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
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
