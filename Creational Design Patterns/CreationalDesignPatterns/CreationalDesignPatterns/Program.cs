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
            // Client client = new Client(new NikeClothesFactory());
            #endregion

            #region  4-Builder DP

            //var reportDirector = new ReportDirector();

            //var pdfReportBuilder = new PDFReportBuilder();
            //reportDirector.MakeReport(pdfReportBuilder);
            //var pdfReport = pdfReportBuilder.GetReport();
            //pdfReport.DisplayReport();

            //Console.WriteLine("\n");

            //var excelReportBuilder = new ExcelReportBuilder();
            //reportDirector.MakeReport(excelReportBuilder);
            //var excelReport = excelReportBuilder.GetReport();
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
            #region without Prototype

            //Student student1 = new Student();
            //student1.Name = "Mohamed";
            //student1.Department = "IT";
            //Student student2 = student1;
            //student2.Name = "Ahmed";
            //Console.WriteLine("Student 1: ");
            //Console.WriteLine("Name: " + student1.Name);  // Name: Ahmed
            //Console.WriteLine("Student 2: ");
            //Console.WriteLine("Name: " + student2.Name);  // Name: Ahmed

            #endregion

            #region With Prototype

            //Student student3 = new Student();
            //student3.Name = "Mohamed";
            //student3.Department = "IT";
            //Student student4 = student3.GetClone();
            //student4.Name = "Ahmed";
            //Console.WriteLine("Student 1: ");
            //Console.WriteLine("Name: " + student3.Name );  // Name: Mohamed
            //Console.WriteLine("Student 2: ");
            //Console.WriteLine("Name: " + student4.Name);   //Name: Ahmed


            #endregion
            #endregion

            #region 7-SingletonDP
            #region 1- NoThreadSafe

            //PrintFromDeveloper(NoThreadSafe.GetInstance);
            //PrintFromTester(NoThreadSafe.GetInstance);

            #region NoThreadSafe Multithreaded Environment
            //Parallel.Invoke(
            // () => PrintFromDeveloper(NoThreadSafe.GetInstance),
            // () => PrintFromTester(NoThreadSafe.GetInstance)
            // );
            #endregion
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
            //#endregion
            //#region 2-ThreadSafeUsingLazyKeywords
            //Parallel.Invoke(
            //() => PrintFromDeveloper(ThreadSafeUsingLazyKeyword.GetInstance),
            //() => PrintFromTester(ThreadSafeUsingLazyKeyword.GetInstance)
            //);
            #endregion
            #endregion
            #endregion

        }

        #region Singleton Methods
        public static void PrintFromDeveloper(ISingletonObj singletoneObj)
        {
            singletoneObj.PrintDetails("From Developer");
        }
        public static void PrintFromTester(ISingletonObj singletoneObj)
        {
            singletoneObj.PrintDetails("From Tester");
        }
        #endregion 
    }
}


