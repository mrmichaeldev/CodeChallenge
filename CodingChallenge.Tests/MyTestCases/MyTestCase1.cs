using CodingChallenge.Core.CardTypes;
using CodingChallenge.Core.Factories;
using CodingChallenge.Interfaces;
using CodingChallenge.Interfaces.Factories;
using CodingChallenge.Tests.MockFactories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Tests.MyTestCases
{
    class MyTestCase1
    {
        private static readonly IKernel Kernel = new StandardKernel();
        private readonly BasePersonFactory _personFactory =
            Kernel.Get<BasePersonFactory>();

        static MyTestCase1()
        {
            Kernel.Bind<BaseCreditCardFactory>().To<CreditCardFactory>();
            Kernel.Bind<BaseWalletFactory>().To<MockWalletFactory>();
            Kernel.Bind<BasePersonFactory>().To<MockPersonFactory>();
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
        public void TestCalculateSimpleInterest()
        {
            Assert.AreEqual(10, _visaCard.CalculateInterest());
        }
    }
}
