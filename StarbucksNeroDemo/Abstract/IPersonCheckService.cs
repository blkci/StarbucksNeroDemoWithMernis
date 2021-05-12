using System;
using System.Collections.Generic;
using System.Text;

namespace NeroStarbucks.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
