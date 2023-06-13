using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Jogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random sorteador =new Random();
            int numero;
            int sorteio = sorteador.Next(1,11);
            // Simbolo || = ou , apenas uma das duas condições devem ser satisfeitas
            // simbolo && = E,   duas tem que ser satisfeitas
            Console.WriteLine("Bem-vindo a Condito Jogos \n");
            Console.WriteLine("Adivinhe o numero de 1 até 10");
            Console.WriteLine("Digite o número:");
            numero= int.Parse(Console.ReadLine());
            
            Console.WriteLine("Parabéns,você digitou corretamente");
            if(numero>10 || numero < 1) //&& para colocar mais uma condição no if
            {
                Console.WriteLine("Digite um valor valido");
                Main(null);
                return;
            }
            if(numero == sorteio)
            {
                Console.WriteLine("Parabéns, você acertou o número e ganhou!");
            }
            else
            {
                Console.WriteLine("Que pena,tente novamente...");
                Main(null); 
                return;
            }
            Console.ReadKey();


        }
    }
}
