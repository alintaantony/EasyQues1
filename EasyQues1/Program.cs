﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQues1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeePromotion employeePromotion = new EmployeePromotion();
            employeePromotion.AddEmployeesAccordingToPromotioneligibility();
            Console.ReadKey();
        }
    }
}
