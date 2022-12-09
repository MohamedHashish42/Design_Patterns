using BehavioralDesignPatterns.IteratorDP;
using BehavioralDesignPatterns.ObserverDP;
using BehavioralDesignPatterns.ChainOfResponsibility;
using BehavioralDesignPatterns.StateDP;
using BehavioralDesignPatterns.TemplateMethodDP;
using BehavioralDesignPatterns.CommandDP;
using BehavioralDesignPatterns.VisitorDP;
using BehavioralDesignPatterns.StrategyDP;
using BehavioralDesignPatterns.InterpreterDP;
using BehavioralDesignPatterns.MediatorDP;
using System;
using System.Collections.Generic;
using BehavioralDesignPatterns.MementoDP;

namespace BehavioralDesignPatterns
{
    class Program
    {

        static void Main(string[] args)
        {
            #region 1- Iterator DP
            //ConcreteAggregate collection = new ConcreteAggregate();
            //collection.AddElement(new employee("Mohamed", 100));
            //collection.AddElement(new employee("Ali", 101));
            //collection.AddElement(new employee("Ahmed", 102));
            //collection.AddElement(new employee("Fatima", 103));
            //collection.AddElement(new employee("Mahmoud", 104));
            //collection.AddElement(new employee("khadija", 105));

            //Iterator iterator = collection.CreateIterator();

            //Console.WriteLine("Iterating over collection:");

            //for (employee emp = (employee)iterator.First();
            //    iterator.HasNext();
            //    emp = (employee)iterator.Next())
            //{
            //    Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
            //}
            #endregion

            #region 2- Observer DP
            ////Create a Product with NotAvailable Status
            //Subject MobilePro = new Subject("Mobile Pro", 10000, state.NotAvailable);
            //MobilePro.Attach(new Observer("Mohamed"));
            //MobilePro.Attach(new Observer("Ahmed"));
            //MobilePro.Attach(new Observer("Mahmoud"));

            //Console.WriteLine();
            ////Changing the subject state to available to send notification
            //MobilePro.setState(state.Available);
            #endregion

            #region 3- Chain Of Responsibility DP
            //ATM atm = new ATM();
            //Console.WriteLine("\nRequested Amount 4600");
            //atm.withdraw(4600);
            //Console.WriteLine("\nRequested Amount 1900");
            //atm.withdraw(1900);
            //Console.WriteLine("\nRequested Amount 600");
            //atm.withdraw(600);

            #endregion

            #region 4- State DP
            //Account account = new Account("Jim Johnson");
            //account.Deposit(500.0);
            //account.Deposit(800.0);
            //account.Withdraw(1100.00);
            //account.Withdraw(150);
            //account.Withdraw(2000.00);
            #endregion

            #region 5- Template Method DP
            //Console.WriteLine("Build a Concrete House\n");
            //HouseTemplate houseTemplate = new ConcreteHouse();
            //houseTemplate.BuildHouse();
            //Console.WriteLine();

            //Console.WriteLine("Build a Wooden House\n");
            //houseTemplate = new WoodenHouse();
            //houseTemplate.BuildHouse();
            #endregion

            #region 6- Command DP
            //SwitchOptions lampSwitchOptions = new SwitchOptions();
            ////Pass reference to the lamp instance to each command
            //ICommand switchClose = new CloseSwitchCommand(lampSwitchOptions);
            //ICommand switchOpen = new OpenSwitchCommand(lampSwitchOptions);
            //LightRemoteControle LRC = new LightRemoteControle(switchClose, switchOpen);
            //LRC.Open();
            //LRC.Close();
            #endregion

            #region 7- Visitor DP
            //Company company = new Company();
            //company.Add(new Employee("Ali", 6000, 30));
            //company.Add(new Employee("Ibrahim", 5000, 30));
            //company.Add(new Employee("Khalid", 4000, 30));

            //Console.WriteLine("  ***(Result After SalaryVisitor Visiting)***\n");
            //var salaryVisitor = new SalaryVisitor(10 /*percentage*/);
            //company.PerformOperation(salaryVisitor);
            //Console.WriteLine();

            //Console.WriteLine("\n ***(Result After VacationVisitor Visiting)***\n");
            //var vacationVisitor = new VacationVisitor(1/*NumberOfDays*/);
            //company.PerformOperation(vacationVisitor);
            #endregion

            #region 8- Strategy DP
            //Console.WriteLine("Enter the formate you want ZIP or RAR");
            //CompressionContext context = new CompressionContext();
            //var formate = Console.ReadLine();

            //if (formate.ToLower() == "zip")
            //{
            //    context.SetStrategy(new ZIP());
            //    context.CompressFolder("DesignPattern");
            //}
            //else if (formate.ToLower() == "rar")
            //{
            //    context.SetStrategy(new RAR());
            //    context.CompressFolder("DesignPattern");
            //}
            //else
            //    Console.WriteLine("Please Enter the right formate");
            #endregion

            #region 9- InterpreterDP
            //var number = Console.ReadLine();

            //Context context = new Context(number);
            //List<Expression> tree = new List<Expression>();
            //if (number[number.Length - 2] == '1')
            //{
            //    tree.Add(new ThousandsExpression());
            //    tree.Add(new HundredsExpression());
            //    tree.Add(new ElevenToNineteenExpression());
            //}

            //else
            //{
            //    tree.Add(new ThousandsExpression());
            //    tree.Add(new HundredsExpression());
            //    tree.Add(new TensExpression());
            //    tree.Add(new UnitsExpression());
            //}

            //foreach (Expression exp in tree)
            //{
            //    exp.Interpret(context);
            //}
            //Console.WriteLine("{0} = {1}", number, context.Output);
            #endregion

            #region 10 -MediatorDP
            //Chatroom chatroom = new Chatroom();

            //Participant Mohamed = new ConcreteParticipant(chatroom, "Mohamed");
            //Participant Khalid = new ConcreteParticipant(chatroom, "Khalid");
            //Participant Mahmoud = new ConcreteParticipant(chatroom, "Mahmoud");
            //Participant Ali = new ConcreteParticipant(chatroom, "Ali");
            //Participant Ahmed = new ConcreteParticipant(chatroom, "Ahmed");

            //chatroom.RegisterUser(Mohamed);
            //chatroom.RegisterUser(Khalid);
            //chatroom.RegisterUser(Mahmoud);
            //chatroom.RegisterUser(Ali);
            //chatroom.RegisterUser(Ahmed);

            //Mahmoud.Send("What is the chat subject today? ");
            //Console.WriteLine();
            //Khalid.Send("Today we will talk about Mediator design pattern");

            #endregion

            #region 11- Memento DP
            //Originator originator = new Originator();
            //Caretaker caretaker = new Caretaker();

            //// First Step
            //originator.FirstName = "Mohamed";
            //originator.SecondName = "Ahmed";
            //caretaker.AddMemento("FirstStep", originator.CreateMemento());


            //// Second Step
            //originator.Age = 26;
            //caretaker.AddMemento("SecondStep", originator.CreateMemento());


            //Console.WriteLine("\nOrignator current state \n: "
            //                                       + originator.GetDetails());

            //// Back To First Step
            //Console.WriteLine("\n\n***** Originator restoring first state *****");
            //originator.Restore(caretaker.GetMemento("FirstStep"));
            //Console.WriteLine("\nOrignator current state : \n"
            //                                       + originator.GetDetails());
            #endregion
        }
    }
}






