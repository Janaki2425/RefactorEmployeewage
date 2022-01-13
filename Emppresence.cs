using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageOOPS
{
    internal class emppresence
    {
        public static void Employee_Check_UC1()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empcheck = random.Next(2);
            Console.WriteLine(empcheck);
            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}

    

