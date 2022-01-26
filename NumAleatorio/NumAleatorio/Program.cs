using System;

class Program{

    static void Main(string[] args)
    {
    Random NumAleatorio = new Random();

    int NumGerado = NumAleatorio.Next(0,7);

    int ValorUser;
    System.Console.WriteLine("Tente adivinhar o número gerado: ");
    ValorUser = int.Parse(Console.ReadLine());

    while(ValorUser != NumGerado){
        System.Console.WriteLine(":( Esse não foi o número gerado. Tente novamente");
        ValorUser = int.Parse(Console.ReadLine());


    }
        if(ValorUser == NumGerado){
        System.Console.WriteLine($"Parabéns você acertou o numero gerado foi {NumGerado}");
        
        }
    


    }
    


}