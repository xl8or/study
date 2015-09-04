using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCode
{
    public class Unique
    {

        public static bool unique(string s)
        {
            foreach (char c in s)
            {
                int count = s.Where(x => x == c).Count();
                if (count > 1)
                { return false; }
            }
            return true;
        }
    }
}
