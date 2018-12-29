using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class IsUnique
    {
        //Implement an algorithm to determine if a string has all unique characters. 
        //What if you cannot use additional data structure?
        public static void CheckUnique(string s)
        {
            bool result = false;
            for (int i = 0; i < s.Length; i++)
                for (int j = i + 1; j < s.Length; j++)
                    if (s[i] == s[j])
                        result = true;
            if (result)
                Console.WriteLine("This string does not have all unique characters");
            else
                Console.WriteLine("This string has all unique characters");
        }
    }
}
