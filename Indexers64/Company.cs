using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Indexers64
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee
                { EmployeeId = 1, Name = "Mike", Gender = "Male" });

            listEmployees.Add(new Employee
                { EmployeeId = 2, Name = "Pam", Gender = "Female" });

            listEmployees.Add(new Employee
                { EmployeeId = 3, Name = "John", Gender = "Male" });

            listEmployees.Add(new Employee
                { EmployeeId = 4, Name = "Maxine", Gender = "Female" });

            listEmployees.Add(new Employee
                { EmployeeId = 5, Name = "Emiliy", Gender = "Female" });

            listEmployees.Add(new Employee
                { EmployeeId = 6, Name = "Scott", Gender = "Male" });

            listEmployees.Add(new Employee
                { EmployeeId = 7, Name = "Todd", Gender = "Male" });

            listEmployees.Add(new Employee
                { EmployeeId = 8, Name = "Ben", Gender = "Male" });


        }

        public string this[int EmployeeId]
        {
            get { return listEmployees.FirstOrDefault(emp => emp.EmployeeId == EmployeeId).Name; }
            set { listEmployees.FirstOrDefault(emp => emp.EmployeeId == EmployeeId).Name = value; }
        }

        public string this[string Gender]
        {
            get { return listEmployees.Count(emp => emp.Gender == Gender).ToString(); }
            set {
                foreach (Employee emp in listEmployees)
                {
                    if (emp.Gender == Gender)
                    {
                        emp.Gender = value;
                    }
                }
            }
        }

    }
}