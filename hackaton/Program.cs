using hackaton;
using static hackaton.problema2;

Console.WriteLine("Problema 1: calculadora, el programa opera datos decimales, binarios y hexadecimales. ");

problema1.Calculadora();

Console.WriteLine("Problema 2: ingrese un texto, el programa le contará el número de voacles. ");

string cadena = Console.ReadLine();

Console.WriteLine("Número de vocales: " + problema2.Contador(cadena));


Console.WriteLine("Problema 3: ingrese un número para calcular el factorial");
long numero = long.Parse(Console.ReadLine());

Console.WriteLine("Factorial es: " + problema3.Factorial(numero));

Console.WriteLine("Problema 4: ingrese la cantidad de amigos");
int amigos = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de porciones de pasteles por amigo");

int porciones = int.Parse(Console.ReadLine());

Console.WriteLine("La cantidad mínima de pasteles es: " + problema4.Pasteles(amigos, porciones));

Console.ReadLine();
