namespace IRCalculator.Domain
{
    public class Aliquota
    {
        public static Aliquota Isento = new Aliquota(1903.98);
        public static Aliquota SeteMeio = new Aliquota(2826.65);
        public static Aliquota Quinze = new Aliquota(3751.05);
        public static Aliquota VinteDoisMeio = new Aliquota(4664.68);
        public static Aliquota Max = new Aliquota(4664.69);

        public double Salario { get; set; }
        public double Percentual {
            get {
                return GetPercentual(Salario);
            }
        }
        public double Deducao {
            get {
                return GetDeducao(Salario);
            }
        }

        public double SalarioLiquido {
            get {
                if (Salario > Isento.Salario)
                {
                    return Salario - (Salario * Percentual - Deducao);
                }
                return Salario;
            }
        }

        public Aliquota() { }
        public Aliquota(double salario)
        {
            Salario = salario;
        }


        private double GetDeducao(double salario)
        {
            if (salario <= 1903.98)
            {
                return 0;
            }

            if (salario <= 2826.65)
            {
                return 142.80;
            }

            if (salario <= 3751.05)
            {
                return 354.80;
            }

            if (salario <= 4664.68)
            {
                return 636.13;
            }

            return 869.36;
        }

        private double GetPercentual(double salario)
        {
            if (salario <= 1903.98)
            {
                return 0.0 / 100.0;
            }

            if (salario <= 2826.65)
            {
                return 7.5 / 100.0;
            }

            if (salario <= 3751.05)
            {
                return 15.0 / 100.0;
            }

            if (salario <= 4664.68)
            {
                return 22.5 / 100.0;
            }

            return 27.5 / 100.0;
        }

    }
}
