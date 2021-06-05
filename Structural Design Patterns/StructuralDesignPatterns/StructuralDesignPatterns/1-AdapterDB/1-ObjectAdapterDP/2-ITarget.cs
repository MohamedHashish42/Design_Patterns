using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.AdapterDB.ObjectAdapterDP
{
    public interface ITarget
    {
        void ProcessCompanySalary(string[][] employeesArray);
    }
}
