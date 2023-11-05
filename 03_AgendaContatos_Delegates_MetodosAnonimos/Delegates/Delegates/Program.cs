using System;

namespace Delegates
{
    public class Program
    {
        public static void UtilizaDelegate(Func<string, int> metodoDelegate)
        {
            var letras = metodoDelegate("Gustavo");
            Console.WriteLine("Qtde. de letras: " + letras);
        }

        static void Main(string[] args)
        {
            UtilizaDelegate((n) => {
                Console.WriteLine("Nome: " + n);
                return n.Length;
            });

            Action<string> metodoDelegate = (n) => Console.WriteLine("Nome: " + n);
            metodoDelegate("Isabela");

            Predicate<int> pred = (num) => num%2 == 0;
            Console.WriteLine("Resultado divisão: " + pred(3));

            //var qtdLetras = metodoDelegate("Fatima");
            //Console.WriteLine("Qtde. de letras: " + letras);
        }
    }
}
