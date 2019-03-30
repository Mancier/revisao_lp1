using System;

namespace Revisao
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Variaveis locais ==> Main
            int selected = 0;
            char shouldRepeat;

            /*
             * Invocando e estanciando cada atividade da lista para ser usada no código
             * O padrao é:
             * <nome da classe> <apelido> = new <nome da classe>
             */
            activity_one at1 = new activity_one(); //Invocando ativity_one para dentro de Program.Main()
            activity_two at2 = new activity_two(); //Invocando ativity_two para dentro de Program.Main()
            activity_three at3 = new activity_three(); //Invocando ativity_two para dentro de Program.Main()
            activity_four at4 = new activity_four(); //Invocando ativity_two para dentro de Program.Main()

            /*
             * Aprensentando um menu para o cliente
             */
            do{
                Console.WriteLine("Selecione uma das atividades abaixo para ser executada");
                for (int i = 0; i < 10; i++) //Preguiça de programador
                {
                    Console.WriteLine("\t{0} - Atividade {0}", i + 1);
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
                    case 2:
                        at2.startingActiveTwo(); //<apelido>.nomeFuncao();
                        break;
                    case 3:
                        at3.startingAtivityThree();
                        break;
                    case 4:
                        at4.startingAtivityFour();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

                do{
                    Console.Write("Deseja repetir(Y/N): ");
                    char.TryParse(Console.ReadLine(), out shouldRepeat);
                    shouldRepeat = char.ToLower(shouldRepeat);
                } while (shouldRepeat != 'y' || shouldRepeat != 'n');
            } while (shouldRepeat == 'y');
        } 
    }
}