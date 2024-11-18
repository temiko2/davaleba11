using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    public class Counter
    {
        public static int Count = 10;

        public Counter()
        {
            Count++;
        }

        public static int GetCount()
        {
            return Count;
        }

        public static void ResetCount()
        {
            Count = 0;
        }
    }
}
