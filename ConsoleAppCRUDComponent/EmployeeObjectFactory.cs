using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppCRUDComponent.Data;

namespace ConsoleAppCRUDComponent
{
    public static class EmployeeObjectFactory
    {
        public static Employee CreateNewEmployeeObject(string firstName, string lastName, decimal annualSalary, char gender, bool isManager)
        {
            return new Employee(firstName, lastName, annualSalary, gender, isManager);
        }
    }
}
