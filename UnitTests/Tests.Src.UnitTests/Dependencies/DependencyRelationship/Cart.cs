using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Src.UnitTests.Dependencies.DependencyRelationship;

public class Cart
{

    private readonly List<CartItem> Items = [];


    public bool AddItemToCart(CartItem item)
    {

        Items.Add(item);

        //your logic
        return true;
    }

    public decimal CalculateTotal()
    {
        decimal total = 0m;
        foreach (var item in Items)
        {
            total += item.Amount;   
        }
        return total;
    }
}

public class CartItem
{
    public string Title { get; set; }
    public decimal Amount { get; set; }
}
