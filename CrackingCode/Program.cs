using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Chapter1.unique("ABCDa"));
            Console.WriteLine(string.Join(" ", Chapter1.FindPermutations("AB")));
            Console.WriteLine(Chapter1.escape_spaces("This is sample"));
        }
    }
}
