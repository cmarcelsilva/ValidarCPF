using Caelum.Stella.CSharp.Validation;
using System;
using System.Diagnostics;

namespace ValidarCPF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obs: importa as Bliblioteca de terceiros.. usando Caelum stella.

            Console.WriteLine(" Digite numero do CPF:");
            string cpf = Console.ReadLine();            

            //Extraindo método REFACTORY
            ValidarCpf(cpf);
           
        }

        private static void ValidarCpf(string cpf)
        {
            try
            {
                //AssertValid ele não informa nada se o cpf é válido...(ele permitir seguir se o cpf é válido)
                new CPFValidator().AssertValid(cpf);
                Debug.WriteLine("CPF VÁLIDO :" + cpf);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(" CPF INVÁLIDO :" + cpf + ":" + ex.ToString());
            }
        }

    }
   
}
