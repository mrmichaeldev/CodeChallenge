using CodingChallenge.Interfaces;
using CodingChallenge.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Core.Factories
{
    public class CreditCardFactory : BaseCreditCardFactory
    {
        public override CreditCard GetCreditCard(ICardType cardType)
        {
            return new SimpleInterestCreditCard(cardType);
        }
    }
}
