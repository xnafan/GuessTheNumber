namespace GuessTheNumberPrettified;

internal class Program
{
    static void Main(string[] args)
    {
        int maxValue = 20;
        GuessingGame game = new GuessingGame(maxValue);
        do
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
            if (resultat == GuessingGame.Result.Correct) { Console.WriteLine("Correct"); }
            else if (resultat == GuessingGame.Result.TooLow) { Console.WriteLine("Too low"); }
            else { Console.WriteLine("Too high"); }

            //write number of guesses used so far
            Console.WriteLine($"You've used {game.NumberOfGuessesUsed} guesses");
        } while (!game.Guessed);
    }
}