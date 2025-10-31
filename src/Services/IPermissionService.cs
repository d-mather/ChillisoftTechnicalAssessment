using Models;

namespace PermissionService;

public interface IPermissionService
{
    /// <summary>
    /// Maps users to their permitted menu items and returns a list of formatted strings.
    /// </summary>
    /// <param name="users"></param>
    /// <param name="menuItems"></param>
    /// <returns></returns>
    string MapUsersToPermissions();
}
