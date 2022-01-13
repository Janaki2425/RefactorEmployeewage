using System;
namespace EmployeewageOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emppresence employeepresent = new Emppresence();
            employeepresent.Employee_Check_UC1();
            Employeewage employee = new Employeewage();
            employee.Employee_Check_UC2();
        }

    }
}
