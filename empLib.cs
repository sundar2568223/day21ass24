using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day21assg24
{
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
    }
}