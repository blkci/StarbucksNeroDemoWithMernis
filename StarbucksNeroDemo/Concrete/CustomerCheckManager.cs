using NeroStarbucks.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeroStarbucks.Concrete
{
    class CustomerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
