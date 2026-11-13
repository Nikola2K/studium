namespace Domain.SelfEnrollment;

/// <summary>
/// Studentski zahtev za pristupanje izvođenju predmeta (ST-028).
/// </summary>
public sealed class EnrollmentRequest
{
    public EnrollmentRequestId Id { get; }
    public UserId StudentId { get; }
    public CourseOfferingId CourseOfferingId { get; }
    public DateTime SubmittedAt { get; }
    public EnrollmentRequestStatus Status { get; private set; }

    public EnrollmentRequest(
        EnrollmentRequestId id,
        UserId studentId,
        CourseOfferingId courseOfferingId,
        DateTime submittedAt)
    {
        Id = id;
        StudentId = studentId;
        CourseOfferingId = courseOfferingId;
        SubmittedAt = submittedAt;
        Status = EnrollmentRequestStatus.Submitted;
    }

    public void Approve()
    {
        throw new NotImplementedException();
    }

    public void Reject()
    {
        throw new NotImplementedException();
    }

    public void Withdraw()
    {
        throw new NotImplementedException();
    }
}
