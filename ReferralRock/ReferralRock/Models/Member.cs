namespace ReferralRock.Models;

public record class Member
{
    public Guid Id { get; set; } = Guid.Empty;
    public string DisplayName { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public string DateOfBirth { get; set; } = "";
    public string AddressLine1 { get; set; } = "";
    public string AddressLine2 { get; set; } = "";
    public string City { get; set; } = "";
    public string Country { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string ReferralURL { get; set; } = "";
    public string ReferralCode { get; set; } = "";
    public string MemberURL { get; set; } = "";
    public int EmailShares { get; set; } = 0;
    public int SocialShares { get; set; } = 0;
    public int Views { get; set; } = 0;
    public int Referrals { get; set; } = 0;
    public DateTime? LastShare { get; set; } = null;
    public DateTime CreateDt { get; set; } = DateTime.UtcNow;
}
