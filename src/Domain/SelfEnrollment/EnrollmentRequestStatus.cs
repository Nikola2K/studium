namespace Domain.SelfEnrollment;

/// <summary>
/// Stanje studentskog zahteva za pristupanje (ST-028).
/// </summary>
public enum EnrollmentRequestStatus
{
    Submitted,
    Approved,
    Rejected,
    Withdrawn
}
