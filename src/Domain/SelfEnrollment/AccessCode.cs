namespace Domain.SelfEnrollment;

/// <summary>
/// Pristupni kod sa rokom važenja (ST-028).
/// </summary>
public sealed record AccessCode(string Value, DateTime ValidUntil)
{
    public bool IsValidAt(DateTime now)
    {
        throw new NotImplementedException();
    }
}
