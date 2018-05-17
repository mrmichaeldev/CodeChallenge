using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Core;
using CodingChallenge.Interfaces;
using CodingChallenge.Core.CardTypes;

namespace CodingChallenge.Tests
{
    [TestClass]
    public class TestCase3
    {
        private readonly ICardType DiscoverCardType = new DiscoverCardType();
        private readonly ICardType VisaCardType = new VisaCardType();
        private readonly ICardType MCCardType = new MCCardType();

        private CreditCard _mcCard1, _mcCard2, _mcCard3, _visaCard;
        private IWallet _wallet1, _wallet2;
        private IPerson _person1, _person2;


        [TestInitialize]
        public void Init()
        {
            _mcCard1 = new MockCreditCard(MCCardType);
            _mcCard2 = new MockCreditCard(MCCardType);
            _mcCard3 = new MockCreditCard(MCCardType);
            _visaCard = new MockCreditCard(VisaCardType);

            _wallet1 = new Wallet();
            _wallet1.CreditCards.Add(_mcCard1);
            _wallet1.CreditCards.Add(_mcCard2);

            _person1 = new Person();
            _person1.Wallets.Add(_wallet1);

            _wallet2 = new Wallet();
            _wallet2.CreditCards.Add(_mcCard3);
            _wallet2.CreditCards.Add(_visaCard);

            _person2 = new Person();
            _person2.Wallets.Add(_wallet2);
        }

        [TestMethod]
        public void Wallet1Interest()
        {
            Assert.AreEqual(_wallet1.CalculateTotalInterest(), _mcCard1.CalculateInterest() +
                _mcCard2.CalculateInterest());
        }

        [TestMethod]
        public void Wallet2Interest()
        {
            Assert.AreEqual(_wallet2.CalculateTotalInterest(), _mcCard3.CalculateInterest() +
                _visaCard.CalculateInterest());
        }

        [TestMethod]
        public void Person1Interest()
        {
            Assert.AreEqual(_person1.CalculateTotalInterest(), _wallet1.CalculateTotalInterest());
        }

        [TestMethod]
        public void Person2Interest()
        {
            Assert.AreEqual(_person2.CalculateTotalInterest(), _wallet2.CalculateTotalInterest());
        }
    }
}
