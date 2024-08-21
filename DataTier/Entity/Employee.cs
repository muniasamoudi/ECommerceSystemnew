using BussniseTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier.Entity
{
    internal class Employee : Person
    {
        public int employeeId { get; set; }
        public Employee(int id, string name, string city) : base(name, city)
        {
            employeeId = id;

        }
    }
}
