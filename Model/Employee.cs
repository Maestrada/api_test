using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_test.Model
{
    public class Employee
    {
        public Employee()
        {
        }

        public int employeeID { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string type { get; set; }
    }
}
