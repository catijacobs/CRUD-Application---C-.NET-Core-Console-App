using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCRUDComponent.Data
{
    public class Employees
    {
        ArrayList _employeeList = null;

        public Employees()
        {
            _employeeList = new ArrayList();
        }

        private void SeedData()
        {
            this.Add();
        }

        public void Add(Employee employee)
        {
            _employeeList.Add(employee);
        }
    }
}
