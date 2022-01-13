using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageeOOPS
{
    public class Employeewage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int Emp_Wage_Per_Hr = 20;
        public const int Working_Days_Per_Month = 20;
        public const int Max_Hrs_In_Month = 100;
        public static void Employee_Check_UC2()
        {

            int empHrs = 0;
            int empWage = 0;
            int totalMonthlyWage = 0;
            int totalWorkingDays = 0;
            int totalHrs = 0;
            while (totalHrs <= Max_Hrs_In_Month && totalWorkingDays < Working_Days_Per_Month)
            {

                for (int day = 1; day <= Working_Days_Per_Month; day++)
                {
                    Random random = new Random();
                    int empcheck = random.Next(3);
                    Console.WriteLine(empcheck);
                    /*  if (empcheck == IS_FULL_TIME)
                      {
                          Console.WriteLine("Employee works full time");
                          empHrs = 12;
                      }
                      else if (empcheck == IS_PART_TIME)
                      {
                          Console.WriteLine("Employee works part time");
                          empHrs = 8;
                      }
                      else
                      {
                          empHrs = 0;
                      }*/

                    switch (empcheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }

                    empWage = empHrs * Emp_Wage_Per_Hr;
                    totalMonthlyWage += empWage;
                    Console.WriteLine("Daily Employee Wage:" + empWage);
                }
                Console.WriteLine("Total Monthly Wage is:" + totalMonthlyWage);
            }
        }
    }
}
