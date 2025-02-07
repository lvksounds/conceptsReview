using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorythmsAndDataEstructs.Challenges
{
    public class ArraysAndRecursiveFunctions
    {
        public static int[] ints1 = { 2, 4, 6 };
        
        // somando todo oum array com recursividade ao inves de um loop
        public static int Sum(int[] intArr)
        {
            //caso base
            if (intArr.Length == 0) return 0;
            if (intArr.Length == 1) return intArr[0];

            return intArr[0] + Sum(intArr.Skip(0).ToArray());
            
        }


    }
}
