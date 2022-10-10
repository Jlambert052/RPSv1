namespace RPSgame;

    public class RPS {

        Random randomNum = new();

        private bool PlayMore() {
            System.Console.WriteLine("Would you like to play again? Y for yes, N for no:");
            string response = Console.ReadLine().ToUpper();
            if(response == "Y") {  
                return true;
            } if(response == "N") {
                return false;
            } if(response != "Y" || response != "N") {
                System.Console.WriteLine("Invalid response; try again.");
                PlayMore();
            }
                return true;
            

        }
        public int RpsPlay() {
            string inputPlayer;
            string Computer;
            int randomMove;
            bool playAgain = true;
            string[] RPSoptions = new string[3] {"ROCK", "PAPER", "SCISSORS" };
            int wins = 0;
            int losses = 0;
            int ties = 0;
            while(playAgain){

            randomMove = randomNum.Next(1, 4);
            Console.WriteLine("To Play enter ROCK, PAPER, or SCISSORS!");
            inputPlayer = Console.ReadLine().ToUpper();
            if(!RPSoptions.Contains(inputPlayer)) {
                System.Console.WriteLine($"{inputPlayer} is not a valid move; please enter ROCK, PAPER, or SCISSORS.");
                inputPlayer = Console.ReadLine().ToUpper();
            }
            
            switch(randomMove) {

                case 1:
                    Computer = "ROCK";
                    if(inputPlayer == "ROCK") {
                        System.Console.WriteLine("It's a tie!");
                        ties ++;
                    } else if(inputPlayer == "PAPER") {
                        System.Console.WriteLine("Paper beats rock! You got them!");
                        wins ++;
                    } else if(inputPlayer == "SCISSORS") {
                        System.Console.WriteLine("Your Scissors are crushed; Ouch!");
                        losses ++;
                    }
                    break;
                case 2:
                    Computer = "PAPER";
                    if(inputPlayer == "ROCK") {
                        System.Console.WriteLine("Ouch, your rock gets wrapped up.");
                        losses ++;
                    } else if(inputPlayer == "PAPER") {
                        System.Console.WriteLine("It's a tie!");
                        ties ++;
                    } else if(inputPlayer == "SCISSORS") {
                        System.Console.WriteLine("Snip snip! You win!");
                        wins ++;
                    }

                    break;
                case 3:
                    Computer = "SCISSORS";
                    if(inputPlayer == "ROCK") {
                        System.Console.WriteLine("You crush their scissors!");
                        wins ++;
                    } else if(inputPlayer == "PAPER") {
                        System.Console.WriteLine("Oh no! You get diced up.");
                        losses ++;
                    } else if(inputPlayer == "SCISSORS") {
                        System.Console.WriteLine("You can snip scissors; tie!");
                        ties ++;
                    }
                    break;

            }
            System.Console.WriteLine($"You have {wins} wins, {losses} losses, and {ties} ties.");
            if(wins > losses) {
                System.Console.WriteLine("Great job; the robot is losing and earth is safe");
            } else if (wins < losses) {
                System.Console.WriteLine("Bad news; the robot is winning; not looking good for earth. Maybe we should sub someone else in?");
            } else if(wins == losses) {
                System.Console.WriteLine("Close match; this next round could decide it all!");
            }
            playAgain = PlayMore();

            }
            System.Console.WriteLine("Thank you for playing!");
            if(wins > losses) 
                System.Console.WriteLine("Congratulations, you have saved the earth. Here is a gold star.");
            if(wins < losses)
                System.Console.WriteLine("The earth is doomed; the robot brings out the planet sized PAPER and beats our home rock.");
            if(ties > 10)
                System.Console.WriteLine("Wow, that's a lot of ties");
            return wins;
        }
    }