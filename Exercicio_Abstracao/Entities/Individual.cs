using System;

namespace Exercicio_Abstracao.Entities
{
    class Individual : Taxpayer
    {
        public double HealthExpenditures { get; protected set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            double taxPaids=0;

            if (AnualIncome < 20000 && HealthExpenditures > 0)
            {
                if (HealthExpenditures/2 > AnualIncome)
                    taxPaids = 0;
                else
                    taxPaids = AnualIncome * 0.15 - HealthExpenditures / 2;
            }
            else if (AnualIncome >= 20000 && HealthExpenditures > 0)
            {
                if (HealthExpenditures / 2 > AnualIncome)
                    taxPaids = 0;
                else
                    taxPaids = AnualIncome * 0.25 - HealthExpenditures / 2;
            }
            else if (AnualIncome < 20000 && HealthExpenditures == 0)
            {
                taxPaids = AnualIncome * 0.15;
            }
            else if (AnualIncome >= 20000 && HealthExpenditures == 0)
            {
                taxPaids = AnualIncome * 0.25;
            }
            return taxPaids;
        }
    }
}
