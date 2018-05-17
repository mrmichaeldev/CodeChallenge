using System.Collections.Generic;

namespace CodingChallenge.Interfaces
{
    public interface IWallet
    {
        IList<CreditCard> CreditCards { get; }

        decimal CalculateTotalInterest();
    }
}
