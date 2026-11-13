namespace Domain.SelfEnrollment;

/// <summary>
/// PRIVREMENI MOCK: minimalni nalog potreban za ST-028 (identitet, uloga, aktivnost).
/// Nalozi pripadaju ST-001; zameniti sa kada bude integrisan u main.
/// </summary>
public sealed class UserAccount
{
    public UserId Id { get; }
    public string Username { get; }
    public AccountRole Role { get; }
    public bool IsActive { get; private set; }

    public UserAccount(UserId id, string username, AccountRole role, bool isActive = true)
    {
        Id = id;
        Username = username;
        Role = role;
        IsActive = isActive;
    }
}
