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


            // Affiche les différente message.
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
            // Définit un tableau de chaînes de caractères
            string[] mois = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };

            int primeDecembre = 0;
            if (mois[12] == "Décembre")
            {
                primeDecembre = (int)(salary * 0.22);
            }

            for (int i = 0; i < mois.Length; i++)
            {
                Console.WriteLine(mois[i] + " : " + (i == 11 ? salaryNet + primeDecembre : salaryNet));
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
