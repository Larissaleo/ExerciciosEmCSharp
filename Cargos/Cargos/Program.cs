using System;
using Cargos.src.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Cargos
{
    class Program
    {

        static List<Pessoa> pessoa = new List<Pessoa>();
        static void Main(string[] args)
         {
            Console.WriteLine("Controle de funcionarios");


                int i=0, j=1;
                while(i<5){

                    pessoa.Add(new Pessoa(" " , " "));

                    Console.WriteLine($"Informe o nome da {j} pessoa: ");
                    pessoa[i].Nome=Console.ReadLine();
                    Console.WriteLine($"Informe o cargo da {j} pessoa (Starter, Junior ou Sênior): ");
                    pessoa[i].Cargo=Console.ReadLine();

                    i++;
                    j++;
                    }
            
                    int Lenght_pessoa = pessoa.Count;

                    int z, qtdStarter = 0, qtdJunior=0, qtdSenior=0;

                    for(i=0; i<pessoa.Count; i++){

                        
                        if (pessoa[i].Cargo.ToString()  == "Starter" )
                        {
                            qtdStarter++;
                        }

                        if(pessoa[i].Cargo.ToString()  == "Junior"){
                            qtdJunior++;
                        }

                        if(pessoa[i].Cargo.ToString()  == "Senior")
                        {
                            qtdSenior++;
                        }

                         if(pessoa[i].Cargo.ToString() != "Starter" 
                        && pessoa[i].Cargo.ToString() != "Junior" 
                        &&  pessoa[i].Cargo.ToString() != "Senior" )
                        {
                            qtdSenior++;
                        }


                        Console.WriteLine("Total de pessoas");
                        Console.WriteLine($"Starter: {qtdStarter}");
            }           Console.WriteLine($"Junior: {qtdJunior}");
                        Console.WriteLine($"Sênior: {qtdSenior}");

                
                
        }
    }

}
