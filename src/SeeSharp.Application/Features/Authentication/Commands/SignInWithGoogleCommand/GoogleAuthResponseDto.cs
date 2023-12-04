namespace SeeSharp.Application.Features.Authentication.Commands.SignInWithGoogleCommand;

public class GoogleAuthResponseDto{
    public string? UserId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public IList<string> Roles { get; set; } = new List<string>();

    public string? Token { get; set; }
}