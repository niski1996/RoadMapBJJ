using DrillRoad.Contracts.Tables.Account;

namespace DrillRoad.Test.Samples;

public static class AdditionalUserInfoRowSamples
{
    public static AdditionalUserInfoRow AdditionalUserInfoRow1Partial()
    {
        return new AdditionalUserInfoRow {ContactRow = ContactSamples.Contact1, PictureRepoPatch = "dupa"};
    }
    public static AdditionalUserInfoRow AdditionalUserInfoRow2Partial()
    {
        return new AdditionalUserInfoRow {ContactRow = ContactSamples.Contact2, PictureRepoPatch = "dupsko"};
    }
}