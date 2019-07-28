using System;
using System.Collections.Generic;

namespace IRCalculator.IRConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> salarios = new List<double>();
            salarios.Add(1800.58);
            salarios.Add(2000.25);
            salarios.Add(2999.30);
            salarios.Add(4005.00);
            salarios.Add(6357.66);


            salarios.ForEach(salario => 
            {
                var sal = new Domain.IRCalculator(salario).CalculaSalario();
            });

            Console.ReadLine();
        }
    }
}
