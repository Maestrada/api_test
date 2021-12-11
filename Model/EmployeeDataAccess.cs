using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_test.Model
{
    public class EmployeeDataAccess
    {
        public List<Employee> GetEmployeeList()
        {

            List<Employee> employees = new List<Employee>();

            //aca iria un acceso a datos/Componente o cualquier otra operacion

            Employee emp1 = new Employee() { employeeID = 1, name = "Pedro", lastName = "Perez", type = "Developer Senior I" };
            Employee emp2 = new Employee() { employeeID = 2, name = "Maria", lastName = "Rodriguez", type = "QA Tester" };
            Employee emp3 = new Employee() { employeeID = 3, name = "Miguel", lastName = "Fajardo", type = "Project Manager" };

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            return employees;

        }
    }
}
