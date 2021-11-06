using StructuralDesignPatterns.AdapterDB;
using StructuralDesignPatterns.AdapterDB.ClassAdapterDP;
using StructuralDesignPatterns.AdapterDB.ObjectAdapterDP;
using StructuralDesignPatterns.BridgeDP;
using StructuralDesignPatterns.CompositeDP;
using StructuralDesignPatterns.DecoratorDP;
using StructuralDesignPatterns.FacadeDP;
using StructuralDesignPatterns.FlyweightDP;
using StructuralDesignPatterns.ProxyDP;
using System;

namespace StructuralDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AdapterDP
            //ClientA.UsingObjectAdapter();
            //ClientB.UsingClassAdapte();
            #endregion

            #region Facada DP
            //Order order = new Order();
            //order.PlaceOrder();
            #endregion

            #region Decorator DP

            //ICar car = new BMW();
            //Console.WriteLine("***** BMW without any accessories ***** ");
            //Console.WriteLine(car.ToString());


            //Console.WriteLine("\n \n***** BMW basic accessories ***** ");
            //CarAccessoriesDecorator carAccessoriesDecorator = new BasicAccessoriesDecorator(car);
            //Console.WriteLine(carAccessoriesDecorator.ToString());

            //Console.WriteLine("\n \n***** BMV with basic and sport accessories ***** ");
            //carAccessoriesDecorator = new SportAccessoriesDecorator(carAccessoriesDecorator);
            //Console.WriteLine(carAccessoriesDecorator.ToString());


            #endregion

            #region Bridge DP
            //Console.WriteLine("***** Produce and assemble new BMW car *****");
            //Car_Workshop car_Workshop1 = new Car_Workshop(new BMW_Workshop());
            //car_Workshop1.ProduceNewCar();
            //car_Workshop1.AssembleNewCar();

            //Console.WriteLine("\n\n ***** Produce and assemble new Mercedes car *****");
            //Car_Workshop car_Workshop2 = new Car_Workshop(new Mercedes_WorkShop());
            //car_Workshop2.ProduceNewCar();
            //car_Workshop2.AssembleNewCar();
            #endregion

            #region Composite DP
            //#region Leaf Objects
            //Leaf hardDisk = new Leaf("Hard Disk", 2000);
            //Leaf cpu = new Leaf("CPU", 3000);
            //Leaf ram = new Leaf("RAM", 500);
            //Leaf mouse = new Leaf("Mouse", 200);
            //Leaf keyboard = new Leaf("Keyboard", 300);
            //#endregion

            //#region Composite objects
            //Composite motherboard = new Composite("Motherboard");
            //Composite cabinet = new Composite("Cabinet");
            //Composite peripherals = new Composite("Peripherals");
            //Composite computer = new Composite("Computer");
            //#endregion

            //#region Creating tree structure
            //motherboard.AddComponent(cpu);
            //motherboard.AddComponent(ram);

            //cabinet.AddComponent(hardDisk);
            //cabinet.AddComponent(motherboard);

            //peripherals.AddComponent(mouse);
            //peripherals.AddComponent(keyboard);

            //computer.AddComponent(cabinet);
            //computer.AddComponent(peripherals);
            //#endregion

            //#region Get Details
            //computer.GetDetails();
            //#endregion
            #endregion

            #region Proxy DP
            #region Virtual Proxy

            //Console.WriteLine("***** Without virtual proxy *****");
            //RealImage realImage = new RealImage("/ImagePath");    //Loading
            //realImage.display();                                  //Displaying


            //Console.WriteLine("\n \n***** With virtual proxy *****");
            //ImageProxy proxyImage = new ImageProxy("/ImagePath");
            //proxyImage.display();                                  //Loading & Displaying 

            #endregion

            #region Protection Proxy
            //Console.WriteLine("\n \n***** Developer is trying t access shared resource *****");
            //Person person1 = new Person("Mohamed","12345",role.Developer);
            //SharedFolderProxy sharedFolderProxy1 = new SharedFolderProxy(person1);
            //sharedFolderProxy1.PerformRWOperations();

            //Console.WriteLine("\n \n***** CEO is trying t access shared resource *****");
            //Person person2 = new Person("Mahmoud","1234567",role.CEO);
            //SharedFolderProxy sharedFolderProxy2 = new SharedFolderProxy(person2);
            //sharedFolderProxy2.PerformRWOperations();

            #endregion
            #endregion

            #region Flyweight
            //for (int i = 0; i < 3; i++)
            //{
            //    Circle circle = (Circle)ShapeFactory.GetShape(SharedShapesNames.circle);
            //    circle.Draw(ConsoleColor.Red);
            //}
            //Console.WriteLine("\n");

            //for (int i = 0; i < 3; i++)
            //{
            //    Circle circle = (Circle)ShapeFactory.GetShape(SharedShapesNames.circle);
            //    circle.Draw(ConsoleColor.Gray);
            //}
            //Console.WriteLine("\n");


            //for (int i = 0; i < 5; i++)
            //{
            //    Triangle triangle = (Triangle)ShapeFactory.GetShape(SharedShapesNames.triangle);
            //    triangle.Draw(ConsoleColor.Yellow);
            //}
            //Console.WriteLine("\n");


            //for (int i = 0; i < 1; ++i)
            //{
            //    Rectangle rectangle = new Rectangle();
            //    rectangle.Draw(ConsoleColor.Green);
            //}
            #endregion


        }
    }
}








