namespace Domain.SelfEnrollment;

/// <summary>
/// Samostalno pristupanje konkretnom izvođenju predmeta (ST-028).
/// Samo izvođenje (CourseOffering) pripada ST-004; ovde se na njega upućuje identifikatorom.
/// </summary>
public sealed class CourseOfferingSelfEnrollment
{
    public CourseOfferingId CourseOfferingId { get; }
    public EnrollmentSettings Settings { get; }

    public CourseOfferingSelfEnrollment(CourseOfferingId courseOfferingId, EnrollmentSettings settings)
    {
        CourseOfferingId = courseOfferingId;
        Settings = settings;
    }

    public bool IsEnrollmentOpen()
    {
        throw new NotImplementedException();
    }

    public bool IsCodeValid(string code, DateTime now)
    {
        throw new NotImplementedException();
    }
}
