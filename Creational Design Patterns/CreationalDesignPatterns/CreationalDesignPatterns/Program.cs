using CreationalDesignPatterns.AbstractFactoryDP;
using CreationalDesignPatterns.BuilderDP;
using CreationalDesignPatterns.FactoryDP;
using CreationalDesignPatterns.FactoryMethodDP;
using CreationalDesignPatterns.PrototypeDP;
using CreationalDesignPatterns.SingletonDP;
using System;
using System.Threading.Tasks;

namespace CreationalCreationalDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  1-FactoryDP
            //ClientDontApplyFactoryDB.WithoutUsingFactoryDP("Platinum");
            //ClientApplyFactoryDB.UsingFactoryDP();
            #endregion

            #region  2-FactoryMethodDP
            //ClientUseFactoryDPWithFactoryMethod.UsingFactoryDP(new PlatinumFactory());
            #endregion

            #region  3-Abstract Factory DP
            //ClientUseAbstractFactoryDP.UsingAbstractFactoryDP();
            #endregion

            #region  4-Report Builder
            //Report pdfReport = ReportDirector.MakeReport(new PDFReport());
            //pdfReport.DisplayReport();

            //Report excelReport = ReportDirector.MakeReport(new ExcelReport());
            //excelReport.DisplayReport();
            #endregion

            #region 5-Fluent Interface
            ////Without fluent interface
            //Employee employee = new Employee();
            //employee.FullName = "Mohamed";
            //employee.DateOfBirth = Convert.ToDateTime("10/12/1980");
            //employee.Department = "IT";
            //employee.Address = "Egypt";
            //employee.print();

            //// with fluent interface
            //FluentEmployee fluentEmployee = new FluentEmployee();
            //fluentEmployee.NameOfTheEmployee("Mohamed")
            //              .Born("10/12/1980")
            //              .WorkingOn("IT")
            //              .StaysAt("Egypt")
            //              .print();
            #endregion

            #region 6-Prototype
            //Student student = new Student();
            //student.Name = "Mohamed";
            //student.Department = "IT";
            //Student emp2 = student.GetClone();
            //emp2.Name = "Ahmed";
            //Console.WriteLine("Student 1: ");
            //Console.WriteLine("Name: " + student.Name + ", Department: " + student.Department);
            //Console.WriteLine("Student 2: ");
            //Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);
            #endregion

            #region 7-SingletonDP
            #region 1- NoThreadSafe

            //NoThreadSafe fromTeachaer = NoThreadSafe.GetInstance;
            //fromTeachaer.PrintDetails("From Teacher");
            //NoThreadSafe fromStudent = NoThreadSafe.GetInstance;
            //fromStudent.PrintDetails("From Student");
            #endregion

            #region 2- ThreadSafeInUsingLock
            //Parallel.Invoke(
            // () => PrintFromDeveloper(ThreadSafe.GetInstance),
            // () => PrintFromTester(ThreadSafe.GetInstance)
            // );

            //Parallel.Invoke(
            // () => PrintFromDeveloper(ThreadSafeDoubleChecked.GetInstance),
            // () => PrintFromTester(ThreadSafeDoubleChecked.GetInstance)
            // );

            #endregion 3-ThreadSafeUsingEagerLoadingAndLazyKeyword


            #region 3-ThreadSafeUsingEagerLoadingAndLazyKeyword
            #region 1-ThreadSafeUsingEagerLoading
            //Parallel.Invoke(
            //() => PrintFromDeveloper(ThreadSafeUsingEagerLoading.GetInstance),
            //() => PrintFromTester(ThreadSafeUsingEagerLoading.GetInstance)
            //);
            #endregion
            #region 2-ThreadSafeUsingLazyKeywords
            //Parallel.Invoke(
            //() => PrintFromDeveloper(ThreadSafeUsingLazyKeyword.GetInstance),
            //() => PrintFromTester(ThreadSafeUsingLazyKeyword.GetInstance)
            //);
            #endregion
            #endregion
            #endregion

        }

        #region Singleton Methods
        public static void PrintFromDeveloper(ISingletoneObj singletoneObj)
        {
            singletoneObj.PrintDetails("From Developer");
        }
        public static void PrintFromTester(ISingletoneObj singletoneObj)
        {
            singletoneObj.PrintDetails("From Tester");
        }
        #endregion 
    }
}


