using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Src.UnitTests.Dependencies;

public class Receipt
{
    private List<Good> Goods;
    private PaymentMethod PaymentMethod;
    public Receipt(List<Good> goods, PaymentMethod paymentMethod)
    {
        Goods = goods;
        PaymentMethod = paymentMethod;
    }

    public string GenerateReceipt()
    {
        var total = Goods.Sum( x => x.Amount);
        return $"Total : {total} and paid with PM:{PaymentMethod.GetType().Name}";
    }
}


public class Good
{
    public string Name { get; set; }
    public decimal Amount { get; set; }
}
