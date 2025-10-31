using System.Linq;
using System.Text.Json;
using Models;

namespace PermissionService;

public class PermissionService(List<User> users, List<MenuItem> menuItems) : IPermissionService
{
    private readonly List<User> _users = users;
    private readonly List<MenuItem> _menuItems = menuItems;

    public string MapUsersToPermissions()
    {
        var result = new
        {
            users = _users.Select(user => new
            {
                userName = user.Name,
                menuItems = GetPermittedMenuNames(user.PermittedMenuIds)
            }).ToList()
        };
        return JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true });
    }

    private List<string> GetPermittedMenuNames(List<int> permittedMenuIds)
    {
        return permittedMenuIds
            .Select(id => _menuItems.FirstOrDefault(menu => menu.Id == id)?.Name)
            .Where(name => !string.IsNullOrEmpty(name))
            .Select(name => name!)
            .ToList();
    }
}
