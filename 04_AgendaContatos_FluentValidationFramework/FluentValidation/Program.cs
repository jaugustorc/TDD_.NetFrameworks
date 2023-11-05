using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace FluentValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validando Cliente");

            Cliente cliente = new Cliente() { Nome = "" };
            ClienteValidator clienteValid = new ClienteValidator();
            ValidationResult result  = clienteValid.Validate(cliente);

            if (!result.ToString().Equals(string.Empty)) 
                Console.WriteLine(result.ToString("\n"));

            //if(!result.IsValid)
            //{
            //    foreach (var erro in result.Errors)
            //    {
            //        //Console.WriteLine("Erro na propriedade " + erro.PropertyName + ". Erro: " + erro.ErrorMessage);
            //        Console.WriteLine(erro.ErrorMessage);
            //    } 
            //}
        }
    }
}
