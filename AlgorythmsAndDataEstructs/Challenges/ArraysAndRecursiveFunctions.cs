using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgorythmsAndDataEstructs.Challenges
{
    public class ArraysAndRecursiveFunctions
    {
        public static int[] ints1 = { 2, 4, 6 };
        
        // somando todo oum array com recursividade ao inves de um loop
        public static int Sum(int[] intArr)
        {
            if (intArr.Length == 0) return 0;
            if (intArr.Length == 1) return intArr[0];

            return intArr[0] + Sum(intArr.Skip(1).ToArray());
            
        }

        // contando o a quantidade de numeros em um array 

        public static int Count(int[] arr)
        {
            if (arr.Length == 0) return 0;   
            return 1 + Count(arr.Skip(1).ToArray());
        }

        // encontrar o mais numero do array 

        public static int FindHigherNum(int[] arr)
        {
            if (arr.Length == 0) return 0;

            
        }
    }
}
