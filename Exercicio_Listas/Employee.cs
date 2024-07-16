using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Listas
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public Employee(int id)
        {
            Id = id;
        }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;           
        }

        public Employee()
        {
            
        }

        public void increaceSalary(double salary, double pct)
        {
            salary = salary + (salary * pct / 100);
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
