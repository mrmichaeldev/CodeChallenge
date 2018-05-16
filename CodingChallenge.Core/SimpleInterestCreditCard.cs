using CodingChallenge.Interfaces;

namespace CodingChallenge.Core
{
    public class SimpleInterestCreditCard : CreditCard
    {
        public SimpleInterestCreditCard(ICardType cardType) : base(cardType)
        {
        }

        public override decimal CalculateInterest()
        {
            return Balance * CardType.InterestRate;
        }
    }
}
