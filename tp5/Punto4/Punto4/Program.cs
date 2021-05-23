using System;

namespace Punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase\n");
            string frase = Console.ReadLine();

            Console.Write("Una parte de la cadena es : " + frase.Substring(0,3) + "\n");
            Console.Write("El tamaño de la cadena es : " + frase.Length + "\n");
            Console.WriteLine(frase.ToUpper());
            Console.WriteLine(frase.ToLower());

            Console.WriteLine("Ingrese una frase\n");
            string f1 = Console.ReadLine();
            Console.WriteLine("Ingrese una frase\n");
            string f2 = Console.ReadLine();
            Console.WriteLine( String.Concat(f1, f2));
            

            string[] partes = frase.Split(" ");
            foreach (var parte in partes)
            {
                Console.WriteLine($"Partes : {parte}");
            }

            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine().Trim();
            Console.WriteLine($"La palabra {palabra} {(frase.Contains(palabra) ? "esta" : "no esta")}");

            Console.WriteLine("Ingrese una frase : ");
            string frase2 = Console.ReadLine();

            if (frase.CompareTo(frase2) > 0)
            {
                Console.WriteLine("Frase 1 es mas larga \n");
            }
            else
            {
                Console.WriteLine("Frase 2 mas larga\n");
            }

            if (frase == frase2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }


            string texto = "uno;dos;tres;cuatro";
            char caracter = ';';
            string [] palabras = texto.Split(caracter);

            foreach (var pala  in palabras )
            {
                Console.WriteLine($"Partes : {pala}");
            }


        }
    }
}
