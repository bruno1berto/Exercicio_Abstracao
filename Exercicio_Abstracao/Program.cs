using Exercicio_Abstracao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers of Tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<Taxpayer> taxpayers = new List<Taxpayer>();

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company? (i,c): ");
                char type = char.Parse(Console.ReadLine());
                while (type != 'i' && type != 'I' && type != 'c' && type != 'C')
                {
                    Console.Write("Latter invalid. Press (i or c): ");
                    type = char.Parse(Console.ReadLine());
                }
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: $ ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i' || type == 'I')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxpayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxpayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double sum = 0;
            foreach (Taxpayer taxp in taxpayers)
            {
                Console.WriteLine(taxp.Name + " $ " + taxp.TaxesPaid().ToString("F2"), CultureInfo.InvariantCulture);
                sum += taxp.TaxesPaid();
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " + sum.ToString("F2"),CultureInfo.InvariantCulture);
            Console.ReadLine();
        }
    }
}
