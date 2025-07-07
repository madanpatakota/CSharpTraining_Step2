using System;

namespace StaticAndNonStaticMembers
{
    public static class EmployeeStaticLogger
    {
        public static int EmployeesList = 0;
        /// <summary>
        ///  Log message is for print the Message as well as increase +1 the value
        ///  Example : Incaes EmployeesList is 2 the it will return 3
        /// </summary>
        /// <param name="message"></param>
        public static void LogMessage(string message)
        {
            Console.WriteLine($"[LOG] {message}");
            EmployeesList = EmployeesList + 1;
        }

        public static int GetMessageCount()
        {
            return EmployeesList;   //Latest emploeesList count
        }

        //static EmployeeStaticLogger()
        //{

        //}

    }

    public class EmployeeNonStaticLogger
    {
        public int EmployeesList = 0;

        /// <summary>
        ///  Log message is for print the Message as well as increase +1 the value
        ///  Example : Incaes EmployeesList is 2 the it will return 3
        /// </summary>
        /// <param name="message"></param>
        public void LogMessage(string message)
        {
            Console.WriteLine($"[LOG] {message}");
            EmployeesList = EmployeesList + 1;   // 1 addition
        }

        public int GetMessageCount()
        {
            return EmployeesList;   //Latest emploeesList count
        }

    }

    class Program
    {
        static void Main()
        {
            // I do't have change bcz i cannot the create the instance.
            EmployeeStaticLogger.LogMessage("John has joined on 01-10-2021");
            EmployeeStaticLogger.LogMessage("Robert has joined on 01-11-2021");
            Console.WriteLine($"Total static log messages: {EmployeeStaticLogger.GetMessageCount()}");


            //Situation Based i can take any instance over here
            EmployeeNonStaticLogger employeeNonStaticLogger1 = new EmployeeNonStaticLogger(); 
            employeeNonStaticLogger1.LogMessage("John has joined on 01-10-2021");
            employeeNonStaticLogger1.LogMessage("Lakshmi has joined on 02-11-2022");


            EmployeeNonStaticLogger employeeNonStaticLogger2 = new EmployeeNonStaticLogger();
            employeeNonStaticLogger2.LogMessage("Robert has joined on 01-11-2021");

            Console.WriteLine($"Total non-static log messages: {employeeNonStaticLogger1.GetMessageCount()}");  //2
            Console.WriteLine($"Total non-static log messages: {employeeNonStaticLogger2.GetMessageCount()}");  //1




        }
    }
}