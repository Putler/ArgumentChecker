using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentChecker
{
    public class Class1
    {
        public bool DoIt(int i)
        {
            if (i <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
