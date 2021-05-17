using ConsoleAppCRUDComponent;
using ConsoleAppCRUDComponent.Data;
using ConsoleAppCRUDComponent.Views;
using System;

namespace ConsoleAppCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            EmployeeRecordsView employeeRecordsView = EmployeeObjectFactory.EmployeeRecordsViewObject(employees);

            Console.WriteLine(EmployeeCommonOutputText.GetApplicationHeading());

            employeeRecordsView.RunRecordsView();

            Console.ReadKey();
        }
    }
}
