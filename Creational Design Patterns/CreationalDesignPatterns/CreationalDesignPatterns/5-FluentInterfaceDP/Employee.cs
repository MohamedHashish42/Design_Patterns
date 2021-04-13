using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.BuilderDP
{
    class Employee
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }

        public void print()
        {
            Console.WriteLine("Emp Data \nname : {0} \nBorn : {1} \nWorking on : {2}\nStays At : {3} "
                    , this.FullName, this.DateOfBirth, this.Department, this.Address);
        }
    }
}
