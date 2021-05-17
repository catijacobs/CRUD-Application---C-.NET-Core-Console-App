using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppCRUDComponent.Data;
using ConsoleAppCRUDComponent.Views;

namespace ConsoleAppCRUDComponent
{
    public static class EmployeeObjectFactory
    {
        public static Employee CreateNewEmployeeObject(string firstName, string lastName, decimal annualSalary, char gender, bool isManager)
        {
            return new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                AnnualSalary = annualSalary,
                Gender = gender,
                IsManager = isManager

            };

        }

        public static EmployeeRecordsView EmployeeRecordsViewObject(Employees employees)
        {
            return new EmployeeRecordsView(employees);
        }
    }
}
