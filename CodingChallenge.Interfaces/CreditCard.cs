using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Interfaces
{
    public abstract class CreditCard : ICardType
    {
        private readonly ICardType _cardType;

        protected CreditCard(ICardType cardType)
        {
            _cardType = cardType;
        }

        public decimal InterestRate => _cardType.InterestRate;
        public string Issuer => _cardType.Issuer;
        public decimal Balance { get; set; }

        public abstract decimal CalculateInterest();
    }
}
