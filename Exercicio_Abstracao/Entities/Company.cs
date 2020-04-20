using System;

namespace Exercicio_Abstracao.Entities
{
    class Company : Taxpayer
    {
        public int NumberOfEmploees { get; protected set; }

        public Company(string name, double anualIncome, int numberOfEmploees) : base(name, anualIncome)
        {
            NumberOfEmploees = numberOfEmploees;
        }

        public override double TaxesPaid()
        {
            double taxPays = 0;
            if (NumberOfEmploees > 10)
            {
                taxPays = AnualIncome * 0.14;
            }
            else
            {
                taxPays = AnualIncome * 0.16;
            }
            return taxPays;
        }
    }
}
