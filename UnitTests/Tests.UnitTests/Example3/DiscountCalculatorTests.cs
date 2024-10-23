using FluentAssertions;
using Tests.Src.UnitTests.Example3;

namespace Tests.UnitTests.Example3;

public class DiscountCalculatorTests
{
    [Theory]
    [InlineData(MemberShipLevel.None,1000,1000)]
    [InlineData(MemberShipLevel.Silver,100,95)]
    [InlineData(MemberShipLevel.Gold,100,90)]
    [InlineData(MemberShipLevel.Platinum,1000,800)]
    public void CalculateDiscount_ShouldReturnExpectedResult(MemberShipLevel level, decimal totalAmount, decimal expectedAmount)
    {
        //arrange
        var sut = new DiscountCalculator();

        //act
        var result = sut.CalculateDiscount(totalAmount, level);

        //assert
        result.Should().Be(expectedAmount);
    }
}
