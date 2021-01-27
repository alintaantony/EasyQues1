using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQues1
{
    class EmployeePromotion
    {
        List<string> employeeNames = new List<string>();
        string input = "NotEmpty";

        public void AddEmployeesAccordingToPromotioneligibility()
        {
            try
            {
                Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop)");
                while (input != String.Empty && input != " ")
                {
                    input = Console.ReadLine();
                    employeeNames.Add(input);
                }
                Console.WriteLine("The employees accoridng to their eligibility for promotion are :");
                foreach (var names in employeeNames)
                {
                    Console.WriteLine(names);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry !! Something went Wrong !! Please Try Again !!");
                Console.WriteLine(e);
                AddEmployeesAccordingToPromotioneligibility();
            }
        }
    }
}
