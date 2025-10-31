using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic;
using Models;

namespace Utils.FileParser;

public static class FileParser
{
    public static List<MenuItem> MenuFile(string filePath)
    {
        var menuItems = new List<MenuItem>();
        try
        {
            var lines = File.ReadAllLines(filePath);
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
}
