using System;

namespace Game
{
    class Play
    {
        static int playGame(int userWins)
        {
            // initiate Computer object and boolean for response
            Computer compChoice = new Computer();
            bool validResp = false;

            // user input for choice in game
            do
            {
                Console.WriteLine("Rock, Paper, or Scisscors? Please use Rock, Paper, or Scisscors.");
                string userChoice = Console.ReadLine().ToUpper();
                
                // user input verification
                if(userChoice == "ROCK" || userChoice == "PAPER" || userChoice == "SCISSCORS"
                    || userChoice == "R" || userChoice == "P" || userChoice == "S")
                {
                    validResp = true;
                }
                else
                {
                    Console.WriteLine("Invalid response from User. Please input rock, paper, or scissors.");
                }
            }while(validResp != true);

            // check for game winning scenarios
            if(userWins > 5)
            {
                switch(userChoice)
                {
                    case "ROCK":
                        compChoice.set("PAPER");
                        break;
                    case "PAPER":
                        compChoice.set("SCISSCORS");
                        break;
                    case "SCISSCORS":
                        compChoice.set("ROCK");
                        break;
                    default:
                        Console.WriteLine("Fatal Computer Error. User wins!");
                        break;
                }
            }
            else
            {
                switch(userChoice)
                {
                    case "ROCK":
                        compChoice.get();
                        break;
                    case "PAPER":
                        compChoice.get();
                        break;
                    case "SCISSCORS":
                        compChoice.get();
                        break;
                    default:
                        Console.WriteLine("Fatal Computer Error. User wins!");
                        break;
                }
            }


        }
    }
}