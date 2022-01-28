using System;
using Olimpiada.src.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Olimpiada
{

    class Program
    {
        
         static List<Atleta> atletas = new List<Atleta>();    
        static void Main(string[] args)
        {
            int i=0, j=1;
           
            Console.WriteLine("Atletas:");

            while(i<10)
            {   
                

                atletas.Add(new Atleta(" "," ", 0));

                Console.WriteLine($"Digite o NOME do atleta  {j} ");
                atletas[i].Nome = Console.ReadLine();
                Console.WriteLine($"Digite o PAÍS do atleta {j}: ");
                atletas[i].Pais = Console.ReadLine();
                Console.WriteLine($"Digite o RESULTADO (em metros) do atleta {j}: ");
                atletas[i].Distancia = Convert.ToDouble(Console.ReadLine());

                j++;
               i++; 
            }

                var atletasOrdenados = atletas.OrderByDescending(x => x.Distancia).ToList();

                var atletaOuro = atletasOrdenados[0];
                var atletaPrata = atletasOrdenados[1];
                var atletaBronze = atletasOrdenados[2];
                Console.WriteLine("");
                Console.WriteLine("Medalistas:");
                Console.WriteLine("");
                Console.WriteLine($"Ouro: {atletaOuro.Nome} - {atletaOuro.Pais} Resultado: {atletaOuro.Distancia}m");
                Console.WriteLine($"Prata: {atletaPrata.Nome} - {atletaPrata.Pais} Resultado: {atletaPrata.Distancia}m");
                Console.WriteLine($"Bronze: {atletaBronze.Nome} - {atletaBronze.Pais} Resultado: {atletaBronze.Distancia}m");
               
                    

                            
               
                    
                     
                    
           
        }   
    }
}

