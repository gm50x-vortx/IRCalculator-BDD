using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IRCalculator.Domain
{
    public class IRCalculator
    {
        public double _salario;

        public IRCalculator()
        {
        }
        public IRCalculator(double salario)
        {
            this._salario = salario;

        }

        public double CalculaSalario()
        {
            var aliquota = new Aliquota(_salario);
            string mensagem = GetMensagemSalario(aliquota);
            Console.WriteLine(mensagem);
            return aliquota.SalarioLiquido;
        }

        private string GetMensagemSalario(Aliquota aliquota)
        {
            if (aliquota.Salario <= Aliquota.Isento.Salario)
            {
                return $"Meu salário {aliquota.Salario} é abaixo de {Aliquota.Isento.Salario} " +
                $"portanto meu salário total é: {Math.Round(aliquota.SalarioLiquido, 2)}";
            }

            if (aliquota.Salario >= Aliquota.SeteMeio.Salario && aliquota.Salario <= Aliquota.Quinze.Salario)
            {
                return $"Meu salário {aliquota.Salario} é acima de {Aliquota.SeteMeio.Salario} " +
                $"e abaixo de {Aliquota.Quinze.Salario} " +
                $"portanto meu salário total é: {Math.Round(aliquota.SalarioLiquido, 2)}";
            }

            if (aliquota.Salario >= Aliquota.Quinze.Salario && aliquota.Salario <= Aliquota.VinteDoisMeio.Salario)
            {
                return $"Meu salário {aliquota.Salario} é acima de {Aliquota.SeteMeio.Salario} " +
                $"e abaixo de {Aliquota.Quinze.Salario} " +
                $"portanto meu salário total é: {Math.Round(aliquota.SalarioLiquido, 2)}";
            }

            if (aliquota.Salario >= Aliquota.VinteDoisMeio.Salario && aliquota.Salario <= Aliquota.Max.Salario)
            {
                return $"Meu salário {aliquota.Salario} é acima de {Aliquota.SeteMeio.Salario} " +
                $"e abaixo de {Aliquota.Quinze.Salario} " +
                $"portanto meu salário total é: {Math.Round(aliquota.SalarioLiquido, 2)}";
            }

            return $"Meu salário {aliquota.Salario} é acima de {Aliquota.SeteMeio.Salario} " +
            $"e abaixo de {Aliquota.Quinze.Salario} " +
            $"portanto meu salário total é: {Math.Round(aliquota.SalarioLiquido, 2)}";
        }
    }
}
