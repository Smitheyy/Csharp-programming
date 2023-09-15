using System.ComponentModel.Design;
using System.Xml.Serialization;

Random random = new Random();
bool play_again = true;
String player;
String computer;
String choice;


while (play_again)
{
    player = "";
    computer = "";
    

    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("You must enter either rock, paper or scissors to play the game");       
        Console.Write("Enter either Rock, paper or scissors to play: ");
        player = Console.ReadLine();
        player = player.ToUpper();
    }


    switch (random.Next(1, 4))
    {
        case 1:
            computer = "ROCK";
            break;

        case 2:
            computer = "PAPER";
            break;

        case 3:
            computer = "SCISSORS";
            break;
    }

    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("Player has picked: " + player);
    Console.WriteLine("Computer has picked: " + computer);
    Console.WriteLine("-------------------------------------------------");


    switch (player)
    {
        case "ROCK":
            if (computer == "SCISSORS")
            {
                Console.WriteLine("You win");
                Console.WriteLine("-------------------------------------------------");
            }

            else if (computer == "ROCK")
            {
                Console.WriteLine("It's a draw!");
                Console.WriteLine("-------------------------------------------------");
            }

            else if (computer == "PAPER")
            {
                Console.WriteLine("You lose!");
                Console.WriteLine("-------------------------------------------------");
            }
            break;

        case "PAPER":
            if (computer == "ROCK")
            {
                Console.WriteLine("You win!");
                Console.WriteLine("-------------------------------------------------");
            }
            
            else if (computer == "PAPER")
            {
                Console.WriteLine("It's a draw!");
                Console.WriteLine("-------------------------------------------------");
            }

            else if (computer == "SCISSORS")
            {
                Console.WriteLine("You lose!");
                Console.WriteLine("-------------------------------------------------");
            }
            break;

        case "SCISSORS":
            if (computer == "PAPER")
            {
                Console.WriteLine("You win!");
                Console.WriteLine("-------------------------------------------------");
            }

            else if (computer == "SCISSORS")
            {
                Console.WriteLine("It's a draw");
                Console.WriteLine("-------------------------------------------------");
            }

            else if (computer == "ROCK")
            {
                Console.WriteLine("You lose!");
                Console.WriteLine("-------------------------------------------------");
            }
            break;
    
    }
    Console.Write("Do you want to play again? (Enter Y, for yes or N, for no): ");
    choice = Console.ReadLine();
    choice = choice.ToUpper();

    if (choice == "Y")
    {
        play_again = true;
    }

    else if (choice == "N")
    {
        play_again = false;
    }

    while (choice != "Y" && choice != "N")
    {
        Console.WriteLine("-------------------------------------------------");
        Console.Write("You have to enter Y for yes or N for no: ");
        choice = Console.ReadLine();
        choice = choice.ToUpper();

        if (choice == "Y")
        {
            play_again = true;
        }

        else if (choice == "N")
        {
            play_again = false;
        }
    }
    

} 


Console.ReadKey();
