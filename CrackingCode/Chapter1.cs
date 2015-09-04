using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCode
{
    public class Chapter1
    {

        public static bool unique(string s)
        {
            foreach (char c in s)
            {
                if (s.Where(x => x == c).Count()> 1)
                { return false; }
            }
            return true;
        }
        public static string[] FindPermutations(string s)
        {
            if (s.Length == 2)
            {
                char[] _c = s.ToArray();
                string new_s = new string(new char[] { _c[1], _c[0] });
                return new string[]
                    {
                        s,new_s
                    };
            }
            return new string[]{s};
        }

    }
}
