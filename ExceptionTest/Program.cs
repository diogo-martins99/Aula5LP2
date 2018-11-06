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
            } catch (OverflowException)
            {
                Console.WriteLine("Ocorreu um erro de overflow");
            } catch (FormatException)
            {
                Console.WriteLine("Ocorreu um erro de formato");
            } catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: "
                    + e.Message);
            } finally
            {
                Console.WriteLine("Obrigado pelo teu tempo ehehehe");
            }

        }
    }
}
