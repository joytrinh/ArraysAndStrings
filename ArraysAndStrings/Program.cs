using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a string to check ");
            string s = Console.ReadLine();
            IsUnique.CheckUnique(s);
            Console.ReadLine();
        }
    }    
}
