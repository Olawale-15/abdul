using System;

namespace Number9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name;

                Console.WriteLine("**************Let's play Master-Mined**************");
                Console.WriteLine();
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
                Console.WriteLine("Welcome {0}. Have fun!! ", name);

                int numberCount = 0;
                int difficultyLevel = 0;

                int digitNumber = GetRandomNumberCount(numberCount);
                Console.Write(digitNumber + " it is. Let's play.");
                Console.WriteLine();
                int[] PCArray = GenerateRandomNumbers(digitNumber);

                Console.WriteLine("A " + digitNumber + "-digit number has been chosen. Each possible digit may be the number 1, 2, 3 or 4.");
                Console.WriteLine("    ******");

                int difficulty = GetGameDifficulty(difficultyLevel);
                int attempts = difficulty * digitNumber;

                Console.WriteLine("Enter your guess ({0} guesses remaining)", attempts);
                int remaining = attempts;

                for (int i = 0; i < attempts; i++)
                {
                    int[] userArray = GetUserGuess(digitNumber);
                    int hits = CountHits(PCArray, userArray, attempts);

                    if ((hits != PCArray.Length) && (attempts > 0))
                    {
                        remaining--;
                        Console.WriteLine("Enter your guess ({0} guesses remaining)", remaining);
                    }
                    else if ((attempts < 1))
                    {                    
                        Console.WriteLine("Oh no {0}! You couldn't guess the right number.", name);
                        Console.WriteLine("The correct number is: ");
                        for (int j = 0; j < PCArray.Length; j++)
                        {
                            Console.Write(PCArray[j] + " ");
                        }
                        Console.WriteLine("Would you like to play again (Y/N)? ");
                    }
                    else if (hits == PCArray.Length)
                    {
                        attempts = 0;
                        Console.WriteLine("You win {0}!", name);
                        Console.WriteLine("The correct number is:");
                        for (int j = 0; j < PCArray.Length; j++)
                        {
                            Console.Write(PCArray[j] + " ");
                        }
                    }
                }
                Console.ReadLine();
            }        
            public static int GetRandomNumberCount(int numberCount)
            {
                int number = 0;
                do
                {
                    try
                    {
                        Console.Write("How many numbers would you like to use in playing the game (4-10)? ");
                        number = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }
                    catch
                    {
                        Console.WriteLine("You must pick a number between 4 and 10. Choose again.");
                        Console.WriteLine();
                    }
                } while ((number < 4) || (number > 10));

                return number;
            }
            public static int GetGameDifficulty(int difficultyLevel)
            {
                int difficulty = 0;

                do
                {
                    try
                    {
                        Console.Write("Choose a difficulty level (1=hard, 2=medium, 3=easy): ");
                        difficulty = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("         Incorrect entry: Please re-enter.");
                    }
                } while ((difficulty < 1) || (difficulty > 3));

                return difficulty;
            }
            public static int[] GenerateRandomNumbers(int PCSize)
            {
                int eachNumber;
                int[] randomNumber = new int[PCSize];
                Random rnd = new Random();

                for (int i = 0; i < randomNumber.Length; i++)
                {
                    eachNumber = rnd.Next(1, 5);
                    randomNumber[i] = eachNumber;
                    Console.Write(eachNumber);
                }
                Console.WriteLine();
                return randomNumber;
            }
            public static int[] GetUserGuess(int userSize)
            {
                int number = 0;
                int[] userGuess = new int[userSize];
                for (int i = 0; i < userGuess.Length; i++)
                {
                    Console.Write("Digit {0}: ", (i + 1));
                    number = int.Parse(Console.ReadLine());
                    userGuess[i] = number;
                   
                }
                Console.WriteLine();
                Console.Write("Your guess: ");
                for (int i = 0; i < userGuess.Length; i++)
                {
                    Console.Write(userGuess[i] + " ");
                }
                Console.WriteLine();
                return userGuess;
            }
            public static int CountHits(int[] PCArray, int[] userArray, int attempts)
            {
                int hit = 0;
                int miss = 0;
                int hits = 0;

                for (int i = 0; i < PCArray.Length; i++)
                {
                    if (PCArray[i] == userArray[i])
                    {
                        hit = hit + 1;
                        hits = hit;
                    }
                    else
                    {
                        miss = miss + 1;
                    }
                }
                Console.WriteLine("Results: {0} Hit(s), {1} Miss(es)", hit, miss);
                return hits;
        }
    }
}
