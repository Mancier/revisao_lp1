using System;

namespace Revisao
{
    public class activity_three
    {
        public void startingAtivityThree()
        {
            Console.WriteLine("==>> Tabuada do 2 e 3 <<==");
            for (int i = 1; i < 3; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i*j);
                }
                Console.WriteLine("---------------------------------");
            }
        }
    }
}