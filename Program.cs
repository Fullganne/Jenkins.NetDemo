using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsC_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Welcome you to Jenkins World!");
        }
    }
}
