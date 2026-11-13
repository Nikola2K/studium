namespace Domain.SelfEnrollment;

/// <summary>
/// Identifikator korisnika (studenta ili nastavnika) u kontekstu ST-028.
/// </summary>
public readonly record struct UserId(Guid Value);
