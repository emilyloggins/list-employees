using System;
using System.Collections.Generic;

namespace list_employees
{
    class Company
    {
        public string Name { get; set; }
        public DateTime Founded { get; set; }
        public List<Employee> employeesInCompany = new List<Employee>();

        // Method that outputs employee list to console
        public void ListEmployees() {
            foreach (Employee employee in employeesInCompany) {
                Console.WriteLine($"{employee.firstName} {employee.lastName}");
            }
        }
    }
}