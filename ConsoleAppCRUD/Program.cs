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
            bool blnEnd = false;


            Employees employees = new Employees();

            EmployeeRecordsView employeeRecordsView = EmployeeObjectFactory.EmployeeRecordsViewObject(employees);

            while (!blnEnd)
            {
                Console.Clear();

                Console.WriteLine(EmployeeCommonOutputText.GetApplicationHeading());

                employeeRecordsView.RunRecordsView();

                Console.WriteLine();
                Console.WriteLine();

                ConsoleKey instructionKey = Console.ReadKey().Key;

                switch (instructionKey)
                {
                    case ConsoleKey.C:
                        Console.Clear();
                        Console.WriteLine("Create funcionality not yet implemented");
                        break;

                    case ConsoleKey.R:
                        Console.Clear();
                        Console.WriteLine("Read funcionality not yet implemented");
                        break;

                    case ConsoleKey.U:
                        Console.Clear();
                        Console.WriteLine("Update funcionality not yet implemented");
                        break;

                    case ConsoleKey.D:
                        Console.Clear();
                        Console.WriteLine("Delete funcionality not yet implemented");
                        break;

                    default:
                        blnEnd = true;
                }

            }

          

            Console.ReadKey();
        }
    }
}
