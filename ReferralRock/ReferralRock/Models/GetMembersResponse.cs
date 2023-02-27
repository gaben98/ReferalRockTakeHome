namespace ReferralRock.Models;

public record class GetMembersResponse
{
    public int Offset { get; set; } = 0;
    public int Total { get; set; } = 0;
    public string Message { get; set; } = "";
    public Member[] Members { get; set; } = Array.Empty<Member>();
}
