using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._13
{
    public class KeyCompare : IComparer<int>
    {
        public int Compare(int a,int b)
        {
            if (a > b) return 1;
            else if(b>a) return -1;
            else return 0;
        }
    }
}
