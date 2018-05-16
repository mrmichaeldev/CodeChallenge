using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingChallenge.Interfaces;

namespace CodingChallenge.Core
{
    public class Person : ICalculateInterest
    {
        public ICollection<Wallet> Wallets { get; set; }

        public decimal CalculateInterest()
        {
            return Wallets.Sum(w => w.CalculateInterest());
        }
    }
}
