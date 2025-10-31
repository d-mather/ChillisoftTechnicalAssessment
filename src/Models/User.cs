namespace Models;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required List<int> PermittedMenuIds { get; set; }
}
