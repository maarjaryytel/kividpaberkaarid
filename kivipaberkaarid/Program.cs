using System;

namespace kivipaberkaarid
{
	class Program
	{
		static void Main(string[] args)
		{
			string userName;
			string userChoice;

			int userScore = 0;
			int cpuScore = 0;

			bool gameOver = false;

			Console.WriteLine("Enter Your name: ");
			userName = Console.ReadLine();

			Console.WriteLine("Hello," + " " + userName + "!");

			while (cpuScore < 3 && userScore < 3 && !gameOver)
			{
				Console.WriteLine($"{userName}, please make Your choice: rock, paper or scissors!");
				userChoice = Console.ReadLine();

				Console.WriteLine("cpu, please make Your choice (enter a number from 1-3): ");

				Random rnd = new Random();
				int cpuChoice = rnd.Next(1, 4);
				Console.WriteLine(rnd.Next(1, 4));

				if (cpuChoice == 1)
				{
					if (userChoice == "rock")
					{
						Console.WriteLine("The computer chose rock");
						Console.WriteLine("It is a tie");
					}
					else if (userChoice == "paper")
					{
						Console.WriteLine("The computer chose rock");
						Console.WriteLine("You win, paper beats rock");
						userScore++;
					}
					else
					{
						Console.WriteLine("The computer chose rock");
						Console.WriteLine("Sorry, You lost, rock beats scissors");
						cpuScore++;
					}
				}
				else if (cpuChoice == 2)
				{
					if (userChoice == "rock")
					{
						Console.WriteLine("The computer chose paper");
						Console.WriteLine("Sorry, You lost, paper covers rock");
						cpuScore++;
					}
					else if (userChoice == "paper")
					{
						Console.WriteLine("The computer chose paper");
						Console.WriteLine("It is a tie");
					}
					else
					{
						Console.WriteLine("The computer chose paper");
						Console.WriteLine("You win, scissors cut paper");
						userScore++;
					}
				}
				else if (cpuChoice == 3)
				{
					if (userChoice == "rock")
					{
						Console.WriteLine("The computer chose scissors");
						Console.WriteLine("You win,rock beats scissors");
						userScore++;
					}
					else if (userChoice == "paper")
					{
						Console.WriteLine("The computer chose scissors");
						Console.WriteLine("Sorry, You lost, scissors cut paper");
						cpuScore++;
					}
					else
					{
						Console.WriteLine("The computer chose scissors");
						Console.WriteLine("It is a tie");
					}
				}
				else
				{
					Console.WriteLine("You must choose rock, paper or scissors!");
				}
			}
			userScore = userScore + 1;
			userScore++;
			cpuScore = cpuScore + 1;
			cpuScore++;
			Console.ReadLine();

			{
				if (userScore > cpuScore)
				{
					Console.WriteLine("Congratulation! You won 3 times!");
				}
				else if (userScore < cpuScore)
				{
					Console.WriteLine("Bad luck, You lost 3 times. The computer won the game. Try again!");
				}
				else
				{
					Console.WriteLine("Tie!");
				}

				Console.WriteLine("Game over!");
				gameOver = true;

				Console.ReadLine();
			}
		}
	}
}
