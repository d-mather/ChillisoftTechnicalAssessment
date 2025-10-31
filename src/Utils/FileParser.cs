using Models;
using System.Threading.Tasks;

namespace Utils.FileParser;

public static class FileParser
{
    public static async Task<List<User>> UserFile(string filePath)
    {
        var users = new List<User>();
        try
        {
            var lines = await File.ReadAllLinesAsync(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(' ');
                if (parts.Length < 2)
                    throw new Exception("Each line must contain at least two values separated by spaces.");

                var username = parts[0].Trim();
                var permissions = "";
                for (int i = 1; i < parts.Length; i++)
                    permissions += parts[i].Trim();

                if (!IsValidPermissions(permissions))
                    throw new Exception("Permissions strings must only contain 'Y' or 'N' characters.");

                var user = new User
                {
                    Id = Array.IndexOf(lines, line) + 1,
                    Name = username,
                    PermittedMenuIds = new List<int>()
                };

                for (int i = 0; i < permissions.Length; i++)
                {
                    if (permissions[i] == 'Y')
                        user.PermittedMenuIds.Add(i + 1);
                }

                users.Add(user);
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Unexpected file input or syntax. Error message: {ex.Message}");
        }
        return users;
    }

    public static async Task<List<MenuItem>> MenuFile(string filePath)
    {
        var menuItems = new List<MenuItem>();
        try
        {
            var lines = await File.ReadAllLinesAsync(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length != 2)
                    throw new Exception("Each line must contain exactly two values separated by a comma.");

                menuItems.Add(new MenuItem
                {
                    Id = int.Parse(parts[0].Trim()),
                    Name = parts[1].Trim()
                });
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Unexpected file input or syntax. Error message: {ex.Message}");
        }
        return menuItems;
    }

    public static bool IsValidPermissions(string input)
    {
        foreach (char c in input)
        {
            if (c != 'Y' && c != 'N')
                return false;
        }
        return true;
    }
}
