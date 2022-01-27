using System;
using Olimpiada.src.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Olimpiada
{

    class Program
    {
        
        
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Atletas:");
         
                for(i=1; i<=3; i++){
                    List<Atleta> atletas = new List<Atleta>();    
                        atletas.Add(new Atleta("x","x", 0));
                        atletas.Add(new Atleta("x","x", 0));
                        atletas.Add(new Atleta("x","x", 0));

                        

                        // atletas.Add(new Atleta("x","x", 0));
                        // atletas.Add(new Atleta("x","x", 0));
                        // atletas.Add(new Atleta("x","x", 0));
                        // atletas.Add(new Atleta("x","x", 0));
                        // atletas.Add(new Atleta("x","x", 0));
                        // atletas.Add(new Atleta("x","x", 0));
                        // atletas.Add(new Atleta("x","x", 0))

                    Console.WriteLine($"Digite o NOME do atleta : {i} ");
                    atletas[0].Nome = Console.ReadLine();
                    Console.WriteLine($"Digite o PAÍS do atleta {i}: ");
                    atletas[0].Pais = Console.ReadLine();
                    Console.WriteLine($"Digite o RESULTADO (em metros) do atleta {i}: ");
                    atletas[0].Distancia = double.Parse(Console.ReadLine());
                   
                   }


                    Console.WriteLine("");
                    Console.WriteLine("Ordenação das posições:");
                    Console.WriteLine("");
                    Console.WriteLine("");


                     var podium = atletas.OrderBy(atletas => atletas.Distancia);  
                    foreach(var a in podium)
                    {
                    Console.WriteLine("{0} {1} {2}", a.Nome, a.Pais, a.Distancia);
                    }   
                           
                    
           
        }   
    }
}

