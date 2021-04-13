using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.PrototypeDP
{
    class Student
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Student GetClone()
        {
            return (Student)this.MemberwiseClone();
        }
    }
}
