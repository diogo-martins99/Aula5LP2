using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere um numero inteiro: ");

            try
            {
               int i = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine($"Numero inserido: {i} ");
            } catch (Exception e)
            {
                Console.WriteLine("Ocorreu o seguinte erro: " +
                    e.Message);
            }

        }
    }
}
