using GameBussiness.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness.İnterface
{
    public interface ICustomerCheckService
    {
        bool IsCustomerCheck(Customer customer);
    }
}
