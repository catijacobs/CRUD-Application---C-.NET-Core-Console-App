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
            EmployeeRecordsView employeeRecordView = EmployeeObjectFactory.EmployeeRecordsViewObject(employees);


            Console.ReadKey();
        }
    }
}
