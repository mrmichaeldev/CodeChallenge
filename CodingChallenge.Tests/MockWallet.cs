using CodingChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Tests
{
    public class MockWallet : IWallet
    {
        public IList<CreditCard> CreditCards { get; } = new List<CreditCard>();

        public decimal CalculateTotalInterest()
        {
            return 1;
        }
    }
}
