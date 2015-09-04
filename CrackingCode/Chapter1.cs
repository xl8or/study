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
    }
}
