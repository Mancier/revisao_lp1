using System;

namespace Revisao
{
    public class activity_five
    {
        public void startingActivityFive(){
            string[] produtcs = new string[5];
            int i = 0;
            Console.WriteLine("==>> Cadastro de Fornecedor <<==");
            while (i < 5){
                Console.Write("{0} - Nome do Produto: ", i+1);
                produtcs[i] = Console.ReadLine();
                i++;
            }
            i = 0;
            Console.WriteLine("\t================================");
            Console.WriteLine("Valores inseridos");
            while (i < 5){
                Console.WriteLine("{0} - Nome do Produto: {1}", i+1, produtcs[i]);
                i++;
            }
            Console.WriteLine("\t================================");            
    }

}
}