using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd201805_ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var res = BeregnOgSorterArray(test);

        }

        static ArrayResultat BeregnOgSorterArray(int[] arr)
        {
            ArrayResultat LocArr = new ArrayResultat();
            LocArr.gns = arr.Average();
            LocArr.sum = arr.Sum();
            return LocArr;
        }

        struct ArrayResultat
        {
            public double sum;
            public double gns;
        }
    }
}
