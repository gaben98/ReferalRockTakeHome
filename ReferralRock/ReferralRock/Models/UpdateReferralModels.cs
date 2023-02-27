namespace ReferralRock.Models;

public class UpdateReferralInfo
{
    public ReferralQuery Query { get; set; } = new();
    public UpdateReferral Referral { get; set; } = new();
}

public class PrimaryInfo
{
    public string ReferralId { get; set; } = "";
}

public class SecondaryInfo
{
    public string ExternalIdentifier { get; set; } = "";
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
}

public class TertiaryInfo
{
    public string ProgramId { get; set; } = "";
    public string ProgramName { get; set; } = "";
    public string ProgramTitle { get; set; } = "";
}

public class FuzzyInfo
{
    public string Identifier { get; set; } = "";
}

public class ReferralQuery
{
    public PrimaryInfo PrimaryInfo { get; set; } = new();
    public SecondaryInfo SecondaryInfo { get; set; } = new();
    public TertiaryInfo TertiaryInfo { get; set; } = new();
    public FuzzyInfo FuzzyInfo { get; set; } = new();
}

public class ReferralConfirmation
{
    public Referral Referral { get; set; } = new();
    public string Message { get; set; } = "";
}

public class ResultInfo
{
    public string Status { get; set; } = "";
    public string Message { get; set; } = "";
}

public class RemoveReferralResult
{
    public ReferralQuery Query { get; set; } = new();
    public ResultInfo ResultInfo { get; set; } = new();
}

public class RemoveReferralInfo
{
    public ReferralQuery Query { get; set; } = new();
}