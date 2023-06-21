using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeMS
{
    class Program
    {
        static void Main(String[] args)
        {
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee(1, "Ly", "Thanh Xuan", "ly@gmail.com", 0904, "admin"));
            employee.Add(new Employee(2, "Hoa", "Hoa Binh", "hoa@gmail.com", 0904, "admin"));
            employee.Add(new Employee(3, "Binh", "Hoan Kiem", "binh@gmail.com", 0904, "admin"));
            employee.Add(new Employee(4, "Tan", "Thai Nguyen", "tan@gmail.com", 0904, "admin"));
            employee.Add(new Employee(5, "My", "Thai Binh", "my@gmail.com", 0904, "admin"));
            //payroll detail
            List<Payroll> payrolls = new List<Payroll>();
            payrolls.Add(new Payroll(1, 1, 5, 10, "01/01/2023"));
            payrolls.Add(new Payroll(2, 2, 4, 30, "01/01/2023"));
            payrolls.Add(new Payroll(3, 3, 6, 40, "01/01/2023"));
            payrolls.Add(new Payroll(4, 4, 2, 20, "01/01/2023"));
            payrolls.Add(new Payroll(5, 5, 3, 60, "01/01/2023"));

            //vacation detail
            List<Vacation> vacations = new List<Vacation>();
            vacations.Add(new Vacation(1, 1, 5));
            vacations.Add(new Vacation(2, 2, 5));
            vacations.Add(new Vacation(3, 3, 5));
            vacations.Add(new Vacation(4, 4, 5));
            vacations.Add(new Vacation(5, 5, 5));

            //Menu
            main_menu://
            Console.WriteLine("\nEmployee Management System");
            Console.WriteLine("1. Manage Empoyee");
            Console.WriteLine("2. Add payrolll");
            Console.WriteLine("3. View vacation days");
            Console.WriteLine("4. Exit program");

            Console.WriteLine("\nEnter your choice: ");
            string input = Console.ReadLine();
            int choice = 0;
            int choice2 = 0;
            int choice3 = 0;
            int choice4 = 0;
            while (true)
            {
                if (int.TryParse(input, out choice))
                {
                    if (choice.Equals(1))
                    {
                        Console.WriteLine("CRUD Employee here!");
                        Console.Clear();
                        Console.WriteLine("\n====Employee Management System====");
                        Console.WriteLine("1, List all employee");
                        Console.WriteLine("2, Add new employee");
                        Console.WriteLine("3, Update employee");
                        Console.WriteLine("4, Delete employee");
                        Console.WriteLine("5, Return nain menu");
                        Console.WriteLine("\nEnter your choice: ");
                        string input2 = Console.ReadLine();

                        while (true)
                        {
                            if (int.TryParse(input2, out choice2))
                            {
                                if (choice2.Equals(1))
                                {
                                    Console.WriteLine("\t\t\t====Employee detail====");
                                    Console.WriteLine("\n\t ID \t Name \t Email \t\t Phone \t\t Address \t\t Role");
                                    employee.ForEach(p => p.ListAllEmployee());

                                    Console.WriteLine("\nEnter your choice: ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(2))
                                {
                                    Console.WriteLine("\n\t\t\t=====Add Employee=====");
                                    Employee em = new Employee();
                                    Console.WriteLine("Enter employee ID: ");
                                    int Emp_id = Convert.ToInt32(Console.ReadLine());
                                    var empinfo = employee.Where(e => e.Employee_ID == Emp_id).FirstOrDefault();

                                    if (empinfo == null)
                                    {
                                        empinfo = em;
                                        empinfo.Employee_ID = 0;
                                    }
                                    if (Emp_id != null)
                                    {
                                        if (empinfo.Employee_ID != Emp_id || empinfo.Employee_ID == null)
                                        {
                                            em.Employee_ID = Emp_id;
                                            Console.Write("Enter Name: ");
                                            em.Name = Console.ReadLine();
                                            Console.Write("Enter Email: ");
                                            em.Email = Console.ReadLine();
                                            Console.Write("Enter Address: ");
                                            em.Address = Console.ReadLine();
                                            Console.Write("Enter Phone: ");
                                            em.Phone = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter Role: ");
                                            em.Role = Console.ReadLine();

                                            //add to list with LINQ
                                            employee.Where(e => e.Employee_ID ==em.Employee_ID);
                                            employee.Where(e => e.Name == em.Name);
                                            employee.Where(e => e.Email == em.Email);
                                            employee.Where(e => e.Phone == em.Phone);
                                            employee.Where(e => e.Address == em.Address);
                                            employee.Where(e => e.Role == em.Role);
                                            employee.Add(em);
                                            Console.WriteLine("\n\tEmployee with id: " + Emp_id + " Add successfully");

                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\tEmployee " + empinfo.Employee_ID + "Already exist!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tEmployee " + empinfo.Employee_ID + "Already exist!");
                                    }
                                    Console.WriteLine("\nEnter your choice: ");
                                    input2 = Console.ReadLine();

                                }
                                else if (choice2.Equals(3))
                                {
                                    Console.WriteLine("Enter EmployeeID to Update profile: ");
                                    int emp_id = Convert.ToInt32(Console.ReadLine());
                                    Employee emp = new Employee();
                                    var empinfo = employee.Where(e => e.Employee_ID == emp_id).FirstOrDefault();
                                    if (empinfo != null)
                                    {
                                        emp.Employee_ID = emp_id;
                                        Console.Write("Enter Name: ");
                                        emp.Name = Console.ReadLine();
                                        Console.Write("Enter Email: ");
                                        emp.Email = Console.ReadLine();
                                        Console.Write("Enter Address: ");
                                        emp.Address = Console.ReadLine();
                                        Console.Write("Enter Phone: ");
                                        emp.Phone = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter Role: ");
                                        emp.Role = Console.ReadLine();

                                        //update to list with LINQ: truy vấn trên obj
                                        employee.Where(e => e.Employee_ID == emp_id).FirstOrDefault().Employee_ID = emp_id;
                                        employee.Where(e => e.Employee_ID == emp_id).FirstOrDefault().Name = emp.Name;
                                        employee.Where(e => e.Employee_ID == emp_id).FirstOrDefault().Email = emp.Email;
                                        employee.Where(e => e.Employee_ID == emp_id).FirstOrDefault().Address = emp.Address;
                                        employee.Where(e => e.Employee_ID == emp_id).FirstOrDefault().Phone = emp.Phone;
                                        employee.Where(e => e.Employee_ID == emp_id).FirstOrDefault().Role = emp.Role;

                                        Console.WriteLine("\n\tEmployee with id : " + emp_id + " update successfully!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tEmployee with id: " + emp_id + " does not exist");
                                    }
                                    Console.WriteLine("\nEnter your choice: ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(4))
                                {
                                    Console.WriteLine("\n\tEnter EmployeeID to Delete: ");
                                    int emp_id = Convert.ToInt32(Console.ReadLine());
                                    employee.RemoveAll(e => e.Employee_ID == emp_id);

                                    Console.WriteLine("\tEmployee " + emp_id + " delete successfully!");
                                    Console.WriteLine("\nEnter your choice: ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(5))
                                {
                                    Console.Clear();
                                    goto main_menu;
                                }
                            }
                            
                        }
                    }
                    else if (choice.Equals(2))
                    {
                        Console.Clear();
                        Console.WriteLine("\n=====Add payroll=====");
                        Console.WriteLine("1, List all payroll");
                        Console.WriteLine("2, Add new payroll");
                        Console.WriteLine("3, Update payroll");
                        Console.WriteLine("4, Delete payroll");
                        Console.WriteLine("5, Return main menu");
                        Console.WriteLine("\nEnter your choice: ");
                        string input3 = Console.ReadLine();

                        while (true)
                        {
                            if (int.TryParse(input3, out choice3))
                            {
                                if (choice3.Equals(1))
                                {
                                    Console.WriteLine("\t\t\t=====Payroll detail=====");
                                    Console.WriteLine("\n\t Payroll_ID \t EmployeeID \t Hours_worked \t Hourly_rate \t\t Date ");
                                    payrolls.ForEach(r => r.View_History());

                                    Console.WriteLine("\nEnter your choice: ");
                                    input3 = Console.ReadLine();
                                }
                                else if (choice3.Equals(2))
                                {
                                    Console.WriteLine("\n\t\t\t==*==Add Payroll==*==");
                                    Payroll pay = new Payroll();
                                    Console.WriteLine("Enter Payroll ID: ");
                                    int pay_id = Convert.ToInt32(Console.ReadLine());
                                    var payinfo = payrolls.Where(p => p.Payroll_ID == pay_id).FirstOrDefault();

                                    if (payinfo == null)
                                    {
                                        payinfo = pay;
                                        payinfo.Payroll_ID = 0;
                                    }
                                    if (pay_id != null)
                                    {
                                        if (payinfo.Payroll_ID != pay_id || payinfo.Payroll_ID == null)
                                        {
                                            pay.Payroll_ID = pay_id;
                                            var i = 0;
                                            do
                                            {
                                                Console.WriteLine("Enter EmployeeID: ");
                                                pay.EmployeeID = Convert.ToInt32(Console.ReadLine());
                                                for (i = 0; i < payrolls.Count; i++)
                                                {
                                                    if (payrolls[i].EmployeeID == pay.EmployeeID)
                                                    {
                                                        break;
                                                    }
                                                }

                                                if (i == payrolls.Count)
                                                {
                                                    Console.WriteLine("\n\tEmployeeID " + pay.EmployeeID + " does not exist!");
                                                }

                                            } while (i == payrolls.Count);

                                            Console.WriteLine("Enter Hours_worked");
                                            pay.Hours_worked = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Enter Hours_rate");
                                            pay.Hourly_rate = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Enter Date");
                                            pay.Date = Console.ReadLine();

                                            payrolls.Where(p => p.Payroll_ID == pay.Payroll_ID);
                                            payrolls.Where(p => p.EmployeeID == pay.EmployeeID);
                                            payrolls.Where(p => p.Hours_worked == pay.Hours_worked);
                                            payrolls.Where(p => p.Hourly_rate == pay.Hourly_rate);
                                            payrolls.Where(p => p.Date == pay.Date);
                                            payrolls.Add(pay);
                                            Console.WriteLine("\n\tPayroll with id: " + pay_id + " add successfully");

                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\tPayroll " + payinfo.Payroll_ID + " Already exist!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tPayroll " + payinfo.Payroll_ID + " Already exist!");

                                    }
                                    Console.WriteLine("\nEnter your choice: ");
                                    input3 = Console.ReadLine();
                                }
                                else if (choice3.Equals(3))
                                {
                                    Console.WriteLine("Enter Payroll_ID to Update: ");
                                    int pay_id = Convert.ToInt32(Console.ReadLine());
                                    Payroll payr = new Payroll();
                                    var payinfo = payrolls.Where(p => p.Payroll_ID == pay_id).FirstOrDefault();
                                    if (payinfo != null)
                                    {
                                        payr.Payroll_ID = pay_id;
                                        Console.WriteLine("Enter EmployeeID: ");
                                        payr.EmployeeID = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter Hours_worked: ");
                                        payr.Hours_worked = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter Hourly_rate: ");
                                        payr.Hourly_rate = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter date: ");
                                        payr.Date = Console.ReadLine();

                                        payrolls.Where(p => p.Payroll_ID == pay_id).FirstOrDefault().Payroll_ID = payr.Payroll_ID;
                                        payrolls.Where(p => p.Payroll_ID == pay_id).FirstOrDefault().EmployeeID = payr.EmployeeID;
                                        payrolls.Where(p => p.Payroll_ID == pay_id).FirstOrDefault().Hours_worked = payr.Hours_worked;
                                        payrolls.Where(p => p.Payroll_ID == pay_id).FirstOrDefault().Hourly_rate = payr.Hourly_rate;
                                        payrolls.Where(p => p.Payroll_ID == pay_id).FirstOrDefault().Date = payr.Date;

                                        Console.WriteLine("\n\tPayroll with id: " + pay_id + " update successfully!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tPayroll with id: " + pay_id + " does not exist!");
                                    }
                                    Console.WriteLine("\nEnter your choice: ");
                                    input3 = Console.ReadLine();
                                }
                                else if (choice3.Equals(4))
                                {
                                    Console.WriteLine("\n\tEnter payroll_ID to delete: ");
                                    int pay_id = Convert.ToInt32(Console.ReadLine());
                                    payrolls.RemoveAll(p => p.Payroll_ID == pay_id);

                                    Console.WriteLine("\tEmployee " + pay_id + " delete successfully!");
                                    Console.WriteLine("\nEnter your choice: ");
                                    input3 = Console.ReadLine();
                                }
                                else if (choice3.Equals(5))
                                {
                                    Console.Clear();
                                    goto main_menu;
                                }
                            }
                        }

                        Console.WriteLine("Add payroll");
                    }
                    else if (choice.Equals(3))
                    {
                        Console.Clear();
                        Console.WriteLine("\n*=====View vacation days=====*");
                        Console.WriteLine("1, List all vacation");
                        Console.WriteLine("2, Add new vacation");
                        Console.WriteLine("3, Update vacation");
                        Console.WriteLine("4, Delete vacation");
                        Console.WriteLine("5, Return main menu");
                        Console.WriteLine("\nEnter your choice: ");
                        string input4 = Console.ReadLine();

                        while (true)
                        {
                            if (int.TryParse(input4,out choice4))
                            {
                                if (choice4.Equals(1))
                                {
                                    Console.WriteLine("\n\t*****Vacation detail*****");
                                    Console.WriteLine("\n\t Vacation_ID \t EmployeeID \t NumberOfDay");
                                    vacations.ForEach(v => v.view_vacation());

                                    Console.WriteLine("\nEnter your choice: ");
                                    input4 = Console.ReadLine();

                                }
                                else if(choice4.Equals(2))
                                {
                                    Console.WriteLine("\n\t\t*****Add vacation*****");
                                    Vacation va = new Vacation();
                                    Console.WriteLine("Enter vacation ID: ");
                                    int va_id = Convert.ToInt32(Console.ReadLine());
                                    var vainfo = vacations.Where(v => v.Vacation_ID == va_id).FirstOrDefault();

                                    if (vainfo == null)
                                    {
                                        vainfo = va;
                                        vainfo.Vacation_ID = 0;
                                    }
                                    if (va_id != null)
                                    {
                                        if (vainfo.Vacation_ID != va_id || vainfo.Vacation_ID == null)
                                        {
                                            va.Vacation_ID = va_id;
                                            var i = 0;
                                            do
                                            {
                                                Console.WriteLine("Enter EmployeeID: ");
                                                va.EmployeeID = Convert.ToInt32(Console.ReadLine());
                                                for (i = 0; i < vacations.Count; i++)
                                                {
                                                    if (payrolls[i].EmployeeID == va.EmployeeID)
                                                    {
                                                        break;
                                                    }
                                                }
                                                if (i == vacations.Count)
                                                {
                                                    Console.WriteLine("\n\tEmployeeID " + va.EmployeeID + " does not exist!");
                                                }
                                            } while (i == payrolls.Count);
                                           
                                            Console.WriteLine("Enter NumberOfDay: ");
                                            va.NumberOfDay = Convert.ToInt32(Console.ReadLine());

                                            vacations.Where(v => v.Vacation_ID == va.Vacation_ID);
                                            vacations.Where(v => v.EmployeeID == va.EmployeeID);
                                            vacations.Where(v => v.NumberOfDay == va.NumberOfDay);
                                            vacations.Add(va);
                                            Console.WriteLine("\n\tPayroll with id: " + va_id + " add successfully!");

                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\tPayroll " + vainfo.Vacation_ID + " Already exist!");

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tPayroll " + vainfo.Vacation_ID + " Already exist!");

                                    }
                                    Console.WriteLine("\nEnter your choice: ");
                                    input4 = Console.ReadLine();
                                }
                                else if (choice4.Equals(3))
                                {
                                    Console.WriteLine("Enter Vacation to Update: ");
                                    int va_id = Convert.ToInt32(Console.ReadLine());
                                    Vacation vaca = new Vacation();
                                    var vainfo = vacations.Where(v => v.Vacation_ID == va_id).FirstOrDefault();
                                    if (vainfo != null)
                                    {
                                        vaca.Vacation_ID = va_id;
                                        Console.WriteLine("Enter EmployeeID: ");
                                        vaca.EmployeeID = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter NumberOfDay: ");
                                        vaca.NumberOfDay = Convert.ToInt32(Console.ReadLine());

                                        vacations.Where(v => v.Vacation_ID == va_id).FirstOrDefault().Vacation_ID = vaca.Vacation_ID;
                                        vacations.Where(v => v.Vacation_ID == va_id).FirstOrDefault().EmployeeID = vaca.EmployeeID;
                                        vacations.Where(v => v.Vacation_ID == va_id).FirstOrDefault().NumberOfDay = vaca.NumberOfDay;

                                        Console.WriteLine("\n\tVacation with id: " + va_id + " update successfully!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tVacation with id: " + va_id + " does not exist!");
                                    }
                                    Console.WriteLine("\nEnter your choice: ");
                                    input4 = Console.ReadLine();

                                }
                                else if (choice4.Equals(4))
                                {
                                    Console.WriteLine("\n\tEnter Vacation_ID to delete: ");
                                    int va_id = Convert.ToInt32(Console.ReadLine());
                                    vacations.RemoveAll(v => v.Vacation_ID == va_id);

                                    Console.WriteLine("\tEmployee " + va_id + " delete successfully!");
                                    Console.WriteLine("\nEnter your choice: ");
                                    input4 = Console.ReadLine();

                                }
                                else if (choice4.Equals(5))
                                {
                                    Console.Clear();
                                    goto main_menu;
                                }

                            }
                        }



                        Console.WriteLine("View vacation days");

                    }
                    else if (choice.Equals(4))
                    {
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Choice invaild, Try again");
                        Console.WriteLine("\nEnter your choice: ");
                        input = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Choice invaild, Try again");
                    Console.WriteLine("\nEnter your choice: ");
                    input = Console.ReadLine();
                }
            }
        }
    }
}

