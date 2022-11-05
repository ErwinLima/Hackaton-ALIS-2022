using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
namespace Hackaton;

public class Program
{
    public static void Main()
    {
        
    }

    void Calculadora()
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

        switch (baseN)
        {
            case 1:
                if (CadenaBinaria(num1) && CadenaBinaria(num2))
                {

                }
                else
                {
                    Console.WriteLine("Formato incorrecto");
                }
                break;
            default:
                break;
        }

        switch (operacion)
        {
            case 1:

                break;
            case 2:
                break;
            default:
                break;
        }
    }

    bool CadenaBinaria(string cadena)
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
}
