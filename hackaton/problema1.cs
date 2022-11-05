using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackaton
{
    public class problema1
    {
        public static void Calculadora()
        {
            int operacion = 0, baseN = 0;
            Console.WriteLine("¿Qué desea hacer?");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            try
            {
                operacion = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Surgió el siguiente error:" + e.Message);
            }
            Console.WriteLine("Ingrese la base:");
            Console.WriteLine("1. Binario");
            Console.WriteLine("2. Decimal");
            Console.WriteLine("2. Hexadecimal");
            try
            {
                baseN = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Surgió el siguiente error:" + e.Message);
            }

            Console.WriteLine("Ingrese el primer número a operar");
            string num1 = Console.ReadLine()!;
            Console.WriteLine("Ingrese el segundo número a operar");
            string num2 = Console.ReadLine()!;

            int n1 = 0, n2 = 0, resultado = 0;

            switch (baseN)
            {
                case 1:
                    if (!CadenaBinaria(num1) || !CadenaBinaria(num2))
                    {
                        Console.WriteLine("Formato incorrecto");
                        return;
                    }
                    n1 = binaryToInt(num1);
                    n2 = binaryToInt(num2);
                    break;
                case 2:
                    try
                    {
                        n1 = Convert.ToInt32(num1);
                        n2 = Convert.ToInt32(num2);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Formato incorrecto");
                        return;
                        throw;
                    }
                    break;

                case 3:
                    if (!CadenaHexadec(num1) || !CadenaHexadec(num2))
                    {                        
                        return;
                    }
                    n1 = hexadecimalDecimal(num1);
                    n2 = hexadecimalDecimal(num2);
                    break;
                default:
                    break;
            }
            string resulString = "";
            switch (operacion)
            {
                case 1:
                    resultado = n1 + n2;

                    resulString = resultado.ToString();
                    if (baseN == 3)
                    {
                        resulString = decimalHexadecimal(resultado);
                    }
                    else if (baseN == 1)
                    {
                        resulString = decimalBinario(resultado).ToString();
                    }
                    Console.WriteLine("El resultado de la de suma entre {0} y {1} es: {3}", num1, num2, resulString);
                    break;
                case 2:
                    resultado = n1 - n2;
                    resulString = resultado.ToString();
                    if (baseN == 3)
                    {
                        resulString = decimalHexadecimal(resultado);
                    }
                    else if (baseN == 1)
                    {
                        resulString = decimalBinario(resultado).ToString();
                    }
                    Console.WriteLine("El resultado de la de suma entre {0} y {1} es: {3}", num1, num2, resulString);
                    break;
                default:
                    break;
            }
        }

        static bool CadenaBinaria(string cadena)
        {
            int contador = 0;
            while (contador < cadena.Length)
            {
                if (cadena[contador] == 0 || cadena[contador] == 1)
                {
                    contador++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static bool CadenaHexadec(string cadena)
        {
            int contador = 0;
            while (contador < cadena.Length)
            {
                int aux;
                bool isNumber = int.TryParse(cadena[contador].ToString(), out aux);
                if (!isNumber)
                {
                    byte caracter = (byte)cadena[contador];
                    if (caracter >= 65 && caracter <= 70)
                    {

                    }
                    else
                    {
                        return false;
                    }
                }
                contador++;
            }
            return true;
        }

        static int binaryToInt(string cadena)
        {
            int resultado = 0;
            int c = cadena.Length - 1;

            while (c >= 0)
            {
                resultado += Convert.ToInt32(cadena[c]) * Convert.ToInt32(Math.Pow(2, c));
                c--;
            }
            return resultado;
        }


        private static int hexadecimalDecimal(String hexadecimal)
        {

            int numero = 0;

            const int DIVISOR = 16;

            for (int i = 0, j = hexadecimal.Length - 1; i < hexadecimal.Length; i++, j--)
            {

                if (hexadecimal[i] >= '0' && hexadecimal[i] <= '9')
                {
                    numero += (int)Math.Pow(DIVISOR, j) * Convert.ToInt32(hexadecimal[i] + "");
                }
                else if (hexadecimal[i] >= 'A' && hexadecimal[i] <= 'F')
                {
                    numero += (int)Math.Pow(DIVISOR, j) * Convert.ToInt32((hexadecimal[i] - 'A' + 10) + "");
                }
                else
                {
                    return -1;
                }

            }

            return numero;

        }


        private static String decimalHexadecimal(int numero)
        {

            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };

            String hexadecimal = "";

            const int DIVISOR = 16;
            long resto = 0;

            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                resto = i % DIVISOR;
                if (resto >= 10)
                {
                    hexadecimal = letras[resto - 10] + hexadecimal;

                }
                else
                {
                    hexadecimal = resto + hexadecimal;
                }
            }


            return hexadecimal;


        }

        private static long decimalBinario(int numero)
        {

            long binario = 0;

            const int DIVISOR = 2;
            long digito = 0;

            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                binario += digito * (long)Math.Pow(10, j);
            }


            return binario;
        }

        private static int binarioDecimal(long binario)
        {

            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;

            for (long i = binario, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;
                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }

            return numero;
        }
    }
}
