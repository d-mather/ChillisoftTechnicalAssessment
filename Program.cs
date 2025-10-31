using Models;
using Utils.FileParser;
using System.Collections.Generic;
using System.Text.Json;

namespace Menupermissions;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: ./publish/menupermissions <PathToUserInputFile> <PathToMenuInputFile>");
            return;
        }

        var menuItems = new List<MenuItem>();

        try
        {
            string menuInputFilePath = args[1];

            menuItems = FileParser.MenuFile(menuInputFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"A file parsing error occurred: {ex.Message}");
        }
    }
}