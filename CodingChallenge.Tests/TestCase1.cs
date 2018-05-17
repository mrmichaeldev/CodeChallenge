using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Core;
using CodingChallenge.Interfaces;
using CodingChallenge.Core.CardTypes;

namespace CodingChallenge.Tests
{
    [TestClass]
    public class TestCase1
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

            var wallet = new Wallet();
            _person.Wallets.Add(wallet);

            _discoverCard = new MockCreditCard(DiscoverCardType);
            _visaCard = new MockCreditCard(VisaCardType);
            _mcCard = new MockCreditCard(MCCardType);

            wallet.CreditCards.Add(_discoverCard);
            wallet.CreditCards.Add(_visaCard);
            wallet.CreditCards.Add(_mcCard);
        }

        [TestMethod]
        public void AssertDiscoverCardInterest()
        {
            Assert.AreEqual(_discoverCard.CalculateInterest(), 1);
        }

        [TestMethod]
        public void AssertVisaCardInterest()
        {
            Assert.AreEqual(_visaCard.CalculateInterest(), 10);
        }

        [TestMethod]
        public void TestMCCardInterest()
        {
            Assert.AreEqual(_mcCard.CalculateInterest(), 5);
        }

        [TestMethod]
        public void TestPersonInterest()
        {
            Assert.AreEqual(_person.CalculateTotalInterest(), _discoverCard.CalculateInterest() +
                _visaCard.CalculateInterest() + _mcCard.CalculateInterest());
        }
    }
}
