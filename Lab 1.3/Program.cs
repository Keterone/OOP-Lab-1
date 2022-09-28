using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 task = new Class1();
            Console.WriteLine($"Task 1: {task.Task1(4, 6)}");
            Console.WriteLine("Task 2:\n");
            task.Task2();
            Console.WriteLine($"Task 3: {task.Task3(2)}");
        }
    }
}
