namespace Domain.SelfEnrollment;

/// <summary>
/// Domenske greške samostalnog pristupanja predmetu (ST-028).
/// </summary>
public abstract class SelfEnrollmentException : Exception
{
    protected SelfEnrollmentException(string message)
        : base(message)
    {
    }
}

public sealed class CodeExpiredException : SelfEnrollmentException
{
    public CodeExpiredException()
        : base("Pristupni kod je istekao.")
    {
    }
}

public sealed class EnrollmentClosedException : SelfEnrollmentException
{
    public EnrollmentClosedException()
        : base("Samostalni upis je zatvoren.")
    {
    }
}

public sealed class AccountInactiveException : SelfEnrollmentException
{
    public AccountInactiveException()
        : base("Nalog nije aktivan.")
    {
    }
}

public sealed class RequestAlreadyDecidedException : SelfEnrollmentException
{
    public RequestAlreadyDecidedException()
        : base("O zahtevu je već odlučeno.")
    {
    }
}
