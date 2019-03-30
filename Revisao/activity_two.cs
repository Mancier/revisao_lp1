using System;
using System.Globalization;

namespace Revisao
{
    public class activity_two
    {
        public void startingActiveTwo()
        {
            int applesCount = 0;
            float price = 1;
            Console.WriteLine("==>> Quintada do Jao <<==");
            Console.Write("Total de Macas: ");
            int.TryParse(Console.ReadLine(), out applesCount);
            price = (applesCount > 12) ?  1 : 1.3f;
            Console.WriteLine("\t================================");
            Console.WriteLine("\tQuantidade: {0}", applesCount);
            Console.WriteLine("\tValor Unitario: {0}", price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\tTotal: {0}", (applesCount * price).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\t================================");
        }
    }
}