using CodingChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Tests
{
    public class MockPerson : IPerson
    {
        public IList<IWallet> Wallets { get; } = new List<IWallet>();

        public decimal CalculateTotalInterest()
        {
            return 1;
        }
    }
}
