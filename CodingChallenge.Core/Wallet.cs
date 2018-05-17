using System;
using System.Collections.Generic;
using System.Linq;
using CodingChallenge.Interfaces;

namespace CodingChallenge.Core
{
    public class Wallet : IWallet
    {
        public IList<CreditCard> CreditCards { get; } = new List<CreditCard>();

        public decimal CalculateTotalInterest()
        {
            return CreditCards.Sum(creditCard => creditCard.CalculateInterest());
        }
    }
}
