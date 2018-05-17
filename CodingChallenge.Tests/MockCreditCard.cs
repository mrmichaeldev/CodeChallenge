using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Interfaces;
using CodingChallenge.Core;

namespace CodingChallenge.Tests
{
    /// <summary>
    /// All the balances are 100.
    /// Good in mock object but doesn't make sense for a card to have a default balance of 100
    /// </summary>
    public class MockCreditCard : CreditCard
    {
        public MockCreditCard(ICardType cardType) : base(cardType)
        {
            Balance = 100m;
        }

        public override decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }
}
