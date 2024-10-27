using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Src.UnitTests.Dependencies;
using Tests.Src.UnitTests.Dependencies.DependencyRelationship;

namespace Tests.UnitTests.Dependencies.DependencyRelationship;

public class CatrTests
{
    //[Fact]
    //public void AddItemToCart_ShouldFail_IfNotLoggedin()
    //{
    //    //arrange
    //    var auth = new UserAuthentication();
    //    var cart = new Cart(auth);

    //    //assert
    //    Assert.Throws<InvalidOperationException>(() => cart.AddItemToCart("iphone"));
    //}

    //[Fact]
    //public void SearchAndAddItem_ShouldBeIndependent()
    //{

    //    //arrange
    //    var search = new Search();
    //    var searchItem = search.SearchItem("iphone");

    //    var auth = new UserAuthentication();
    //    var cart = new Cart(auth);

    //    //assert
    //    Assert.Throws<InvalidOperationException>(() => cart.AddItemToCart("iphone"));
    //}

    [Fact]
    public void Cart_ShouldCalculateTotalCorrectly()
    {
        //arrange
        var cart = new Cart();
        cart.AddItemToCart(new CartItem { Title = "item1", Amount = 1.0m });
        cart.AddItemToCart(new CartItem { Title = "item2", Amount = 2.0m });
        cart.AddItemToCart(new CartItem { Title = "item3", Amount = 3.0m });

        //act
        var result = cart.CalculateTotal();

        //assert
        result.Should().Be(6);
        
    }

    [Fact]
    public void Receipt_ShouldGenerateCorrectly()
    {
        //arrange
        var goods = new List<Good>();
        goods.Add(new Good { Name = "a", Amount = 5m });
        goods.Add(new Good { Name = "b", Amount = 2m });
        PaymentMethod payment = new CreditCartPayment();
        //act
        var receipt = new Receipt(goods, payment);
        //assert
        receipt.GenerateReceipt().Length.Should().BeGreaterThan(1);
    }
}
