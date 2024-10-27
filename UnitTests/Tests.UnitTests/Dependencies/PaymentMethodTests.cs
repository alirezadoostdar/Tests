using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Src.UnitTests.Dependencies;

namespace Tests.UnitTests.Dependencies;

public class PaymentMethodTests
{
    [Fact]
    public void Payment_ShouldProcessCorrectly_WithDiffrentMethod()
    {
        //arrange
        PaymentMethod method1 = new CreditCartPayment();
        PaymentMethod method2 = new PaypalPayment();

        //assert
        method1.Process(100m).Should().BeTrue();
        method2.Process(100m).Should().BeTrue();
    }
}
