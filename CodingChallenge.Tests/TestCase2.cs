using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Core;
using CodingChallenge.Interfaces;
using CodingChallenge.Core.CardTypes;

namespace CodingChallenge.Tests
{
    [TestClass]
    public class TestCase2
    {
        private readonly ICardType DiscoverCardType = new DiscoverCardType();
        private readonly ICardType VisaCardType = new VisaCardType();
        private readonly ICardType MCCardType = new MCCardType();

        private CreditCard _discoverCard, _visaCard, _mcCard;

        private IPerson _person;

        [TestInitialize]
        public void Init()
        {
            _person = new Person();
        }
    }
}
