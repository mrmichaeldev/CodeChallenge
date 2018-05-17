using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Core;
using CodingChallenge.Interfaces;
using CodingChallenge.Core.CardTypes;
using CodingChallenge.Interfaces.Factories;
using CodingChallenge.Core.Factories;
using CodingChallenge.Tests.MockFactories;
using Ninject;

namespace CodingChallenge.Tests
{
    [TestClass]
    public class TestCase3
    {
        private static readonly IKernel Kernel = new StandardKernel();
        private readonly BasePersonFactory _personFactory =
            Kernel.Get<BasePersonFactory>();

        static TestCase3()
        {
            Kernel.Bind<BaseCreditCardFactory>().To<MockCreditCardFactory>();
            Kernel.Bind<BaseWalletFactory>().To<WalletFactory>();
            Kernel.Bind<BasePersonFactory>().To<PersonFactory>();
        }

        private readonly ICardType DiscoverCardType = new DiscoverCardType();
        private readonly ICardType VisaCardType = new VisaCardType();
        private readonly ICardType MCCardType = new MCCardType();

        private IPerson _person1, _person2;
        private IWallet _wallet1, _wallet2;

        [TestInitialize]
        public void Init()
        {
            var cardTypesList1 = new[]
            {
                new [] { MCCardType, MCCardType, VisaCardType }
            };

            var cardTypesList2 = new[]
            {
                new [] { VisaCardType, MCCardType }
            };

            _person1 = _personFactory.GetPerson(cardTypesList1);
            _person2 = _personFactory.GetPerson(cardTypesList2);

            _wallet1 = _person1.Wallets[0];
            _wallet2 = _person2.Wallets[0];
        }

        [TestMethod]
        public void Wallet1Interest()
        {
            Assert.AreEqual(20, _wallet1.CalculateTotalInterest());
        }

        [TestMethod]
        public void Wallet2Interest()
        {
            Assert.AreEqual(15, _wallet2.CalculateTotalInterest());
        }

        [TestMethod]
        public void Person1Interest()
        {
            Assert.AreEqual(20, _person1.CalculateTotalInterest());
        }

        [TestMethod]
        public void Person2Interest()
        {
            Assert.AreEqual(15, _person2.CalculateTotalInterest());
        }
    }
}
