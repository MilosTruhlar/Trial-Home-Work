using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Company
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> employees;
            employees = new Dictionary<string, string>();

            employees.Add("0001", "John");
            employees.Add("0002", "Maryl");
            employees.Add("0003", "Brad");
            employees.Add("0004", "Lucy");

            Print(employees);
            DeleteEmpl(employees);
            Print(employees);
        }

        public static void Print(Dictionary<string, string> employees)
        {
            foreach (KeyValuePair<string, string> key in employees)
            {
                Console.WriteLine($"Employee number {key.Key} is {key.Value}.");
            }
        }
        public static void DeleteEmpl(Dictionary<string, string> employees)
        {
            foreach (KeyValuePair<string, string> key in employees)
            {
                if (key.Key == Console.ReadLine())
                {
                    Console.WriteLine($"Employee number {key.Key} name {key.Value} successfuly removed!");
                    employees.Remove(key.Key);                    
                }
                else
                {
                    Console.WriteLine("Key not found!");
                }
            }
        }
    }
}