using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random().Next(0, 10);
            int cont = 0, num;

            do
            {
                Console.Write("Introduzca un número: ");
                num = (Convert.ToInt32(Console.ReadLine()));

                if (r >= num)
                    Console.WriteLine("Es un numero mayor, Adivina denuevo ");
                else
                    Console.WriteLine("Es un numero menor, Adivina denuevo");

                cont++;
            } while (r != num);

            Console.WriteLine("Felicidades!!!, Ganaste");
            Console.WriteLine("Número de Intentos: {0}", cont);
        }
    }
}
