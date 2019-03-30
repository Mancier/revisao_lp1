using System;
using System.Globalization;

namespace Revisao
{
    public class activity_one
    {
        public int startingActiveOne()
        {
            float salary = 0, securitySocial = 0, incomeTax = 0;
            Console.WriteLine("==>> Cálculo de Salário <<==");
            Console.Write("Salário do funcionario: ");
            float.TryParse(Console.ReadLine(), out salary);
            /*
             * Inicando os calculos das taxas
             */
            securitySocial = taxCalc(salary, 20); //Securidade Social
            incomeTax = incomeTaxCalc(salary); //Imposto de Renda
            
            /*
             * Exibindo os valores das taxas
             */
            Console.WriteLine("\tSalario Bruto: {0}", salary);
            Console.WriteLine("\tDesconto Securidade Social: {0}", securitySocial.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\tDesconto Imposto de Renda: {0}", incomeTax.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\t=====================================");
            Console.WriteLine("\tSalario Liquido: {0}", (salary-(securitySocial+incomeTax)).ToString("F2", CultureInfo.InvariantCulture));
            return 1;
        }

        /*
         * Funcao generica para calculo de taxas
         */
        private static float taxCalc(float salary, int percentage)
        {
            return salary * (percentage/100f); 
        }
        
        /*
         * Funcao para calculo do imposto de renda
         */
        private static float incomeTaxCalc(float salary)
        {
            if (salary < 998)
            {
                return salary;
            }
            else
            {
                if (salary >= 998 && salary < 3000)
                {
                    return taxCalc(salary, 12);
                } else 
                {
                    if (salary <= 3000 && salary > 5000)
                    {
                        return taxCalc(salary, 15);
                    } else
                    {
                        return taxCalc(salary, 18);
                    } // End #3
                } // End #2
            } // End #1
        }
    }
}