﻿using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenge.Interfaces;

namespace CodingChallenge.Core.CardTypes
{
    public class DiscoverCardType : ICardType
    {
        public string Issuer => "Discover";
        public decimal InterestRate => 0.01m;
    }
}
