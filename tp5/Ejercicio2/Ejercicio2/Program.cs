using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            int seleccion;
            int nuevo;

            do 
            { 
               Console.WriteLine("Seleccione la operacion a realizar 1:Suma - 2: Resta - 3: Multiplicacion - 4: Division");
               seleccion = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Ingrese un numero");
               num1 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Ingrese un numero");
               num2 = Convert.ToInt32(Console.ReadLine());

           
                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine($"El reultado de la suma es :{num1 + num2}");
                        break;

                    case 2:
                        Console.WriteLine($"El reultado de la resta es :{num1 - num2}");
                        break;

                    case 3:
                        Console.WriteLine("El reultado de la multiplicacion es :" + num1 * num2);
                        break;

                    case 4:
                        Console.WriteLine("El reultado de la division es :" + (float) num1 / num2);
                        break;
                }
                Console.WriteLine("Desea ralizar otro calculo? 1-Si  2-No");
                nuevo = Convert.ToInt32(Console.ReadLine());
            } while (nuevo == 1);
        }
        }
    }

