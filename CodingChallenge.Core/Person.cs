using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingChallenge.Interfaces;

namespace CodingChallenge.Core
{
    public class Person : IPerson
    {
        public IList<IWallet> Wallets { get; } = new List<IWallet>();

        public decimal CalculateTotalInterest()
        {
            return Wallets.Sum(w => w.CalculateTotalInterest());
        }
    }
}
