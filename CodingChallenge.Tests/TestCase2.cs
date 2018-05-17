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
        private IWallet _wallet1, _wallet2;

        private IPerson _person;

        [TestInitialize]
        public void Init()
        {
            _discoverCard = new MockCreditCard(DiscoverCardType);
            _visaCard = new MockCreditCard(VisaCardType);
            _mcCard = new MockCreditCard(MCCardType);

            _wallet1 = new Wallet();
            _wallet1.CreditCards.Add(_discoverCard);
            _wallet1.CreditCards.Add(_visaCard);

            _wallet2 = new Wallet();
            _wallet2.CreditCards.Add(_mcCard);

            _person = new Person();
            _person.Wallets.Add(_wallet1);
            _person.Wallets.Add(_wallet2);
        }

        [TestMethod]
        public void Wallet1Interest()
        {
            Assert.AreEqual(_wallet1.CalculateTotalInterest(), _discoverCard.CalculateInterest() +
                _visaCard.CalculateInterest());
        }

        [TestMethod]
        public void Wallet2Interest()
        {
            Assert.AreEqual(_wallet2.CalculateTotalInterest(), _mcCard.CalculateInterest());
        }

        [TestMethod]
        public void PersonInterest()
        {
            Assert.AreEqual(_person.CalculateTotalInterest(), _wallet1.CalculateTotalInterest() +
                _wallet2.CalculateTotalInterest());
        }
    }
}
