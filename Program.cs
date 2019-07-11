using System;

namespace list_employees
{
    class Program
    {
        static void Main(string[] args)
        {
            var company1 = new Company() {
                Name = "HCA",
                Founded = DateTime.Now,
            };   
            var employee1 = new Employee() {
                firstName = "Heather",
                lastName = "Cleland",
                Title = "Mrs.",
                startingDate = DateTime.Now
            };
            var employee2 = new Employee() {
                firstName = "Shelley",
                lastName = "Arnold",
                Title = "Mrs.",
                startingDate = DateTime.Now
            };
            var employee3 = new Employee() {
                firstName = "Addam",
                lastName = "Joor",
                Title = "Mr.",
                startingDate = DateTime.Now
            };

            company1.employeesInCompany.Add(employee1);
            company1.employeesInCompany.Add(employee2);
            company1.employeesInCompany.Add(employee3);

            company1.ListEmployees();
        }
    }
}
