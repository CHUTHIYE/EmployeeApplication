using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeMS
{
    class Vacation
    {

        public int Vacation_ID { get; set; }
        public int EmployeeID { get; set; }
        public int NumberOfDay { get; set; }
        public Vacation() { }
        public Vacation(int vacation_ID, int employeeID, int numberofday)
        {
            Vacation_ID = vacation_ID;
            this.EmployeeID = employeeID;
            this.NumberOfDay = numberofday;
        }
        public void view_vacation()
        {
            Console.WriteLine("\n\t\t" + Vacation_ID + 
                "\t\t" + EmployeeID + 
                "\t\t" + NumberOfDay);
        }
    }
}
