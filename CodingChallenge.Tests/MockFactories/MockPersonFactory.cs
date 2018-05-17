using CodingChallenge.Interfaces;
using CodingChallenge.Interfaces.Factories;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Tests.MockFactories
{
    public class MockPersonFactory : BasePersonFactory
    {
        [Inject]
        public MockPersonFactory(BaseWalletFactory walletFactory) : base(walletFactory)
        {
        }

        public override IPerson GetPerson(params ICardType[][] cardTypesList)
        {
            var mockPerson = new MockPerson();

            foreach(var cardTypes in cardTypesList)
            {
                var wallet = WalletFactory.GetWallet(cardTypes);
                mockPerson.Wallets.Add(wallet);
            }

            return mockPerson;
        }
    }
}
