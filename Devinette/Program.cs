namespace Devinette
{
    public class Program
    {
        static int PromptNumber(string message)
        {
            int nombre;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out nombre))
            {
                Console.WriteLine("Entrée invalide, réessaie.");
                Console.Write(message);
            }
            return nombre;
        }

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
                guess = PromptNumber("Entré un nombre:");
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
            } while (nbEssai < 10);

            Console.WriteLine($"Perdu, le nombre était {nombreADeviner}");
        }

        static void Main(string[] args)
        {
            DevinerNombre();
        }
    }
}
