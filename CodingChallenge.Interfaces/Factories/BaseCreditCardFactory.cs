using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Interfaces.Factories
{
    public abstract class BaseCreditCardFactory
    {
        public abstract CreditCard GetCreditCard(ICardType cardType);
    }
}
