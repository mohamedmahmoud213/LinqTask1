using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linqTask1
{
    public class Employee
    {

        public long Id { get; private set; }
        public string Name { get; private set; }
        public decimal Salary { get; private set; }
        public Employee(long id, string name, decimal Salary)
        {
            Id = id;
            Name = name;
            this.Salary = Salary;
        }


        


       



        
    }
}
