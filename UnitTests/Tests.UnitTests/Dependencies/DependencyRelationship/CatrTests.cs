using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Src.UnitTests.Dependencies.DependencyRelationship;

namespace Tests.UnitTests.Dependencies.DependencyRelationship;

public class CatrTests
{
    [Fact]
    public void AddItemToCart_ShouldFail_IfNotLoggedin()
    {
        var auth = new UserAuthentication();
        var cart = new Cart(auth);
    }
}
