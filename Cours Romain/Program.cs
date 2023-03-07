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
            int salaryNet = Impots(salary, tax);

            Console.WriteLine("Salaire Net : " + salaryNet);

            switch (salaryNet)
            {
                case int n when n < 0:
                    Console.WriteLine("Erreur : le salaire net ne peut pas être négatif.");
                    break;
                case int n when n < 1500:
                    Console.WriteLine("Tu es alternant pour toucher moins de 1500 € par mois.");
                    break;
                default:
                    Console.WriteLine("Tu n'es certainement pas alternant pour toucher plus de 1500 € par mois.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Erreur : le salaire et la taxe doivent être des nombres entiers.");
        }

        Console.ReadLine();
    }

    static int Impots(int a, int b)
    {
        int salary = a;
        double taxes = b / 100.0;
        int salaryTemp = (int)(a * taxes);
        salary = salary - salaryTemp;
        return salary;
    }
}
