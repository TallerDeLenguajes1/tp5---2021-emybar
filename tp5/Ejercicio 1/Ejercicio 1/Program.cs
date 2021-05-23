using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int ninv=0;

            Console.WriteLine("Ingrese un numero ");
            
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                while (num >0)
                {
                    ninv = ninv * 10 + num % 10;
                    num /= 10;

                }
                Console.Write("El numero invertido es: " + ninv);
            }
            else 
            {
                Console.WriteLine("El numero no se puede invertir");
            }



        }
    }
}
