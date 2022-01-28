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

            while(i<3)
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
         
               
                    

                            
               
                    
                     
                    
           
        }   
    }
}

