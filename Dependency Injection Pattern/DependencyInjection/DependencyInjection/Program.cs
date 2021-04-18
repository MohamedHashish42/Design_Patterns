using DependencyInjection.ConstructorDependencyInjection;
using DependencyInjection.MethodDependencyInjection;
using DependencyInjection.PropertyDependencyInjection;
using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nConstructor Dependency Injection \n");
            CInjector.TryConstructorInjector();

            Console.WriteLine("\nProperty Dependency Injection \n");
            PInjector.TryConstructorInjector();

            Console.WriteLine("\nMethod Dependency Injection \n");
            MInjector.TryMethodInjector();
        }
    }
}
