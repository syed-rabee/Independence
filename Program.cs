using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hamza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Enter your name");
            string input = Console.ReadLine();
            Console.WriteLine("Enter your English marks");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Maths marks");
            int input3 = Convert.ToInt32(Console.ReadLine());
            int per = Convert.ToInt32(input2+input3)*100/200;
            Console.WriteLine(input + per);
            Console.ReadLine();
        }
    }
}
