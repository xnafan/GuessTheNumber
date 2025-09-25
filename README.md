# Guess the number
A step-by-step guide from description to flowchart to pseudocode to code.

## Description
The assignment is to code a small game where 
- the game comes up with a secret, hidden number
- the user tries to guess the random number
- for each guess, the game tells the user whether the guess is
  - lower,
  - higher or
  - equal to the random number

## Flowchart
Here you can see the logic for the game
<img width="440" height="500" alt="image" src="https://github.com/user-attachments/assets/04e3c06e-ae1c-44b9-849e-b41bf97b7977" />


## Pseudocode
Here is the algorithm written in pseudocode, so its structure can be converted to most high-level programming languages:
```
roll secret number from 1 to maxValue
//get guesses, while the secret number has not been guessed
do
    //get input until it is valid (is a valid number and not text/symbols. etc.)
    do 
        print "Write your guess from 1 to [maxValue]"
        correct guess = RetrieveInput()
    while not valid input
    if(correct guess) print "Correct"; exit do-loop
    else if (too low) print "Too low"
    else print "Too hight"
while not correctguess
```
## Code
