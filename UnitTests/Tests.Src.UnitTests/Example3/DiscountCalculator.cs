namespace Tests.Src.UnitTests.Example3;

public class DiscountCalculator
{
	public decimal CalculateDiscount(decimal totalAmount,MemberShipLevel memeberShipLevel)
	{
        decimal discount = 0;
        switch (memeberShipLevel)
        {
            case MemberShipLevel.Silver:
                discount = 0.05m;
                break;
            case MemberShipLevel.Gold:
                discount = 0.10m;
                break;
            case MemberShipLevel.Platinum:
                discount = 0.20m;
                break;
            case MemberShipLevel.None:
            default:
                discount = 0;
                break;
        }
        return totalAmount * (1- discount); 
    }

}
