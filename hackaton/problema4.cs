using System;
namespace hackaton
{
    public class problema4
    {
        public static int Pasteles(int amigos, int porciones)
        {
            int residuo = (amigos * porciones) % 4;

            if (residuo != 0)
            {
                int pasteles = ((amigos * porciones) / 4) + 1;
                return pasteles;
            }

            return (amigos * porciones) / 4;
        }
    }
}

