
/*                  Rafael Manzo Mini 8 Ocho.. 
                    Guess it game!

           
                         10/20/2022 
 In this program the user will Guess a number 1 - 10, 1 - 50, 1 - 100.
*/


// we have our variables
Console.Clear();
int easyLvl = 10;
int mediumLvl = 50;
int hardLvl = 100;
int winningNumb = 0;
int gameMaxNum = 0;
int numGuess = 0;

string playagain = " ";
string option;
string userInput;

int guessCount;

bool validNum = false;





//while (playagain != "1")
//{
bool playover = true;
while (playover)
{


Console.WriteLine("This is a guessing game. The Computer will generate a number and you will enter what your guess is. What level would you like to play?");
Console.WriteLine("Easy 1 - 10");
Console.WriteLine("Medium 1 - 50");
Console.WriteLine("Hard 1 - 100");
Console.WriteLine("Enter Easy, Medium Hard");
option = Console.ReadLine();







    while (option != "Easy" && option != "Medium" && option != "Hard")
    {
        Console.WriteLine("You have entered an invalid choice.");
        Console.WriteLine("You can only choose from Easy, Medium, or Hard");
        option = Console.ReadLine();
    }



Console.WriteLine("You have chosen " + option);
//pick a random numbr based on diffuctly
Random random = new Random();


//===========================================================================================================
if (option == "Easy")
{
    winningNumb = random.Next(0, 10);
    gameMaxNum = easyLvl;
}
if (option == "Medium")
{
    winningNumb = random.Next(0, mediumLvl);
    gameMaxNum = mediumLvl;
}
if (option == "Hard")
{
    winningNumb = random.Next(0, hardLvl);
    gameMaxNum = hardLvl; //- 1;
}
//==============================================================================================

while (validNum == false)
{
    Console.WriteLine("Enter a valid number from 1 through " + gameMaxNum);
    userInput = Console.ReadLine();
    validNum = Int32.TryParse(userInput, out numGuess);
    if (validNum == true)
        if ((numGuess <= gameMaxNum) && (numGuess >= 1))
        {
            validNum = true;
        }

        else
        {
            Console.WriteLine("Please pick a valid number.");
            validNum = false;
        }


    else
    {
        Console.WriteLine("Your entry could not be read, please try again.");
    }


    //have computers number not users nnumber
    //needs to be converted into an int so the comparison will then evaluate
    //if you dont do this, your comparisons will never ever ever ever everrrrr run.
    ///string userguess = Console.ReadLine();
    ///Console.WriteLine(userguess);

    if (numGuess == winningNumb)
    {
        Console.WriteLine("You got the number right. The number was " + winningNumb);
    }
    else if (numGuess > winningNumb)
    {
        Console.WriteLine("Not the number. Your number is too high, man! The number was " + winningNumb);
    }
    else
    {
        Console.WriteLine("Not the Number. Your guess is to low..  The number was " + winningNumb);
    }
 
}

Console.WriteLine("Would you like to play again? type no to quit or any key to play again.");
    string answer01 = Console.ReadLine();
    int x;
    bool n = int.TryParse(answer01, out x);
    if (answer01 == "no")
    {
        playover = false;
    }
validNum = false;
 option = "Rafa";
}
