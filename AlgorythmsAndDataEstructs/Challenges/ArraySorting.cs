using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorythmsAndDataEstructs.Challenges
{
    public class ArraySorting
    {
        public static int[] ints1 = { 2, 4, 6 };
        

        public static int Sum(int[] intArr)
        {
            if (intArr.Length == 0) return 0;
            if (intArr.Length == 1) return intArr[0];
            int[] novoArray = new int[intArr.Length - 1];
            if (intArr.Length > 1)
            {
                for (int i = 0; i <= intArr.Length; i++)
                {
                    novoArray[i - 1] = intArr[1];
                }
            }
            return intArr[0] + Sum(novoArray);
            
        }


    }
}
