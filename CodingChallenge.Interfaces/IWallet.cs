using System.Collections.Generic;

namespace CodingChallenge.Interfaces
{
    public interface IWallet : ICalculateInterest
    {
        IList<CreditCard> CreditCards { get; }
    }
}