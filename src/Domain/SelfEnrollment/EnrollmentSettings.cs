namespace Domain.SelfEnrollment;

/// <summary>
/// Podešavanja samostalnog pristupanja jednom izvođenju predmeta (ST-028).
/// </summary>
public sealed class EnrollmentSettings
{
    public EnrollmentMode Mode { get; private set; }
    public bool IsSelfEnrollmentEnabled { get; private set; }
    public AccessCode? CurrentCode { get; private set; }
}
