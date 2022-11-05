using System;
namespace hackaton
{
    public class problema3
    {
        public static long Factorial(long num)
        {
            long contador = 1;

            for (int i = 1; i <= num; i++)
            {
                contador = contador * i;
            }

            return contador; 
        }
    }
}

