using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Interfaces
{
    public interface IPerson : ICalculateInterest
    {
        IList<IWallet> Wallets { get; }
    }
}
