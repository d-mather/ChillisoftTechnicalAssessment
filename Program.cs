using Models;
using Utils.FileParser;
using System.Collections.Generic;
 

namespace Menupermissions;

class Program
{
    static async Task Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: ./publish/menupermissions <PathToUserInputFile> <PathToMenuInputFile>");
            return;
        }

        var users = new List<User>();
        var menuItems = new List<MenuItem>();

        try
        {
            string userInputFilePath = args[0];
            string menuInputFilePath = args[1];

            var userTask = FileParser.UserFile(userInputFilePath);
            var menuTask = FileParser.MenuFile(menuInputFilePath);
            
            await Task.WhenAll(userTask, menuTask);
            users = userTask.Result;
            menuItems = menuTask.Result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"A file parsing error occurred: {ex.Message}");
        }

        try
        {
            var permissionService = new PermissionService.PermissionService(users, menuItems);
            var result = permissionService.MapUsersToPermissions();
            
            Console.Write(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred during permission mapping: {ex.Message}");
        }
    }
}