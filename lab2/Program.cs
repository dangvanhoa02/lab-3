using System;

namespace lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sin = "193 456 787";
            int LastNumber;
            var 
            var sinInCharArray = sin.ToCharArray();
            int[] numberOfSin = new int[9];
            int currentIndexNuberArray = 0  
            for (int i = 0; i < sinInCharArray.Length; i++)
            {
                if (sinInCharArray[i].ToString().Trim().Length==0)
                {
                    continue;
                }

                numberOfSin[currentIndexNuberArray] = Convert.ToInt32(sinInCharArray[i].ToString());
            }

            for (int i = 0; i < numberOfSin.Length; i++)
            {
                if ((i + 1) % 2 !=0)
                {
                    t
                }
                else
                {
                    var doubleOfNumber = numberOfSin[i] * 2;
                    var charArray = doubleOfNumber.ToString().ToCharArray();
                    
                }

                for (int j = 0; j < UPPER; j++)
                {
                    
                }
            }
        }
    }
}