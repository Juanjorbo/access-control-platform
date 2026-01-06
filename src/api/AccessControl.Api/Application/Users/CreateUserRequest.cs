namespace AccessControl.Api.Application.Users;

public class CreateUserRequest
{
    public string Email { get; set; } = null!;
    public string Name { get; set; } = null!;
}
