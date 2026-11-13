namespace Domain.SelfEnrollment;

/// <summary>
/// Identifikator studentskog zahteva za pristupanje (ST-028).
/// </summary>
public readonly record struct EnrollmentRequestId(Guid Value);
