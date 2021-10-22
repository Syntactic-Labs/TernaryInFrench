//checks for french
#define xFrench
using System;

namespace TernaryInFrench
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two var for my Ternary
            var yes = "Yes";
            var no = "No";
//French Ternary response
#if French
            yes = "Oui";
            no = "Non";

#endif
            var boolean = true;

            
            Console.WriteLine($"boolean is {boolean}; text is {(boolean ? yes : no)}");
        }
    }
}
