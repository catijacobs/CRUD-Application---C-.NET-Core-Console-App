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
            SeedData();
        }

        public Employee this[int index]
        {
            get
            {
                return (Employee)_employeeList[index];
            }

        }

        private void SeedData()
        {
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Alberto", "Silva", 60000, 'm', false));
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Rita", "Pires", 97000, 'f', false));
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Ze", "Santos", 85000, 'm', true));
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Ana", "David", 75000, 'f', false));

        }

        public void Add(Employee employee)
        {
            _employeeList.Add(employee);
        }

        public void Update(Employee employee, string firstName, string lastName, decimal annualSalary, char gender, bool isManager)
        {
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.AnnualSalary = annualSalary;
            employee.Gender = gender;
            employee.IsManager = isManager;
        }

        public void Delete(int index)
        {
            _employeeList.RemoveAt(index);
        }

        public int Find(int id)
        {
            int count = 0;
            foreach (Employee employee in _employeeList)
            {
                if(employee.Id == id)
                {
                    return count;
                }
                count++;
            }
            return -1;
        }
        public int Count()
        {
            return _employeeList.Count;
        }

        public IEnumerator GetEnumerator()
        {
            return _employeeList.GetEnumerator();
        }
    }
}
