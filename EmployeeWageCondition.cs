using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class EmployeeWageCondition
    {
        public static void EmployeeWageConditionForWorkingHours()
        {
            int isFullTime = 1;
            int isPartTime = 2;
            int empRatePerHour = 20;
            int empHrs = 0;
            int empWage = 0;
            int empWagePerMonth = 0;
            int workingDays = 20;

            int totalEmpHrs = 0;
            int totalWorkingHrs = 100;
            int totalWorkingDays = 0;


            while (totalEmpHrs <= totalWorkingHrs && totalWorkingDays < workingDays)
            {
                Random random = new Random();
                int emp_Check = random.Next(3);

                switch (emp_Check)
                {
                    case 1:
                        empHrs = 8;
                        Console.WriteLine("The Employee is Present");
                        break;
                    case 2:
                        empHrs = 4;
                        Console.WriteLine("The Employee is Present for Part Time");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                totalWorkingDays++;
                totalEmpHrs = totalEmpHrs + empHrs;
                empWage = empHrs * empRatePerHour;
                empWagePerMonth = empWagePerMonth + empWage;
                Console.WriteLine("TotalWorking days: " + totalWorkingDays);
                Console.WriteLine("Employee's wage per day is: " + empWage);
                Console.WriteLine("Total employee's hours are: " + totalEmpHrs);
            }
            Console.WriteLine("Employee's wages for a Month: " + empWagePerMonth);
        }
    }
}
