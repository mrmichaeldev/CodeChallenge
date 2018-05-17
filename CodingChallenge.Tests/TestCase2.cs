using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Core;
using CodingChallenge.Interfaces;
using CodingChallenge.Core.CardTypes;
using CodingChallenge.Interfaces.Factories;
using CodingChallenge.Tests.MockFactories;
using CodingChallenge.Core.Factories;
using Ninject;

namespace CodingChallenge.Tests
{
    [TestClass]
    public class TestCase2
    {
        private static readonly IKernel Kernel = new StandardKernel();
        private readonly BasePersonFactory _personFactory =
            Kernel.Get<BasePersonFactory>();

        static TestCase2()
        {
            Kernel.Bind<BaseCreditCardFactory>().To<MockCreditCardFactory>();
            Kernel.Bind<BaseWalletFactory>().To<WalletFactory>();
            Kernel.Bind<BasePersonFactory>().To<PersonFactory>();
        }

        private readonly ICardType DiscoverCardType = new DiscoverCardType();
        private readonly ICardType VisaCardType = new VisaCardType();
        private readonly ICardType MCCardType = new MCCardType();

        private IWallet _wallet1, _wallet2;
        private IPerson _person;

        [TestInitialize]
        public void Init()
        {
            var cardTypesList = new[]
            {
                new [] { VisaCardType, DiscoverCardType},
                new [] { MCCardType }
            };

            _person = _personFactory.GetPerson(cardTypesList);
            _wallet1 = _person.Wallets[0];
            _wallet2 = _person.Wallets[1];
        }

        [TestMethod]
        public void Wallet1Interest()
        {
            Assert.AreEqual(11, _wallet1.CalculateTotalInterest());
        }

        [TestMethod]
        public void Wallet2Interest()
        {
            Assert.AreEqual(5, _wallet2.CalculateTotalInterest());
        }

        [TestMethod]
        public void PersonInterest()
        {
            Assert.AreEqual(16, _person.CalculateTotalInterest());
        }
    }
}
