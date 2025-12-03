using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Clear();
        string ver = "1.0.4"; // everything was made by RozbitiOkno 24.11.2025 

        // HEADER
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("=== " + DateTime.Now + " ===");
        Console.WriteLine("RozitiOkno operators v." + ver);
        Console.WriteLine("=============================");
        Console.ResetColor();

        // MAIN MENU
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1 → Calculations");
        Console.WriteLine("2 → Random numbers");
        Console.WriteLine("3 → Unit converter");
        Console.WriteLine("4 → Play minigames");
        Console.WriteLine("0 → exit");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Your choice: ");
        Console.ResetColor();
        double whattodo = double.Parse(Console.ReadLine());

        if (whattodo != 0 && whattodo != 1 && whattodo != 2 && whattodo != 3 && whattodo != 4 )
        {
            Console.WriteLine("ERROR: Not a number or invalid number!");
        }

        if (whattodo == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exiting . . .");
            Console.ResetColor();
            return;
        }

        // ------------------------- CALCULATOR ------------------------- //
        if (whattodo == 1)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=== Calculator v." + ver + " ===");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Do you need multiple operations? (y/n)");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Your choice: ");
            Console.ResetColor();

            string multiple = Console.ReadLine().ToLower();

            if (multiple == "y" || multiple == "yes")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter your first number:");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice: ");
                Console.ResetColor();

                double result = double.Parse(Console.ReadLine());
                string continueCalc = "y";

                while (continueCalc == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter operation (+,-,*,/):");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Your choice: ");
                    Console.ResetColor();
                    string oper = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter next number:");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Your choice: ");
                    Console.ResetColor();
                    double next = double.Parse(Console.ReadLine());

                    switch (oper)
                    {
                        case "+": result += next; break;
                        case "-": result -= next; break;
                        case "*": result *= next; break;
                        case "/": result /= next; break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid operation!");
                            Console.ResetColor();
                            continue;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Current result: " + result);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Do you want to continue? (y/n)");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Your choice: ");
                    Console.ResetColor();
                    continueCalc = Console.ReadLine().ToLower();
                }

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Final result: " + result);
                Console.ResetColor();
                Console.WriteLine("Thanks for using multiple-operations calculator!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter first number:");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice: ");
                Console.ResetColor();
                double num1 = double.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter operation (+,-,*,/):");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice: ");
                Console.ResetColor();
                string oper = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter second number:");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice: ");
                Console.ResetColor();
                double num2 = double.Parse(Console.ReadLine());

                double result = oper switch
                {
                    "+" => num1 + num2,
                    "-" => num1 - num2,
                    "*" => num1 * num2,
                    "/" => num1 / num2,
                    _ => double.NaN
                };

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Result: " + result);
                Console.ResetColor();
                Console.WriteLine("Thanks for using RozbitiOkno calculator " + ver);
            }
        }

        // ------------------------- RANDOM NUMBERS ------------------------- //
        else if (whattodo == 2)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=== Random Number Generator ===");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Do you want YES/NO answers only? (y/n)");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Your choice: ");
            Console.ResetColor();
            string rngMode = Console.ReadLine().ToLower();

            Random rng = new Random();

            if (rngMode == "y" || rngMode == "yes")
            {
                while (true)
                {
                    string answer = rng.Next(2) == 0 ? "YES" : "NO";
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Generated: " + answer);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Generate again? (y/n)");
                    Console.ResetColor();

                    if (Console.ReadLine().ToLower() != "y") break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter FROM number:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice: ");
                Console.ResetColor();
                int from = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter TO number:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice: ");
                Console.ResetColor();
                int to = int.Parse(Console.ReadLine());

                if (from > to)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FROM must be smaller than TO!");
                    Console.ResetColor();
                    return;
                }

                while (true)
                {
                    int rndNum = rng.Next(from, to + 1);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Generated number: " + rndNum);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Generate again? (y/n)");
                    Console.ResetColor();

                    if (Console.ReadLine().ToLower() != "y") break;
                }
            }

            Console.WriteLine("Thanks for using RNG " + ver);
        }

        // ------------------------- UNIT CONVERTER ------------------------- //
        else if (whattodo == 3)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=== Unit Converter v." + ver + " ===");
            Console.ResetColor();

            Console.WriteLine("1 → KM to M | 2 → M to CM | 3 → CM to MM");
            Console.WriteLine("4 → M to KM | 5 → CM to M | 6 → MM to CM");
            Console.WriteLine("7 → T to KG | 8 → KG to G | 9 → G to mG");
            Console.WriteLine("10 → KG to T | 11 → G to KG | 12 → mG to G");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Your choice: ");
            Console.ResetColor();
            int unitChoice = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("How much units do you want to convert?");
            Console.ResetColor();
            double HOWMUCH = double.Parse(Console.ReadLine());

            double RESULT = unitChoice switch
            {
                1 => HOWMUCH * 1000,
                2 => HOWMUCH * 100,
                3 => HOWMUCH * 10,
                4 => HOWMUCH / 1000,
                5 => HOWMUCH / 100,
                6 => HOWMUCH / 10,
                7 => HOWMUCH * 1000,
                8 => HOWMUCH * 1000,
                9 => HOWMUCH * 1000,
                10 => HOWMUCH / 1000,
                11 => HOWMUCH / 1000,
                12 => HOWMUCH / 1000,
                _ => double.NaN
            };

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Result: " + RESULT);
            Console.ResetColor();
        }

        // ------------------------- MINIGAMES ------------------------- //
        else if (whattodo == 4)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==== Minigames v." + ver + " ====");
            Console.ResetColor();

            Console.WriteLine("1 → Guess the number");
            Console.WriteLine("2 → Snake the game");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Your choice: ");
            Console.ResetColor();
            int whatminigame = int.Parse(Console.ReadLine());

            // ---------- GUESS THE NUMBER ---------- //
            if (whatminigame == 1)
            {
                Console.Clear();
                Console.WriteLine("Guess the number between 1-100!");
                Random random = new Random();
                int number = random.Next(1, 101);

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out int guess))
                    {
                        Console.WriteLine("Not a number!");
                        continue;
                    }

                    if (guess == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ResetColor();
                        break;
                    }
                    else if (guess > number)
                        Console.WriteLine("Lower!");
                    else
                        Console.WriteLine("Higher!");
                }

                Console.WriteLine("Thanks for playing!");
            }

            // ---------- SNAKE ---------- //
            else if (whatminigame == 2)
            {
                int width = 30;
                int height = 15;
                int score = 0;
                Console.CursorVisible = false;

                List<(int x, int y)> snake = new List<(int x, int y)> { (width / 2, height / 2) };
                Random rng = new Random();
                (int x, int y) food = (rng.Next(width), rng.Next(height));
                ConsoleKey direction = ConsoleKey.RightArrow;

                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true).Key;
                        switch (key)
                        {
                            case ConsoleKey.UpArrow:
                                if (direction != ConsoleKey.DownArrow) direction = ConsoleKey.UpArrow; break;
                            case ConsoleKey.DownArrow:
                                if (direction != ConsoleKey.UpArrow) direction = ConsoleKey.DownArrow; break;
                            case ConsoleKey.LeftArrow:
                                if (direction != ConsoleKey.RightArrow) direction = ConsoleKey.LeftArrow; break;
                            case ConsoleKey.RightArrow:
                                if (direction != ConsoleKey.LeftArrow) direction = ConsoleKey.RightArrow; break;
                        }
                    }

                    var head = snake[0];
                    (int x, int y) newHead = head;
                    switch (direction)
                    {
                        case ConsoleKey.UpArrow: newHead.y--; break;
                        case ConsoleKey.DownArrow: newHead.y++; break;
                        case ConsoleKey.LeftArrow: newHead.x--; break;
                        case ConsoleKey.RightArrow: newHead.x++; break;
                    }

                    if (newHead.x < 0 || newHead.x >= width || newHead.y < 0 || newHead.y >= height || snake.Contains(newHead))
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("GAME OVER!");
                        Console.WriteLine("Score: " + score);
                        Console.ResetColor();
                        break;
                    }

                    snake.Insert(0, newHead);

                    if (newHead == food)
                    {
                        score++;
                        do { food = (rng.Next(width), rng.Next(height)); }
                        while (snake.Contains(food));
                    }
                    else snake.RemoveAt(snake.Count - 1);

                    Console.SetCursorPosition(0, 0);
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            if (snake.Contains((x, y))) { Console.ForegroundColor = ConsoleColor.Green; Console.Write("O"); }
                            else if (food == (x, y)) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("X"); }
                            else Console.Write(" ");
                            Console.ResetColor();
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Score: " + score);
                    Thread.Sleep(200);
                }
                Console.WriteLine("Press ENTER to exit Snake...");
                Console.ReadLine();
            }
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid option!");
            Console.ResetColor();
        }

        Console.WriteLine("See more on github.com/rozbitiwindow");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Press ENTER to exit...");
        Console.ReadLine();
        Console.ResetColor();
        Console.WriteLine("Thanks for using RozbitiOkno operators!");
        Console.ResetColor();
    }
}
//everything was made by RozbitiOkno - last edit 9:23 PM - 12/3/25
