using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppCRUDComponent.Data;

namespace ConsoleAppCRUDComponent.Views
{
    public class EmployeeRecordsView
    {
        private Employees _employees = null;

        public EmployeeRecordsView(Employees employees)
        {
            _employees = employees;
        }

        public void RunRecordsView()
        {
            Console.WriteLine(EmployeeCommonOutputText.GetColumnHeadings());
            Console.WriteLine();

            foreach(Employee emp in _employees)
            {
                Console.Write(emp.GetEmployeeInformation());
            }
        }
    }
}
