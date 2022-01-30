using System;
using ExercicioCirculo.Models;

namespace ExercicioCirculo
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valorRaio, percentual;

            Console.WriteLine("Insira o valor do Raio: ");
            valorRaio = double.Parse(Console.ReadLine());
            Circulo r = new Circulo();
            r.definirRaio(valorRaio);
           
            System.Console.WriteLine($"Raio: {valorRaio}");
            System.Console.WriteLine($"Area: {r.Area()} metros quadrados");
            System.Console.WriteLine($"Circunferência: {r.Circunferencia()} metros");
            System.Console.WriteLine("");

            System.Console.WriteLine("Informe o percentual de aumento do raio: ");
            percentual = double.Parse(Console.ReadLine());

            Circulo R = new Circulo();
            R.aumentarRaio(percentual);

            System.Console.WriteLine($"Raio: { R.aumentarRaio(percentual)}");
            System.Console.WriteLine($"Area: {R.Area()} metros quadrados");
            System.Console.WriteLine($"Circunferência: {R.Circunferencia()} metros");




            
            // See https://aka.ms/new-console-template for more information
        }
    }
}

