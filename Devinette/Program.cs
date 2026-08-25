public class Program
{
    static int GenereNombreAleatoir()
    {
        Random random = new Random();
        int min = 0;
        int max = 100;
        return random.Next(min, max);
    }

    static void DevinerNombre()
    {
        int nombreADeviner = GenereNombreAleatoir();
        int nbEssai = 0;
        int guess;
        do
        {
            Console.Write("Entre un nombre : ");
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Entrée invalide, réessaie.");
            }
            nbEssai++;
            if (guess > nombreADeviner)
            {
                Console.WriteLine("Le nombre est plus petit");
            }
            else if (guess < nombreADeviner)
            {
                Console.WriteLine("Le nombre est plus grand");
            }
            else
            {
                Console.WriteLine("Tu a bien deviner");
                return;
            }
            ;
        } while (nbEssai <= 10);
    }

    static void Main(string[] args)
    {
        DevinerNombre();
    }
}
