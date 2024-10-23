using FluentAssertions;
using Tests.Src.UnitTests.Example2;

namespace Tests.UnitTests.Example2;

public class EmailValidatorTests
{
    [Theory]
    [InlineData("alireza.doostdar@gmail.com",true)]
    [InlineData("",false)]
    [InlineData(null,false)]
    [InlineData("b@sum.com",true)]
    public void IsEmailValid_ShouldReturnExpectResult(string email,bool expectResult)
    {
        var sut = new EmailValidator();

        var result = sut.IsValidEmail(email);

        result.Should().Be(expectResult);
    }
}
