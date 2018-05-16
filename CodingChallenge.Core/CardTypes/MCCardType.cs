using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenge.Interfaces;

namespace CodingChallenge.Core.CardTypes
{
    public class MCCardType : ICardType
    {
        public static MCCardType Instance = new MCCardType();

        public string Issuer => "MC";
        public decimal InterestRate => 0.05m;
    }
}
