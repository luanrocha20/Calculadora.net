using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program{
    enum Menu {Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }    

    static void Main(string [] args){
        
        bool saida = false;
        
        while(!saida){
            Console.WriteLine("Bem vindo a calculadora de numeros inteiros, selecione uma das opcoes:");
            Console.WriteLine("1- Soma\n2- Subtracao\n3- Divisao\n4- Multiplicacao\n5- Potencia\n6- Raiz\n7- Sair");
            //conversao de string em int por meio de casting
            Menu opcao = (Menu)int.Parse(Console.ReadLine());
            
            switch(opcao){
                case Menu.Soma:
                    Soma();
                    break;
                case Menu.Subtracao:
                    Subtracao();
                    break;

                case Menu.Sair:
                    saida = true;
                    break;
            }
            
            Console.Clear();
        }
    }
    
    static void Soma(){
       
        int i;
        int resultadoFinal = 0;
        Console.WriteLine("Digite quantos numeros serao somados: ");
        int size = int.Parse(Console.ReadLine());
        int [] somados = new int [size];
        
        Console.WriteLine("Digite os numeros a serem calculados:");
        
        for(i = 0; i < size ; i++){
            somados[i] = int.Parse(Console.ReadLine());
        }

        for(i = 0; i < size ; i++){
            resultadoFinal = resultadoFinal + somados[i];
        }

        Console.WriteLine("\nResultado e igual a: "+ resultadoFinal);
        Console.WriteLine("\nPressione enter para retornar ao menu.");
        Console.ReadLine();

        }    


    static void Subtracao(){
        int i;
        int resultadoFinal = 0;
        Console.WriteLine("Digite quantos numeros serao calculados: ");
        int size = int.Parse(Console.ReadLine());
        int [] subtraidos = new int[size];

        Console.WriteLine("Digite os numeros a serem subtraidos: ");

        for(i = 0; i < size ; i++){
            subtraidos[i] = int.Parse(Console.ReadLine());
        }
        resultadoFinal = subtraidos[0];

        for (i = 1 ; i < size ; i++){
            resultadoFinal = resultadoFinal - subtraidos [i];
        }

        Console.WriteLine("\nResultado e igual a: "+ resultadoFinal);
        Console.WriteLine("\nPressione enter para retornar ao menu.");
        Console.ReadLine();
        }
}