using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.IO;


class Program
{
    static List<string> historieScore = new List<string>(); // game list
    static List<string> calcScore = new List<string>(); // calc list
    static int savehistory = 1; //ukladat historii
    static int trueOrFlase = 0;
    static int exiting123 = 0;
    static int snakespeed = 200; //snake "Ishow" speed
    static int secretModeUnlocked = 0;
    static int rangeOfLastNumber = 100;
    static int showNumber = 0;
    static int RollTheDice = 0;
    static int firstnumberunlocked = 0;
    static int minigamesunlocked = 0;
    static int confirmExits = 1;
    static void Main()
    {
        string ver = "1.2.7"; // everything was made by RozbitiOkno 24.11.2025 

        // HEADER
        int repete = 0;
        double percentage = 0;
        while (repete != 10)
        {
            Console.Clear();

            Console.WriteLine(@"
  OOOOO    K   K   N   N   OOOOO
 O     O   K  K    NN  N  O     O
 O     O   K K     N N N  O     O
 O     O   KK      N  NN  O     O
 O     O   K K     N   N  O     O
 O     O   K  K    N   N  O     O
  OOOOO    K   K   N   N   OOOOO
                            ");

            percentage += 8.5;
            Console.WriteLine("[----- " + percentage + "% -----]");
            if (percentage > 50)
            {
                Console.WriteLine("Process ENTER to skip");
            }
            Thread.Sleep(400);

            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                break;
            }
            repete++;

        }

        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=== " + DateTime.Now + " ===");
            Console.WriteLine("RozitiOkno operators v." + ver);
            Console.WriteLine("=============================");
            Console.ResetColor();

            // MAIN MENU

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1  →  Calculations");
            Console.WriteLine("2  →  Random numbers");
            Console.WriteLine("3  →  Unit converter");
            Console.WriteLine("4  →  Play minigames");
            Console.WriteLine("5  →  See history");
            Console.WriteLine("6  →  Timer");
            Console.WriteLine("7  →  StopWatch");
            Console.WriteLine("8  →  ^,√ ");
            Console.WriteLine("9  →  Roll the dice");
            Console.WriteLine("10 →  achivments");
            Console.WriteLine("11 →  Settings");
            Console.WriteLine("0  →  exit");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Your choice: ");
            Console.ResetColor();
            double whattodo = double.Parse(Console.ReadLine());

            if (whattodo != 0 && whattodo != 1 && whattodo != 2 && whattodo != 3 && whattodo != 4 && whattodo != 5 && whattodo != 111 && whattodo != 67 && whattodo != 420 && whattodo != 1337 && whattodo != 6 && whattodo != 7 && whattodo != 8 && whattodo != 9 && whattodo != 10 && whattodo != 11)
            {
                Console.WriteLine("ERROR: Not a number or invalid number!");
            }

            if (whattodo == 0) //----------EXIT-------------//
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exiting contains removing all your stuff like history, settings and else do you want to continue? (y/n)");
                Console.ResetColor();
                Console.Write("Continue? (y/n) ");
                string doyouwanttocontinue = Console.ReadLine();
                if (doyouwanttocontinue == "y" || doyouwanttocontinue == "Y")
                {
                    Console.WriteLine("Exiting . . .");
                    Console.ResetColor();
                    Console.Clear();


                    Console.WriteLine(@"
  OOOOO    K   K   N   N   OOOOO
 O     O   K  K    NN  N  O     O
 O     O   K K     N N N  O     O
 O     O   KK      N  NN  O     O
 O     O   K K     N   N  O     O
 O     O   K  K    N   N  O     O
  OOOOO    K   K   N   N   OOOOO
                            ");
                    return;
                }
                if (doyouwanttocontinue == "n" || doyouwanttocontinue == "N")
                {
                    continue;
                }
                if (doyouwanttocontinue != "n" || doyouwanttocontinue != "N" || doyouwanttocontinue != "Y" || doyouwanttocontinue != "y")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option! (relocating in 3 sec.)");
                    Console.ResetColor();
                    Thread.Sleep(3000);
                    continue;
                }
            }
            //okamzity exit 
            else if (whattodo == 111) //mozna upravit na lepší číslo idk
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Immediate termination and non-saving of things . . .");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.WriteLine("Exiting . . .");
                Console.ResetColor();
                return;

            }


            // ------------------------- CALCULATOR ------------------------- //
            if (whattodo == 1)
            {
                Console.Clear();
                firstnumberunlocked = 1;
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

                    if (savehistory == 1)
                    {
                        string calczaznam = $"Calculator (multiple operations): {result} - Date: {DateTime.Now}";
                        calcScore.Add(calczaznam);
                    }
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
                    Console.WriteLine("Enter operation (+,-,*,/,):");
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

                    if (savehistory == 1)
                    {
                        string calczaznam = $"Calculator (simple): {num1} {oper} {num2} = {result} - Date: {DateTime.Now}";
                        calcScore.Add(calczaznam);
                    }

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

                    string answer = "";

                    while (true)
                    {
                        answer = rng.Next(2) == 0 ? "YES" : "NO"; //yes or no
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Generated: " + answer);
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Generate again? (y/n)");
                        Console.ResetColor();

                        if (Console.ReadLine().ToLower() != "y") break;
                    }

                    if (savehistory == 1)
                    {
                        string calczaznam = $"RNG (YES and NO): genereted: {answer}   - Date: {DateTime.Now}"; //add do history YES / NO
                        calcScore.Add(calczaznam);
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
                    int from = int.Parse(Console.ReadLine()); //int from

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter TO number:");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Your choice: ");
                    Console.ResetColor();
                    int to = int.Parse(Console.ReadLine()); //int to

                    if (from > to)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("FROM must be smaller than TO!");
                        Console.ResetColor();
                        return;
                    }

                    int rndNum = 0;

                    while (true)
                    {
                        rndNum = rng.Next(from, to + 1);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Generated number: " + rndNum);
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Generate again? (y/n)");
                        Console.ResetColor();

                        if (Console.ReadLine().ToLower() != "y") break;
                    }
                    if (savehistory == 1)
                    {
                        string calczaznam = $"RNG (numbers): from: {from} to: {to} genereted: {rndNum}   - Date: {DateTime.Now}"; //add do history numbers
                        calcScore.Add(calczaznam);
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

                Console.WriteLine("1 → KM to M  | 2 → M to CM  | 3 → CM to MM");
                Console.WriteLine("4 → M to KM  | 5 → CM to M  | 6 → MM to CM");
                Console.WriteLine("7 → T to KG  | 8 → KG to G  | 9 → G to mG");
                Console.WriteLine("10 → KG to T | 11 → G to KG | 12 → mG to G");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice: ");
                Console.ResetColor();
                int unitChoice = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("How much units do you want to convert?");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice: ");
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
                minigamesunlocked = 1;
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
                int attemps = 0;
                if (whatminigame == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Guess the number between 1-" + rangeOfLastNumber + "!");
                    Random random = new Random();
                    int number = random.Next(1, rangeOfLastNumber + 1);

                    while (true)
                    {
                        if (showNumber == 1)
                        {
                            Console.WriteLine("Generated number: " + number);
                            Console.Write("Your choice: ");
                        }
                        else
                        {
                            Console.Write("Your choice: ");
                        }

                        if (!int.TryParse(Console.ReadLine(), out int guess))
                        {
                            Console.WriteLine("Not a number!");
                            continue;
                        }

                        if (guess == number)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Correct!");
                            Console.WriteLine("You have " + attemps + " attemps!");

                            if (attemps < 1 || attemps == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("EXTREM SCORE!");
                            }
                            else if (attemps < 5)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Good score!");
                            }
                            else if (attemps < 7)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Normal score");
                            }
                            else if (attemps < 12)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Its good but not good !?");
                            }
                            else if (attemps > 12)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Very bad !");
                            }

                            Console.ResetColor();
                            break;
                        }

                        else if (guess > number)
                        {
                            Console.WriteLine("Lower!");
                            attemps++;
                        }


                        else
                        {
                            Console.WriteLine("Higher!");
                            attemps++;
                        }

                    }

                    if (savehistory == 1)
                    {
                        string zaznam = $"Guess the number: Attemps: {attemps} - Date: {DateTime.Now}";
                        historieScore.Add(zaznam);
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

                            if (savehistory == 1)
                            {
                                string zaznam = $"Snake the game: score: {score} - Date: {DateTime.Now}";
                                historieScore.Add(zaznam);
                            }

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
                        Thread.Sleep(snakespeed); //rychlost snake
                    }
                    Console.WriteLine("Press ENTER to exit Snake...");
                    Console.ReadLine();
                }
            }
            //----------------------historie-------------------------//
            if (whattodo == 5)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1 → Gaming history");
                Console.WriteLine("2 → Calc history");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice: ");
                Console.ResetColor();
                double historyofnig = double.Parse(Console.ReadLine());

                if (historyofnig == 1) //gaming history
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("=== Gaming history ===");
                    Console.ResetColor();
                    Console.WriteLine("");

                    if (historieScore.Count == 0)
                    {
                        Console.WriteLine("Nothing there . . .");
                    }
                    foreach (string zaznam in historieScore)
                    {

                        Console.WriteLine(zaznam);
                        Console.WriteLine("");
                    }
                }

                if (historyofnig == 2) //calc history
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("=== Calculations history ===");
                    Console.ResetColor();
                    Console.WriteLine("");
                    if (calcScore.Count == 0)
                    {
                        Console.WriteLine("Nothing there . . .");
                    }
                    foreach (string calczaznam in calcScore)
                    {

                        Console.WriteLine(calczaznam);
                        Console.WriteLine("");
                    }
                }

                if (historyofnig != 1 && historyofnig != 2) //invalid options
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option! - " + historyofnig + " - try something else!");
                    Console.ResetColor();
                }

            }
            //----------------------SECREETS-------------------------//
            if (whattodo == 1337)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("What a hacker here!");
                Console.ResetColor();
            }
            if (whattodo == 420)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("By BrokenWindowGameDev");
                Console.ResetColor();
            }
            if (whattodo == 67)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NOT FUNNY, too late!");
                Console.ResetColor();
            }

            //----------------------TIMER a STOPWATCH-----------------//
            if (whattodo == 6)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=== Timer ===");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("How many seconds (s)");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice: ");
                Console.ResetColor();
                int seconds = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Red;

                for (int i = seconds; i > 0; i--)
                {
                    Console.WriteLine($"Remaning: {i} s");
                    Thread.Sleep(1000);
                    Console.Clear();
                }

                Console.WriteLine("Time's up!");
                Console.ResetColor();
            }

            if (whattodo == 7) //stopwatch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=== stopwatch ===");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Press enter whenever do you want to start stopwatch");
                Console.ReadLine();
                Stopwatch stopky1 = new Stopwatch();
                stopky1.Start();
                while (true)
                {

                    Console.Clear();


                    Console.WriteLine("Press Enter to stop stopwatch");
                    Console.WriteLine(stopky1.Elapsed.ToString(@"hh\:mm\:ss\.fff"));


                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                        break;

                    Thread.Sleep(100);
                }

                stopky1.Stop();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Final time: " + stopky1.Elapsed);
                Console.WriteLine("");
                Console.ResetColor();

            }

            //----------------odmocnina a mocnina -----------------------//
            if (whattodo == 8)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=== ^ and √ ===");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1 → ^");
                Console.WriteLine("2 → √");
                Console.WriteLine("What do you want to use ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice (1/2): ");
                Console.ResetColor();
                int operationOrNot = int.Parse(Console.ReadLine());

                //if (operationOrNot != 1 || operationOrNot != 2)
                //{
                //    Console.WriteLine("NOT VALID NUMBER!");
                //}
                double NumberToBeFirst = 0;
                double NumberToBeSecond = 0;
                double vysledek = 0;


                if (operationOrNot == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter your first number to ^");
                    Console.ResetColor();
                    Console.Write("Your choice (1,2,3): ");
                    NumberToBeFirst = double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter your second number");
                    Console.ResetColor();
                    Console.Write("Your choice (1,2,3): ");
                    NumberToBeSecond = double.Parse(Console.ReadLine());
                    vysledek = Math.Pow(NumberToBeFirst, NumberToBeSecond);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{NumberToBeFirst} ^ {NumberToBeSecond} = {vysledek}"); //vysledek mocniny
                    Console.ResetColor();


                }

                string calczaznam = $"^: from: {NumberToBeFirst} by: {NumberToBeSecond} is: {vysledek} - Date: {DateTime.Now}"; //add do history 
                calcScore.Add(calczaznam);

                double NotANumber = 0;
                double odemocnina = 0;

                if (operationOrNot == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter your number to √");
                    Console.ResetColor();
                    Console.Write("Your choice (1,2,3): ");
                    NotANumber = double.Parse(Console.ReadLine());
                    odemocnina = Math.Sqrt(NotANumber);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Squr of " + NotANumber + " is " + odemocnina);
                    Console.ResetColor();

                }

                calczaznam = $"√: from: {NotANumber} is: {odemocnina} - Date: {DateTime.Now}"; //add do history 
                calcScore.Add(calczaznam);

            }

            //--------------SETTINGS-------------------//        

            if (whattodo == 11) //FIXed
            {
                exiting123 = 0;

                while (exiting123 == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("=== Settings ===");
                    Console.ForegroundColor = ConsoleColor.Green;

                    if (savehistory == 1) //ukladat historifing
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n1 → save history -");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" TRUE");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n1 → save history -");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" FALSE");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }


                    Console.WriteLine("2 → Clear history");
                    Console.WriteLine("3 → Change snake speed");
                    Console.WriteLine("4 → Guess the number - range");
                    Console.WriteLine("5 → Export history to .txt file");
                    Console.WriteLine("6 → Upload history from .txt file");
                    if (confirmExits == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("7 → Confirm exits -");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" TRUE ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("- (program exit not improved!)");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("7 → Confirm exits -");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" FALSE ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("- (program exit not improved!)");
                    }
                    Console.WriteLine("0 → Exit"); //exit sem snad slepej nebo CO ???

                    if (secretModeUnlocked == 1)
                    {
                        Console.WriteLine("999 → Reset all / debug mode");
                        Console.WriteLine("998 → Show right number in Guess the number");
                    }

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Your choice: ");
                    Console.ResetColor();

                    trueOrFlase = int.Parse(Console.ReadLine()); //urcovaní zmeny

                    if (trueOrFlase == 0) //exit
                    {
                        if (confirmExits == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Are you sure, you want exit settings? (y/n)");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Your choice: ");
                            Console.ResetColor();
                            string AreYouSure = Console.ReadLine();



                            if (AreYouSure == "y")
                            {
                                Console.WriteLine("Saving changes and exiting . . .");
                                exiting123 = 1;
                                Thread.Sleep(1000);
                            }

                            else if (AreYouSure == "n")
                            {
                                Console.Clear();
                                Console.WriteLine("OK, cancled!");
                            }

                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid operation, cancled!");
                                Thread.Sleep(1000);
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Saving changes and exiting . . .");
                            exiting123 = 1;
                            Thread.Sleep(1000);
                        }


                    }

                    if (trueOrFlase == 1) //zmena ukládání historie
                    {
                        if (savehistory == 1)
                        {
                            savehistory = 0;
                        }
                        else
                        {
                            savehistory = 1;
                        }
                    }

                    if (trueOrFlase == 2)
                    {
                        historieScore.Clear();
                        calcScore.Clear();
                        Console.Clear();
                        Console.WriteLine("History cleared");
                        Thread.Sleep(1000);
                    }

                    if (trueOrFlase == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("What speed do the Snake the game need? (only full numbers!)");
                        Console.WriteLine("Original speed is 200ms");
                        Console.ResetColor();
                        Console.WriteLine("fast ← 200 → slow");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Your choice: ");
                        Console.ResetColor();
                        snakespeed = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nSnake speed is now " + snakespeed);
                        Console.ResetColor();
                        Thread.Sleep(1000);
                    }

                    if (trueOrFlase == 555) //secret mode
                    {
                        secretModeUnlocked = 1;
                        Console.Clear();
                        Console.WriteLine("Secret mode unlocked!");
                        Thread.Sleep(1000);
                    }

                    if (trueOrFlase == 999 && secretModeUnlocked == 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your all stuff like history and settings will be removed! (y/n)");
                        Console.ResetColor();
                        string nevim = Console.ReadLine();
                        if (nevim == "y")
                        {
                            Console.WriteLine("Reseting all saved things . . ."); //reset vecí
                            historieScore.Clear();
                            calcScore.Clear();
                            snakespeed = 200;
                            rangeOfLastNumber = 100;
                            showNumber = 0;
                            Console.ResetColor();
                            Console.WriteLine("Everything was reseted");
                            Thread.Sleep(1000);
                        }

                        else if (nevim == "n")
                        {
                            Console.WriteLine("OK, cancled!");
                            Thread.Sleep(1000);
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid operation! - " + nevim);
                            Console.ResetColor();
                        }

                    }

                    if (trueOrFlase == 4)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("What range is good for you?");
                        Console.ResetColor();
                        Console.WriteLine("1 → 1-100 - easy");
                        Console.WriteLine("2 → 1-500 - harder");
                        Console.WriteLine("3 → 1-1000 - hard");
                        Console.WriteLine("4 → 1-10000 - extrem");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Your choice: ");
                        Console.ResetColor();
                        string rangethenumber = Console.ReadLine();

                        switch (rangethenumber)
                        {
                            case "1":
                                {
                                    rangeOfLastNumber = 100;
                                    break;
                                }
                            case "2":
                                {
                                    rangeOfLastNumber = 500;
                                    break;
                                }
                            case "3":
                                {
                                    rangeOfLastNumber = 1000;
                                    break;
                                }
                            case "4":
                                {
                                    rangeOfLastNumber = 10000;
                                    break;
                                }

                        }
                        Console.WriteLine("Range is now to " + rangeOfLastNumber);
                        Thread.Sleep(1000);
                    }

                    if (trueOrFlase == 998 && secretModeUnlocked == 1)
                    {
                        showNumber = 1;
                        Console.Clear();
                        Console.WriteLine("Number will be shown");
                        Thread.Sleep(1000);
                    }

                    if (trueOrFlase == 5)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("=== Export history ===");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("What name should be named your .txt history? (leave blanc for standard name)");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Your choice: ");
                        Console.ResetColor();
                        string NameForHistory = Console.ReadLine();
                        if (NameForHistory == "")
                        {
                            NameForHistory = "History_from_R.O._app";
                        }

                        string fileName = NameForHistory + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".txt";

                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            writer.WriteLine("=== GAMING HISTORY ===");
                            writer.WriteLine("");

                            if (historieScore.Count == 0)
                            {
                                writer.WriteLine("No gaming history.");
                            }

                            else
                            {
                                foreach (string zaznam in historieScore)
                                    writer.WriteLine(zaznam);
                            }

                            writer.WriteLine("");
                            writer.WriteLine("=== CALC HISTORY ===");
                            writer.WriteLine("");

                            if (calcScore.Count == 0)
                                writer.WriteLine("No calc history.");
                            else
                                foreach (string calczaznam in calcScore)
                                    writer.WriteLine(calczaznam);
                        }




                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("History exported!");
                        Console.WriteLine("File name: " + fileName);
                        Console.WriteLine("Exported to same folder as this app (~/home/~/calc/" + fileName + "/)");
                        Console.WriteLine("Gaming records: " + historieScore.Count);
                        Console.WriteLine("Calc records: " + calcScore.Count);
                        Console.ResetColor();
                        Console.WriteLine("Press enter to continue . . .");
                        Console.ReadLine();


                    }

                    if (trueOrFlase == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Comming soon!");
                        Thread.Sleep(1000);
                    }

                    if (trueOrFlase == 7)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Are you sure, you want to turn off exit confirmation? (y/n)");
                        Console.ResetColor();
                        Console.Write("Your option: ");
                        string areyourealysure = Console.ReadLine();
                        if (areyourealysure == "y")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Are you realy sure? (y/n)");
                            Console.ResetColor();
                            Console.Write("Your option: ");
                            string areyourealysureFUCK = Console.ReadLine();
                            if (areyourealysureFUCK == "y")
                            {
                                confirmExits = 0;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Allright you got it ");
                                Thread.Sleep(1500);
                            }
                            if (areyourealysureFUCK == "n")
                            {
                                confirmExits = 1;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Now you will need to confirm exit everywhere!");
                                Thread.Sleep(1500);
                            }
                            else
                            {
                                Console.WriteLine("Invalid option!");
                                Console.WriteLine("Leaving last option");
                            }
                        }
                        if (areyourealysure == "n")
                        {
                            Console.WriteLine("I though so . . .");
                            confirmExits = 1;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Now you will need to confirm exit everywhere!");
                            Thread.Sleep(1500);
                        }
                        else
                        {
                            Console.WriteLine("Invalid option!");
                        }

                    }

                }







            }

            if (whattodo == 9)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=== Roll the dice ===");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSelect what number range will you use? (1-6)");
                Console.ResetColor();

                Console.WriteLine("1 → 1-2");
                Console.WriteLine("2 → 1-3");
                Console.WriteLine("3 → 1-4");
                Console.WriteLine("4 → 1-5");
                Console.WriteLine("5 → 1-6");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice: ");
                Console.ResetColor();

                int choice = int.Parse(Console.ReadLine());

                Random rnd = new Random();
                int result = 0;

                switch (choice)
                {
                    case 1:
                        result = rnd.Next(1, 3); // 1–2
                        break;
                    case 2:
                        result = rnd.Next(1, 4); // 1–3
                        break;
                    case 3:
                        result = rnd.Next(1, 5); // 1–4
                        break;
                    case 4:
                        result = rnd.Next(1, 6); // 1–5
                        break;
                    case 5:
                        result = rnd.Next(1, 7); // 1–6
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        return;
                }

                Console.WriteLine($"You rolled: {result}");
            }


            //---------------achivments------------------//
            if (whattodo == 10)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=== Adchivments ===");
                Console.ForegroundColor = ConsoleColor.Green;

                if (firstnumberunlocked == 1)
                {
                    Console.WriteLine("\nFirst number - UNLOCKED");
                    Console.ResetColor();
                    Console.WriteLine("Calculate first number using calculator!");
                }
                else
                {
                    Console.WriteLine("\nFirst number - not found :-(");
                    Console.ResetColor();
                    Console.WriteLine("Calculate first number using calculator!");
                }
                Console.WriteLine("\n");

                if (minigamesunlocked == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Play time! - UNLOCKED");
                    Console.ResetColor();
                    Console.WriteLine("\nPlay minigame for first time");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Play time! - not found :-(");
                    Console.ResetColor();
                    Console.WriteLine("Play minigame for first time");
                }
                Console.WriteLine("\n");




                Console.WriteLine("--------------------------------------------");
            }


            Console.WriteLine("See more on https://github.com/RozbitiWindow");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Press ENTER to exit...");
            Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("Thanks for using RozbitiOkno operators!");
            Console.ResetColor();
            continue;
        }

    }

}


