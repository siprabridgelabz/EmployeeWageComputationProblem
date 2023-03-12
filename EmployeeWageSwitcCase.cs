﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class EmployeeWageSwitcCase
    {
        public static void EmployeeWageSwitchCaseStatement()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int Emp_Hrs = 0;
            int Emp_Wage = 0;

            Random random = new Random();
            int emp_Check = random.Next(3);

            switch (emp_Check)
            {
                case 0:
                    Emp_Hrs = 8;
                    Console.WriteLine("The Employee is Present");
                    break;
                case 1:
                    Emp_Hrs = 4;
                    Console.WriteLine("The Employee is Present for Part Time");
                    break;
                default:
                    Emp_Hrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;


            }
            Emp_Wage = Emp_Hrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("The Employee Wage is :" + Emp_Wage + " Rupees");

        }
    }
}
