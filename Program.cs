using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program{
    enum Menu {Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }    

    static void Main(string [] args){
        
        bool saida = false;
        
        while(!saida){
            Console.WriteLine("Bem vindo a calculadora no Console, selecione uma das opcoes:");
            Console.WriteLine("1- Soma\n2- Subtracao\n3- Divisao\n4- Multiplicacao\n5- Potencia\n6- Raiz\n7- Sair");
            //conversao de string em int por meio de casting
            Menu opcao = (Menu)int.Parse(Console.ReadLine());
            
            switch(opcao){
                case Menu.Sair:
                    saida = true;
                    break;
            }
            
            Console.Clear();

        }

        
    }
}