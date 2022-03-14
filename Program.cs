using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite un numero: ");
            numero = int.Parse(Console.ReadLine());
            while (numero != 0)
            {
                if (numero %2== 0)
                {
                    Console.WriteLine("El numero " + numero + " es PAR");
                }
                else
                {
                    Console.WriteLine("El numero " + numero + " es IMPAR");

                }
                Console.Write("Digite otro numero: ");
                numero=int.Parse(Console.ReadLine());
            }

        }
    }
}