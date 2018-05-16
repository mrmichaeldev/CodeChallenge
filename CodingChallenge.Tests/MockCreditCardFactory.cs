using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Interfaces;

namespace CodingChallenge.Tests
{
    public class MockCreditCardFactory : ICreditCardFactory
    {
        public CreditCard GetCreditCard(ICardType cardType)
        {
            throw new NotImplementedException();
        }
    }
}
