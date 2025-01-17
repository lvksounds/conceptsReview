using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgorythmsAndDataEstructs.Challenges
{
    public class ReverseTheString
    {
        public static void Reverse(string originalString)
        {
            char[] originalChars = originalString.ToCharArray();
            StringBuilder reversedString = new StringBuilder();
            for (int i = originalChars.Length -1; i >= 0; i--)
            {
                reversedString.Append(originalChars[i]);
            }

            Console.WriteLine(reversedString);
        }
    }
}
