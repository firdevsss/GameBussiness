using GameBussiness.Entities;
using GameBussiness.İnterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool IsCustomerCheck(Customer customer)
        {
            return true;
        }
    }
}
