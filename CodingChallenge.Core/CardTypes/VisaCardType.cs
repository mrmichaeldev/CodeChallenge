using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenge.Interfaces;

namespace CodingChallenge.Core.CardTypes
{
    public class VisaCardType : ICardType
    {
        public static VisaCardType Instance = new VisaCardType();

        public string Issuer => "Visa";
        public decimal InterestRate => 0.1m;
    }
}
