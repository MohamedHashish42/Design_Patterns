using System;

namespace StructuralDesignPatterns.AdapterDB.ClassAdapterDP
{
    class ClientB
    {
        public static void UsingClassAdapte()
        {

            var employeesArray = new string[][]
            {
                new string[4] { "101", "John", "SE", "10000" },
                new string[4] { "101", "John", "SE", "10000" },
                new string[4] { "101", "John", "SE", "10000" },
                new string[4] { "101", "John", "SE", "10000" },
                new string[4] { "101", "John", "SE", "10000" }
            };


            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesArray);


        }
    }
}


