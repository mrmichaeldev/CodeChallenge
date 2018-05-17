using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Interfaces
{
    public interface IPerson
    {
        IList<IWallet> Wallets { get; }

        decimal CalculateTotalInterest();
    }
}
