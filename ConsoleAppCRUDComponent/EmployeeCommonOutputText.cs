using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCRUDComponent
{
    public class EmployeeCommonOutputText
    {
        public static string GetColumnHeadings()
        {
            string id = "Id";
            string firstName = "First Name";
            string lastName = "Last Name";
            string annualSalary = "Annual Salary";
            string gender = "Gender";
            string manager = "Manager";
            
            string heading = $"{id.ToString().PadRight(6)}\t{firstName.PadRight(15)}\t{lastName.PadRight(15)}\t{annualSalary.ToString().PadRight(15)}\t{gender.ToString().PadRight(6)}\t{manager.ToString().PadRight(7)}\n";
            heading += $"{new string('_', 6)}\t{new string('_', 15)}\t{new string('_', 15)}\t{new string('_', 15)}\t{new string('_', 6)}\t{new string('_', 7)}\n";

            return heading;
        }

        private static string GetUnderlineForHeading(string heading)
        {
            return new string('_', heading.Length -1);
        }

       public static string GetApplicationHeading()
        {
            string heading = "Employee CRUD Application\n";

            string underline = GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }
    }
}
