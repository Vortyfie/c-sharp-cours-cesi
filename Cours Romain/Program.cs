using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrez votre salaire :");

        int salary;
        bool salaryIsInt = int.TryParse(Console.ReadLine(), out salary);

        Console.WriteLine("Entrez le taux de taxe :");

        int tax;
        bool taxIsInt = int.TryParse(Console.ReadLine(), out tax);

        if (salaryIsInt && taxIsInt)
        {
            int salarynet = Impots(salary, tax);

            Console.WriteLine("Salaire Net : " + salarynet);

            if (salarynet < 1500)
            {
                Console.WriteLine("Tu est alternant pour toucher moins de 1500net par mois.");
            }
            else
            {
                Console.WriteLine("Tu est certernement pas alternant pour toucher plus de 1500€ par mois.");
            }
        }
        else
        {
            Console.WriteLine("Erreur : le salaire et la taxe doivent être des nombres entiers€.");
        }

        Console.ReadLine();
    }

    static int Impots(int a, int b)
    {
        int salary = a;
        double taxes = b / 100.0;
        int salarytemp = (int)(a * taxes);
        salary = salary - salarytemp;
        return salary;
    }
}
