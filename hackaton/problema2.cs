using System;
namespace hackaton
{
    public class problema2
    {
        public static int Contador(string Cadena)
        {
            int cont = 0;
            string letra = "";

            for (int i = 0; i < Cadena.Length; i++)
            {
                letra = Cadena.Substring(i, 1);

                switch (letra)
                {
                    case "a":
                        cont++;
                        break;
                    case "e":
                        cont++;
                        break;
                    case "i":
                        cont++;
                        break;
                    case "o":
                        cont++;
                        break;
                    case "u":
                        cont++;
                        break;
                    case "A":
                        cont++;
                        break;
                    case "E":
                        cont++;
                        break;
                    case "I":
                        cont++;
                        break;
                    case "O":
                        cont++;
                        break;
                    case "U":
                        cont++;
                        break;
                }
            }
            return cont;
        }
    }
}

