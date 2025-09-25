using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberPrettified;
public class GuessingGame
{
    public enum Result { TooLow, Correct, TooHigh }
    public bool Guessed { get; private set; }
    public int NumberOfGuessesUsed { get; private set; }
    public int MaxValue { get; set; }

    private int _correctValue;

    public GuessingGame(int maxValue)
    {
        this.MaxValue = maxValue;
        this._correctValue = Random.Shared.Next(maxValue) + 1;
    }

    internal Result Guess(int guess)
    {
        NumberOfGuessesUsed++;
        if (guess < _correctValue) { return Result.TooLow; }
        else if (guess == _correctValue) { Guessed = true; return Result.Correct; }
        else { return Result.TooHigh; }
    }
}
