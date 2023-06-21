using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeMS
{
    class Employee
    {
        public int Employee_ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Role { get; set; }
        //Constructor
        public Employee() { }
        public Employee(int employee_ID, string name, string adress, string email,long phone, string role)
        {
            Employee_ID = employee_ID;
            Name = name;
            Address = adress;
            Email = email;
            Phone = phone;
            Role = role;
        }                                       

        //User define method 
        //List all employee
        public void ListAllEmployee()
        {
            Console.WriteLine("\n\t" + Employee_ID + "\t" + Name + "\t" + Email + "\t " + Phone + "\t\t" + Address + "\t\t" + Role);
        }
        //Add new Employee 
        public static List<Employee> Add_Employee(List<Employee> employee, Employee emp)
        {
            employee.Add(emp);
            return employee;
        }


    }
}
