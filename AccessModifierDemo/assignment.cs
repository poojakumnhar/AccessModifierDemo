using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierDemo
{
    internal class assignment
    {
        
        protected int EmployeeID;
        protected string EmployeeName, EmployeeAddress;

        public void EmployeeDetails(int ID, string Name, string Address)
        {
            EmployeeID = ID;
            EmployeeName = Name;
            EmployeeAddress = Address;
        }
    }

    class Person : assignment
    {
        private string FirstName, LastName;
        public void Name(string FName, string LName)
        {
            FirstName = FName;
            LastName = LName;
        }
        public void DisplayFullName()
        {
            Console.WriteLine("Employee ID :" + EmployeeID);
            Console.WriteLine(" Employee Name : " + EmployeeName);
            Console.WriteLine(" Employee Address :" + EmployeeAddress);

            Console.WriteLine("Person Name :" + FirstName + " " + LastName);
        }
    }
}

    

