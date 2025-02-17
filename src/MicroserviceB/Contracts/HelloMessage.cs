namespace MicroserviceB.Contracts;

public record HelloMessage
{
    public string Text { get; set; } = string.Empty;
}