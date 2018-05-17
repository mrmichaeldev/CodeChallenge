using CodingChallenge.Interfaces;
using CodingChallenge.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Tests.MockFactories
{
    public class MockCreditCardFactory : BaseCreditCardFactory
    {
        public override CreditCard GetCreditCard(ICardType cardType)
        {
            return new MockCreditCard(cardType);
        }
    }
}
