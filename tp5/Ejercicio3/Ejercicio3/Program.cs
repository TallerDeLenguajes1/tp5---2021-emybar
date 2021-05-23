using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;
            int a;
            int b;
            Console.WriteLine("Ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor Absoluto :" + Math.Abs(num));
            Console.WriteLine("El cuadrado del numero es :" + Math.Pow(num, 2));
            Console.WriteLine("La raiz cuadrada es : " + Math.Sqrt(num));
            Console.WriteLine("El seno es :" + Math.Sin(num * Math.PI /180));
            Console.WriteLine("El coseno es : " + Math.Cos(num* Math.PI / 180));
            Console.WriteLine("La parte entera : " + Math.Truncate(num));

            Console.WriteLine("Ingrese un numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El maximo es : " + Math.Max(a, b));
            Console.WriteLine("El minimo es : " + Math.Min(a, b));
        }
    }

}