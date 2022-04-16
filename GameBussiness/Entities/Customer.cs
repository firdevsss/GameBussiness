using GameBussiness.İnterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameBussiness.Entities
{
    public class Customer:IEntity
    {
        public string IdentitiyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Balance { get; set; }
    }
}
