using CodingChallenge.Interfaces;
using CodingChallenge.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Tests.MockFactories
{
    public class MockWalletFactory : BaseWalletFactory
    {
        public MockWalletFactory(BaseCreditCardFactory creditCardFactory) : base(creditCardFactory)
        {
        }

        public override IWallet GetWallet(params ICardType[] cardTypes)
        {
            var wallet = new MockWallet();
            
            foreach(var cardType in cardTypes)
            {
                var card = CreditCardFactory.GetCreditCard(cardType);
                wallet.CreditCards.Add(card);
            }

            return wallet;
        }
    }
}
