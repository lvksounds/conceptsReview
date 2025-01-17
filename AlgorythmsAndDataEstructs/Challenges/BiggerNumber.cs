using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorythmsAndDataEstructs.Challenges
{
    public class BiggerNumber
    {
        public static void FoundingTheBiggerNumber(int[] numbers)
        {
            int biggerNum = int.MinValue; // caso seja um array com numeros negativos, o min value cobre esse problema. Se definisse apenas como 0 o resultado seria sempre zero nesse cenario. 
            foreach (int number in numbers)
            {
                if (number > biggerNum)
                {
                    biggerNum = number;
                }
            }
            Console.WriteLine(biggerNum.ToString());
        }
    }
}
