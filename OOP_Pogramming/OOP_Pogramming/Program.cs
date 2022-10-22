using OOP_Pogramming;
using System;
​
namespace OOP_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string methodName = "";

            while (true)
            {
                Console.WriteLine("\nWrite name of method u want to run or press \"x\" to exit");
                methodName = Console.ReadLine();
                if (methodName == "x" || methodName == "X")
                    break;
                else 
                {
                    Console.WriteLine("\n-----------------");
                    Installer installer = new Installer();
                    installer.GetType().GetMethod(methodName)?.Invoke(installer, null);
                    Console.WriteLine("\n-----------------");
                }
            }
        }
    }
}