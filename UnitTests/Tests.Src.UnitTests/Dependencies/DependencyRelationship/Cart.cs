using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Src.UnitTests.Dependencies.DependencyRelationship;

public class Cart
{
    private UserAuthentication UserAuthentication;
    public Cart(UserAuthentication userAuthentication)
    {
        UserAuthentication = userAuthentication;
    }

    public bool AddItemToCart(string item)
    {
        if (!UserAuthentication.IsAuthenticated)
        {
            throw new InvalidOperationException("User must be logged in to the add item to the cart!");
        }

        //your logic
        return true;
    }
}
