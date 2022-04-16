using GameBussiness.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness.İnterface
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
