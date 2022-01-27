using System;
using Cargos.src.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Cargos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Controle de funcionarios");


            List<Pessoa> pessoa = new List<Pessoa>();
                int Lenght_pessoa = pessoa.Count;
                pessoa.Add(new Pessoa(" " , " "));
                pessoa.Add(new Pessoa(" " , " "));
                pessoa.Add(new Pessoa(" " , " "));
                pessoa.Add(new Pessoa(" " , " "));
                pessoa.Add(new Pessoa(" " , " "));

            

                Console.WriteLine("Informe o nome da 1ª pessoa: ");
                pessoa[0].Nome=Console.ReadLine();
                Console.WriteLine("Informe o cargo da 1ª pessoa (Starter, Junior ou Sênior): ");
                pessoa[0].Cargo=Console.ReadLine();

                Console.WriteLine("Informe o nome da 2ª pessoa: ");
                pessoa[1].Nome=Console.ReadLine();
                Console.WriteLine("Informe o cargo da 2ª pessoa (Starter, Junior ou Sênior): ");
                pessoa[1].Cargo=Console.ReadLine();

                Console.WriteLine("Informe o nome da 3ª pessoa: ");
                pessoa[2].Nome=Console.ReadLine();
                Console.WriteLine("Informe o cargo da 3ª pessoa (Starter, Junior ou Sênior): ");
                pessoa[2].Cargo=Console.ReadLine();

                Console.WriteLine("Informe o nome da 4ª pessoa: ");
                pessoa[3].Nome=Console.ReadLine();
                Console.WriteLine("Informe o cargo da 4ª pessoa (Starter, Junior ou Sênior): ");
                pessoa[3].Cargo=Console.ReadLine();

                Console.WriteLine("Informe o nome da 5ª pessoa: ");
                pessoa[4].Nome=Console.ReadLine();
                Console.WriteLine("Informe o cargo da 5ª pessoa (Starter, Junior ou Sênior): ");
                pessoa[4].Cargo=Console.ReadLine();

                    int i, qtdStarter = 0, qtdJunior=0, qtdSenior=0;

                    for(i=0; i<pessoa.Count; i++){

                        
                        if (pessoa[i].Cargo.ToString()  == "Starter" )
                        //||pessoa[i].Cargo.ToString() == "starter" || pessoa[i].Cargo.ToString() == "STARTER")
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

            }
                    Console.WriteLine("Total de pessoas");
                    Console.WriteLine($"Starter: {qtdStarter}");
                    Console.WriteLine($"Junior: {qtdJunior}");
                    Console.WriteLine($"Sênior: {qtdSenior}");

                
                
        }
    }

}
