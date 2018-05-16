using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Interfaces
{
    public interface ICreditCardFactory
    {
        CreditCard GetCreditCard(ICardType cardType);
    }
}
