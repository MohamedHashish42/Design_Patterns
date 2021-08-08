using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.IteratorDP
{
    class employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public employee(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}
