namespace RazorMass;

public static class DB
{
    public static List<User> Users { get; } = [];
}

public class User(string firstName, string lastName, string email, string password)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string Email { get; set; } = email;
    public string Password { get; set; } = password;
}
