using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorythmsAndDataEstructs.Challenges
{
    public class binarySearch
    {
        public static int SearchNum(int RequiredNum, int[] numsArr) {            
            int min = 0;
            int max = numsArr[numsArr.Length - 1];

            while (min <= max) {
                int meio = (min + max) / 2;
                int shoot = numsArr[meio];

                if(shoot ==  RequiredNum) return shoot;
                if (shoot > RequiredNum) max = meio - 1;
                else min = meio + 1;
            }

            return 0;
        }
    }
}