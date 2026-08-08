using System;
using System.Data;
using System.Net;
OutputWriter outputWriter = new OutputWriter();
Settings settings = new Settings();
settings.Load();

Console.WriteLine("Broken calc by RozbitiOkno");

while (true)
{
    outputWriter.Write("Math problem: ", ConsoleColor.Green);
    string input = Console.ReadLine() ?? "";

    if (input == "exit")
    {
        outputWriter.WriteWarning("Exiting ...");
        break;
    }
    if (input == "S" || input == "s") { settings.Open(); }


    try
    {
        var result = new DataTable().Compute(input, null);
        outputWriter.WriteLine($"= {result}", ConsoleColor.Red);
    }
    catch
    {
        if (settings.input != 0)
        {
            outputWriter.WriteError("ERROR: Invalid syntax!");
        }


    }
    if (settings._closeProgram == true) { break; }
    else { continue; }
}
