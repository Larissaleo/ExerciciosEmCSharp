using System;

class Program{

    static void Main(string[] args)
    {
        int multiplicando, inicioIntervalo, fimIntervalo, diferencaIntervalo;

        multiplicando = int.Parse(Console.ReadLine());
        inicioIntervalo = int.Parse(Console.ReadLine());
        fimIntervalo = int.Parse(Console.ReadLine());

        diferencaIntervalo = fimIntervalo-inicioIntervalo;

        if(multiplicando > 1000){
           Console.WriteLine("O multiplicando não pode ser maior que 1000."); 

           return;
        }

        if(inicioIntervalo > 1000 || inicioIntervalo < 0 || fimIntervalo > 1000 || fimIntervalo < 0 )
        {
            Console.WriteLine("Tanto o início como o fim do intervalo, não podem ser números negativos e não podem ser maiores de 1000");

            return;
        }
            

        if (diferencaIntervalo>10){
            Console.WriteLine("O intervalo não pode ter uma diferença maior que 10.");

            return;
        }

        if(inicioIntervalo>=fimIntervalo){
            Console.WriteLine("O início do intervalo deve ser menor que seu fim");

            return;

        }

        
        
        Console.WriteLine($"Multiplicando: {multiplicando}");
        Console.WriteLine($"Início do intervalo: {inicioIntervalo}");

        Console.WriteLine($"Fim do intervalo: {fimIntervalo}");

        int i, cont=0, produto;

        

        for(i=inicioIntervalo; i<fimIntervalo; i++){


            if(i<fimIntervalo){
            produto = multiplicando *i ;

            Console.WriteLine("{0} X {1} = {2}", multiplicando, i, produto);
            cont++;
                
            }


            
            

        }
        
       



    }
}

