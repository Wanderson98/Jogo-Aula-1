using System;

namespace Aula1Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            int tentativas = 1;
            int chute = 0;
            do
            {
                resultado = new Random().Next(1, 5);
                Console.WriteLine("Digite um número entre 1 e 10 ou 0 para Desitir: ");
                chute = int.Parse(Console.ReadLine());

                if (resultado == chute)
                {
                    Console.WriteLine("Parabéns você acertou em {0} tentativas !!", tentativas);
                }
                else if (chute == 0)
                {
                    Console.WriteLine("Você arregou em {0} tentativas !", tentativas);
                }
                else
                {   
                    Console.WriteLine("Errrrouuu!! Tente Novamente \n");
                    tentativas++;
                    
                }

            } while (resultado != chute && chute != 0);

            
        }
    }
}
