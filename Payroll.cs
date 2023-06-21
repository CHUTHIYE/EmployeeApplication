using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeMS
{
    class Payroll
    {
        public int Payroll_ID { get; set; }
        public int EmployeeID { get; set; }
        public double Hours_worked { get; set; }
        public double Hourly_rate { get; set; }
        public string Date { get; set; }
        public Payroll() { }
        public Payroll(int payrall_ID, int employeeID,
                double hours_worked,double hourly_rate, string date)
        {
            Payroll_ID = payrall_ID;
            EmployeeID = employeeID;
            Hours_worked = hours_worked;
            Hourly_rate = hourly_rate;
            Date = date;
        }
        public static List<Payroll> 
            Insert_New_Entry(List<Payroll> payroll, 
            Payroll pay)
        {
            payroll.Add(pay);
            return payroll;
        }
        public void View_History()
        {
            Console.WriteLine("\n\t\t" + Payroll_ID +
                "\t\t" + EmployeeID + 
                "\t\t" + Hours_worked + 
                "\t\t" + Hourly_rate + 
                "\t\t" + Date);
        }
    }
}
