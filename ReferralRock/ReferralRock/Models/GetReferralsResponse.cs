namespace ReferralRock.Models;

public class GetReferralsResponse
{
    public int Offset { get; set; } = 0;
    public int Total { get; set; } = 0;
    public string Message { get; set; } = "";
    public Referral[] Referrals { get; set; } = Array.Empty<Referral>();
}
