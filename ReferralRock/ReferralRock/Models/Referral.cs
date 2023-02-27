namespace ReferralRock.Models;

public class Referral : UpdateReferral
{
    public Guid Id { get; set; } = Guid.Empty;
    public string DisplayName { get; set; } = "";
    public string FullName { get; set; } = "";
    public string AmountFormatted { get; set; } = "";
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdateDate { get; set; } = DateTime.UtcNow;
    public string Source { get; set; } = "";
    public Guid ProgramID { get; set; } = Guid.Empty;
    public Guid ReferringMemberID { get; set; } = Guid.Empty;
    public string ReferringMemberName { get; set; } = "";
    public string MemberEmail { get; set; } = "";
    public string MemberReferralCode { get; set; } = "";
}

public class UpdateReferral
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string PreferredContact { get; set; } = "";
    public string ExternalIdentifier { get; set; } = "";
    public double Amount { get; set; } = 0.0;
    public string CompanyName { get; set; } = "";
    public string Note { get; set; } = "";
    public string PublicNote { get; set; } = "";
    public string CustomOption1Name { get; set; } = "";
    public string CustomOption2Name { get; set; } = "";
    public string CustomText1Name { get; set; } = "";
    public string CustomText2Name { get; set; } = "";
    public string CustomText3Name { get; set; } = "";
    public string CustomOption1Value { get; set; } = "";
    public string CustomOption2Value { get; set; } = "";
    public string CustomText1Value { get; set; } = "";
    public string CustomText2Value { get; set; } = "";
    public string CustomText3Value { get; set; } = "";
    public string Status { get; set; } = "pending";
}

public class NewReferral : UpdateReferral
{
    public string ReferralCode { get; set; } = "";
}