using System;
using Impostos.src.Entities;

namespace Impostos
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, totalPagar;
            Console.WriteLine("Calculadora de impostos");
            Console.WriteLine("Informe o Valor: ");


            valor = double.Parse(Console.ReadLine());

            ICMS impostoICMS = new ICMS(valor);
            IPI impostoIPI = new IPI(valor);
            CONFINS impostoCONFINS = new CONFINS(valor);


            Console.WriteLine("");
            Console.WriteLine("O valor a pagar de ICMS é : R$ {0}", impostoICMS.calculaImposto(valor));
            Console.WriteLine("O valor a pagar de IPI é : R$ {0}", impostoIPI.calculaImposto(valor));
            Console.WriteLine("O valor a pagar de COFINS é : R$ {0}", impostoCONFINS.calculaImposto(valor));

            totalPagar = impostoICMS.calculaImposto(valor) + impostoIPI.calculaImposto(valor) + impostoCONFINS.calculaImposto(valor);
            
            Console.WriteLine("");
            Console.WriteLine("O valor Total a pagar será de: R$ {0}", totalPagar);
        }



    }
}