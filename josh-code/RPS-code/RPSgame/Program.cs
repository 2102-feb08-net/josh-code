using System;

namespace RPS_user
{
    class Program
    {
        static void Main(string[] args)
        {
            var compPlayer;
            var userPlayer;
            var compWins = 0;
            var userWins = 0;
            bool play = false;

            // do...while loop to play game
            do{
                // initiate game
                Game game = new Game();
                game.playGame(userWins);

                do{
                    // option to play again
                    Console.WriteLine("Play another game(Y/N)?");
                    string playAgain = Console.ReadLine().ToUpper();

                    // user response verification
                    bool validResp = false;

                    if(playAgain == "Y")
                    {
                        play = true;
                        validResp = true;
                    }
                    else if(playAgain == "N")
                    {
                        play = false;
                        validResp = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Response. Please answer with Y or N.");
                        Console.WriteLine("Play another game(Y/N)?");
                        string playAgain = Console.ReadLine().ToUpper();
                    }
                }while(validResp = false);

            }while(play == true);
        }
    }
}
