using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.IteratorDP
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Student(string name, int id)
        {
            ID = id;
            Name = name;
        }
    }
}
