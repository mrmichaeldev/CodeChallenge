using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Interfaces
{
    public abstract class CreditCard : ICalculateInterest
    {
        protected CreditCard(ICardType cardType)
        {
            CardType = cardType;
        }

        public ICardType CardType { get; }

        public decimal Balance { get; set; }

        public abstract decimal CalculateInterest();
    }
}
