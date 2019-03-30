using System;

namespace Revisao
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Variaveis locais ==> Main
            int selected = 0;
            
            /*
             * Invocando e estanciando cada atividade da lista para ser usada no código
             * O padrao é:
             * <nome da classe> <apelido> = new <nome da classe>
             */
            activity_one at1 = new activity_one(); //Invocando ativity_one para dentro de Program.Main()
            
            /*
             * Aprensentando um menu para o cliente
             */
            Console.WriteLine("Selecione uma das atividades abaixo para ser executada");
            for (int i = 0; i < 10; i++) //Preguiça de programador
            {
                Console.WriteLine("\t{0} - Atividade {0}", i+1);
            }
            Console.Write("Selecione: ");
            int.TryParse(Console.ReadLine(), out selected); //tryParse => tenta converter o valor recebido, caso positivo, armazena, se não, exibe o erro.

            /*
             * Para usar a função que está em outra páginas, basta setar a classe (<apellido>).nomeFuncao
             */
            switch (selected)
            {
                case 1:
                    at1.startingActiveOne(); //<apelido>.nomeFuncao();
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
    }
}