using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Src.UnitTests.Dependencies;

public abstract class PaymentMethod
{
    public abstract bool Process(decimal amount);
}

public  class CreditCartPayment : PaymentMethod
{
    public override bool Process(decimal amount)
    {
        return true;
    }
}

public class PaypalPayment : PaymentMethod
{
    public override bool Process(decimal amount)
    {
        return true;
    }
}
