using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberPrettified;

/// <summary>
/// This class encapsulates a "Guess the number" game, where you can keep guessing, receiving feedback in the form of "Lower, Higher or Correct". The game also counts the number of guesses used.
/// </summary>
public class GuessingGame
{
    /// <summary>
    /// An enumeration signifying the result of a guess
    /// </summary>
    public enum Result { Empty, TooLow, Correct, TooHigh }

    /// <summary>
    /// Has the number been guessed?
    /// </summary>
    public bool IsGuessed { get; private set; }

    /// <summary>
    /// How many calls to Guess() have been made
    /// </summary>
    public int NumberOfGuessesUsed { get; private set; }

    /// <summary>
    /// The maximum number possible in this game
    /// </summary>
    public int MaxValue { get; private set; }

    //The correct, secret value that the user must guess
    private int _secretValue;

    /// <summary>
    /// Instantiates a new guessing game with a random, secret number from 1 to maxValue
    /// </summary>
    /// <param name="maxValue">The maximum possible random number to guess in this game</param>
    public GuessingGame(int maxValue)
    {
        this.MaxValue = maxValue;
        this._secretValue = Random.Shared.Next(maxValue) + 1;
    }

    /// <summary>
    /// Try a guess while incrementing the NumberOfGuessesUsed property
    /// </summary>
    /// <param name="guess">The number you're trying to guess</param>
    /// <returns>Whether the guess was too low, too high or correct.</returns>
    internal Result Guess(int guess)
    {
        NumberOfGuessesUsed++;
        if (guess < _secretValue) { return Result.TooLow; }
        else if (guess == _secretValue) { IsGuessed = true; return Result.Correct; }
        else { return Result.TooHigh; }
    }
}
