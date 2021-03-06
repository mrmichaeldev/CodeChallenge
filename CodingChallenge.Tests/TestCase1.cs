﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Core;
using CodingChallenge.Interfaces;
using CodingChallenge.Core.CardTypes;
using Ninject;
using CodingChallenge.Interfaces.Factories;
using CodingChallenge.Core.Factories;
using CodingChallenge.Tests.MockFactories;

namespace CodingChallenge.Tests
{
    [TestClass]
    public class TestCase1
    {
        private static readonly IKernel Kernel = new StandardKernel();
        private readonly BasePersonFactory _personFactory = 
            Kernel.Get<BasePersonFactory>();

        static TestCase1()
        {
            Kernel.Bind<BaseCreditCardFactory>().To<MockCreditCardFactory>();
            Kernel.Bind<BaseWalletFactory>().To<WalletFactory>();
            Kernel.Bind<BasePersonFactory>().To<PersonFactory>();
        }

        private readonly ICardType DiscoverCardType = new DiscoverCardType();
        private readonly ICardType VisaCardType = new VisaCardType();
        private readonly ICardType MCCardType = new MCCardType();

        private CreditCard _visaCard, _mcCard, _discoverCard;
        private IPerson _person;

        [TestInitialize]
        public void Init()
        {
            var cardTypesList = new[]
            {
                new [] { VisaCardType, MCCardType, DiscoverCardType}
            };

            _person = _personFactory.GetPerson(cardTypesList);
            var wallet = _person.Wallets[0];


            _visaCard = wallet.CreditCards[0];
            _mcCard = wallet.CreditCards[1];
            _discoverCard = wallet.CreditCards[2];
        }

        [TestMethod]
        public void AssertVisaCardInterest()
        {
            Assert.AreEqual(10, _visaCard.CalculateInterest());
        }

        [TestMethod]
        public void TestMCCardInterest()
        {
            Assert.AreEqual(5, _mcCard.CalculateInterest());
        }

        [TestMethod]
        public void AssertDiscoverCardInterest()
        {
            Assert.AreEqual(1, _discoverCard.CalculateInterest());
        }

        [TestMethod]
        public void TestPersonInterest()
        {
            Assert.AreEqual(16, _person.CalculateTotalInterest());
        }
    }
}
