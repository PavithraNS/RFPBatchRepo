using System;
using TestClass;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    /// <summary>
    /// Tested this sample application for printing hello message
    /// </summary>
    class Test
    {
        /// <summary>
        /// Main method is the start point for console application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to fellowship");
            Test program = new Test();
            TestClass.Test p = new TestClass.Test();
            p.Test1();
            double res = program.TestMethod();
            Console.WriteLine("Double value in main method " + res);
            Console.Wrilteline("Modifying in remote master branch");
            Console.Wrilteline("Modifying in remote Test branch");
            
            Console.Read();
        }

        public double TestMethod()
        {
            double result = 2.3 + 4.5;
            Console.WriteLine("Double value in testMethod " + result);
            return result;
        }

    }
}
