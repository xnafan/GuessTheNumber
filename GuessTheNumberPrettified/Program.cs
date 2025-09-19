namespace GuessTheNumberPrettified;

internal class Program
{
    static void Main(string[] args)
    {

        int maxValue = 20;
        GuessingGame game = new GuessingGame(maxValue);
        while (!game.Guessed)
        {
            //Bed om et gæt
            Console.Write($"Indtast et tal mellem 1 og {game.MaxValue}: ");
            string? gætSomTekst = Console.ReadLine();

            //konvertér indtastning til tal
            int gæt = Convert.ToInt32(gætSomTekst);
            GuessingGame.Result resultat = game.Guess(gæt);
            if (resultat == GuessingGame.Result.Correct)
            {
                Console.WriteLine("Korrekt");
            }
            else if (resultat == GuessingGame.Result.TooLow)
            {
                Console.WriteLine("For lavt");
            }
            else
            {
                Console.WriteLine("For højt");
            }

            Console.WriteLine($"Du har brugt {game.NumberOfGuessesUsed} gæt");
        }


    }
}
