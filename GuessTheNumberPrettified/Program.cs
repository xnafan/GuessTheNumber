namespace GuessTheNumberPrettified;

internal class Program
{
    static void Main(string[] args)
    {
        int maxValue = 20;
        GuessingGame game = new GuessingGame(maxValue);
        while (!game.Guessed)
        {
            int currentGuess;
            bool validInput = false;
            do
            {
                //get current guess from user
                Console.Write($"Enter a number from 1 to {maxValue}: ");
                string? guessAsString = Console.ReadLine();

                //try converting the input to a number
                validInput = int.TryParse(guessAsString, out currentGuess);
                if (!validInput) { Console.WriteLine("Invalid input..."); }
            } while (!validInput);

            //get result from the guessing game object
            GuessingGame.Result resultat = game.Guess(currentGuess);
            
            //give feedback to user
            if (resultat == GuessingGame.Result.Correct){Console.WriteLine("Korrekt");}
            else if (resultat == GuessingGame.Result.TooLow){Console.WriteLine("For lavt");}
            else{Console.WriteLine("For højt");}

            //write number of guesses used so far
            Console.WriteLine($"Du har brugt {game.NumberOfGuessesUsed} gæt");
        }
    }
}