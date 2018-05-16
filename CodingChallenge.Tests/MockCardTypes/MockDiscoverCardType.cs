using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Interfaces;

namespace CodingChallenge.Tests.MockCardTypes
{
    public class MockDiscoverCardType : ICardType
    {
        public string Issuer => "Discover";
        public decimal InterestRate => 0.01m;
    }
}
