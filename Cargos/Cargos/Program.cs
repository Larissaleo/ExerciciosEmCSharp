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

                //  Console.WriteLine("Informe o nome da 1ª pessoa: ");
                //  pessoa[2].Nome=Console.ReadLine();
                //  Console.WriteLine("Informe o cargo da 1ª pessoa (Starter, Junior ou Sênior): ");
                //  pessoa[2].Cargo=Console.ReadLine();

                // Console.WriteLine("Informe o nome da 1ª pessoa: ");
                // pessoa[3].Nome=Console.ReadLine();
                // Console.WriteLine("Informe o cargo da 1ª pessoa (Starter, Junior ou Sênior): ");
                // pessoa[3].Cargo=Console.ReadLine();

                // Console.WriteLine("Informe o nome da 1ª pessoa: ");
                // pessoa[4].Nome=Console.ReadLine();
                // Console.WriteLine("Informe o cargo da 1ª pessoa (Starter, Junior ou Sênior): ");
                // pessoa[4].Cargo=Console.ReadLine();

                int i = 0, qtdStarter = 0, qtdJunior=0, qtdSenior=0;

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

                
                
                Console.WriteLine($"Starter: {qtdStarter}");
                

                
            }

                
                
        }
    }