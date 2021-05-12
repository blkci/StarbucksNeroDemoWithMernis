using System;
using System.Collections.Generic;
using System.Text;

namespace NeroStarbucks.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.firstName);
        }
    }
}
