using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem_using_OOPS
{
    public class EmployeeWage
    {

        public int Empis;
        public void EmpWage()
        {
            int WagePrHr = 20;
            int FullDayHr = 8;
            int PartTimeHr = 4;

            Random random = new Random();
            int Empis = random.Next(3);

            switch (Empis)
            {
                case 1:
                    Console.WriteLine("Emploee is Present");
                    Console.WriteLine(WagePrHr * FullDayHr);
                    break;

                case 2:
                    Console.WriteLine("Emp is part time present");
                    Console.WriteLine(WagePrHr * PartTimeHr);
                    break;

                default:
                    Console.WriteLine("Emp is Abcent");
                    break;

            }

        }
    }
}
