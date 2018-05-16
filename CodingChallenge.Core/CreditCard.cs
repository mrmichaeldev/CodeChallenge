using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenge.Interfaces;

namespace CodingChallenge.Core
{
    /// <summary>
    /// Abstract class here over an interface seems to make the most sense maintains the open/closed principle.
    /// This supports other interest calculation methods through override.
    /// Difficult to write an interface in that manner.
    /// </summary>
    public abstract class CreditCard
    {
        protected CreditCard(ICardType cardType)
        {
            CardType = cardType;
        }

        public ICardType CardType { get; set; }

        public decimal Balance { get; set; }

        public abstract decimal CalculateInterest();
    }
}
