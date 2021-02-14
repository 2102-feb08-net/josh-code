using System;

namespace RPS.Library
{
    public class Computer
    {
        // variables used for computer object
        private string _compChoice;
        var rand = new Random(3);

        // method used for getting or setting the computer choice
        public string choice
        {
            get 
            { 
                var randNum = rand.next();

                if(randNum ==  0)
                {
                    _compChoice = Rock;
                }
                else if(randNum == 1)
                {
                    _compChoice = Paper;
                }
                else if(randNum == 2)
                {
                    _compChoice = Scissors;
                }
                else
                {
                    Console.WriteLine("Unknown Error Occurred");
                }
                return _compChoice; 
            }
        }

    }
}
