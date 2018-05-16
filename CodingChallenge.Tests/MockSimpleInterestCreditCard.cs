using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Interfaces;

namespace CodingChallenge.Tests
{
    /// <summary>
    /// All the balances are 100.
    /// Good in mock object but doesn't make sense for a card to have a default balance of 100
    /// </summary>
    public class MockSimpleInterestCreditCard : CreditCard
    {
        public MockSimpleInterestCreditCard(ICardType cardType) : base(cardType)
        {
            Balance = 100m;
        }

        public override decimal CalculateInterest()
        {
            return Balance * CardType.InterestRate;
        }
    }
}
