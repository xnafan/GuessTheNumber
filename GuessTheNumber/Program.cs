namespace GuessTheNumber;

internal class Program
{
    private const int MaxValue = 20;
    static void Main(string[] args)
    {
        //Generate a number
        int secretNumber = Random.Shared.Next(MaxValue) + 1;
        int currentGuess;
        do
        {
            bool validInput = false;
            do
            {
                //get current guess from user
                Console.Write($"Enter a number from 1 to {MaxValue}: ");
                string? guessAsString = Console.ReadLine();

                //try converting the input to a number
                validInput = int.TryParse(guessAsString, out currentGuess);
                if (!validInput) { Console.WriteLine("Invalid input..."); }
            } while (!validInput);

            //Compare current guess with secret number
            if (currentGuess == secretNumber) { Console.WriteLine("Correct!"); }
            else if (currentGuess > secretNumber) { Console.WriteLine("Your guess is too high!"); }
            else { Console.WriteLine("Your guess is too low!"); }

        } while (currentGuess != secretNumber);
        //keep going, while the current guess is not the secret number
    }
}