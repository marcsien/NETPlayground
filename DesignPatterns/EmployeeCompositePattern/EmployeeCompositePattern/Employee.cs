using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCompositePattern
{
    public class Employee : IEmployeeComposite
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public Employee(string name)
        {
            Name = name;
            Employees = new List<Employee>();
        }

        public void addEmployee(Employee e)
        {
            Employees.Add(e);
        }

        public void doSomeWork(string Name)
        {
            if (Employees.Count == 0)
            { 
                Console.WriteLine(Name + " is doing some work"); 
            }
            else
            {
                foreach(Employee e in Employees)
                {
                    Console.WriteLine(Name + " is delegating work to its employee");
                    e.doSomeWork(e.Name);
                }
            }
        }
    }
}
