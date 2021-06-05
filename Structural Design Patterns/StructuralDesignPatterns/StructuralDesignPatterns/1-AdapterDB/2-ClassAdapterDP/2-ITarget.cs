using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.AdapterDB.ClassAdapterDP
{
    public interface ITarget
    {
        void ProcessCompanySalary(string[][] employeesArray);
    }
}
