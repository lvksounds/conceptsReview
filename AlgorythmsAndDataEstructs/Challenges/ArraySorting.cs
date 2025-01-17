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

        public static int Sum(int[] intArr, int firtArrayItem)
        {
            if(intArr.Length == 0) return 0;
            else
            {       
                firstArrItem = intArr[0];
                intArr.ToList().RemoveAt(intArr[0]);
                totalsum = firstArrItem + Sum(intArr);
                
            }
            return totalsum;
        }
    }
}
