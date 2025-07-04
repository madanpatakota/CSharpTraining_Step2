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
            EmployeesList = EmployeesList + 1;
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
            EmployeeStaticLogger.LogMessage("John has joined on 01-10-2021");
            EmployeeStaticLogger.LogMessage("Robert has joined on 01-11-2021");

            Console.WriteLine($"Total static log messages: {EmployeeStaticLogger.GetMessageCount()}");

        }
    }
}