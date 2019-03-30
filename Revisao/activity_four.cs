using System;

namespace Revisao
{
    public class activity_four
    {
        public void startingAtivityFour()
        {
            int i = 0;
            Console.WriteLine("==>> Tabuada selecionada <<==");
            Console.Write("Entre com a tabuada desejada: ");
            int.TryParse(Console.ReadLine(), out i);
            Console.WriteLine("\t================================");
            for (int j = 0; j < 11; j++)
            {
                Console.WriteLine("\t{0} x {1} = {2}", i, j, i*j);
            }
            Console.WriteLine("\t================================");
        }
    }
}