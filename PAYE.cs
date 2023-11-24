using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("PAYE Calculator");
        while (true)
        {
            double gross;
            double allowances;

            // Get gross salary with error handling
            while (true)
            {
                Console.Write("Enter your gross salary: ");
                string grossInput = Console.ReadLine();

                try
                {
                    gross = Convert.ToDouble(grossInput);
                    break; // Break out of the loop if conversion is successful
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Get allowances with error handling
            while (true)
            {
                Console.Write("Enter your allowances: ");
                string allowancesInput = Console.ReadLine();

                try
                {
                    allowances = Convert.ToDouble(allowancesInput);
                    break; // Break out of the loop if conversion is successful
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid numerical value.");
                }
            }

            double taxableIncome = gross - allowances;
            double taxx;
            if (taxableIncome <= 24000)
            {
                taxx = taxableIncome * 0.1;
            }
            else if (taxableIncome <= 40000)
            {
                taxx = taxableIncome * 0.15;
            }
            else if (taxableIncome <= 60000)
            {
                taxx = taxableIncome * 0.2;
            }
            else if (taxableIncome <= 100000)
            {
                taxx = taxableIncome * 0.25;
            }
            else if (taxableIncome <= 150000)
            {
                taxx = taxableIncome * 0.3;
            }
            else if (taxableIncome <= 250000)
            {
                taxx = taxableIncome * 0.35;
            }
            else
            {
                taxx = taxableIncome * 0.4;
            }

            // Your tax calculation logic goes here...

            double personalRelief = 1000;
            double PAYE = taxx - personalRelief;

            // Output the results
            Console.WriteLine($"Gross pay = {gross}");
            Console.WriteLine($"Allowances = {allowances}");
            Console.WriteLine($"Taxable Income = {taxableIncome}");
            Console.WriteLine($"Personal Relief = {personalRelief}");
            Console.WriteLine($"PAYE = {PAYE}");
            Console.Write("Do you want to perform another calculation?(Y/N):");
            char continueCalculation = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.ToUpper(continueCalculation)!='Y')
            {
                break;
            }
        }
    }
}
