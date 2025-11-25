using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
//await Task.Delay(10000); cekat 10 sec
string ver = "1.0.1"; //everything was made by RozbitiOkno 24.11. 2025
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("=== " + (DateTime.Now) + " ===");
Console.WriteLine("RozitiOkno operators v." + ver);
Console.WriteLine("=============================");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Do you want to generate random numbers or perform calculations?");
Console.WriteLine("To perform calculations press 1, to generate random numbers press 2");
double whattodo = double.Parse(Console.ReadLine());
switch (whattodo)
{
    
    case 1: //switch
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("=== " + (DateTime.Now) + " ===");
Console.WriteLine("RozitiOkno calculator v." + ver);
Console.WriteLine("=============================");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Enter your first number");
Console.ResetColor();
double num1 = double.Parse(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Enter your operation");
Console.ResetColor();
string oper = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Enter your second number");
Console.ResetColor();
double num2 = double.Parse(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Red;
switch (oper)
{
    default: 
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROR");
    Console.ResetColor();
    Console.WriteLine("Invalid operation- " + oper + " -Use operations like +,-,*,/");
    Console.ResetColor();
    break;
    case "+":
    Console.WriteLine("Operation complete! The result is: " + (num1 + num2));
    break;
    case "-":
    Console.WriteLine("Operation complete! The result is: " + (num1 - num2));
    break;
    case "*":
    Console.WriteLine("Operation complete! The result is: " + (num1 * num2));
    break;
    case "/":
    Console.WriteLine("Operation complete! The result is: " + (num1 / num2));
    break;
}
Console.ResetColor();
Console.WriteLine("Thanks for using RozbitiOkno calculator " + (ver));
        break;   //switch
        case 2:
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("========== " + (DateTime.Now) + " ==========");
Console.WriteLine("RozitiOkno random number generator v." + ver);
Console.WriteLine("===========================================");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Enter FROM number it might generate?");
Console.ResetColor();
int num11 = int.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Enter TO number it might generate?");
Console.ResetColor();
int num22 = int.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Ready to generate? y/n");
Console.ResetColor();
string ready = Console.ReadLine();

Random rnd = new Random();

switch (ready)
{
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR");
        Console.WriteLine("Unknown operation - " + ready + " - try something else!");
        break;

    case "y":
        int final = rnd.Next(num11, num22 + 1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Operation complete! " + final);
        break;

    case "n":
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("OK, canceling operation . . .");
        Console.WriteLine("Operation canceled!");
        break;
}

Console.ResetColor();
Console.WriteLine("Thanks for using RozbitiOkno random number generator v. " + (ver));
        break; //switch
        case 3:
        Console.WriteLine("NOT IMPLEMENTED YET!");
        break;
        case 67:
        Console.WriteLine("SIXXXX SEVENNNN!");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR");
        Console.ResetColor();
        Console.WriteLine("Stupid peoples are NOT allowed to use this program!");
        Console.WriteLine("ERROR code: " + ver + " + 6.7-code " + " ERROR codes description at github.com/rozbitiwindow/errors");
        break;
        default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR");
        Console.ResetColor();
        Console.WriteLine("Not an option! Try 1,2,3");
        break;




}

Console.ResetColor();

