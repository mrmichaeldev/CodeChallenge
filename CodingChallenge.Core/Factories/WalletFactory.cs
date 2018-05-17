using CodingChallenge.Interfaces;
using CodingChallenge.Interfaces.Factories;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Core.Factories
{
    public class WalletFactory : BaseWalletFactory
    {
        [Inject]
        public WalletFactory(BaseCreditCardFactory creditCardFactory) : base(creditCardFactory)
        {
        }

        public override IWallet GetWallet(params ICardType[] cardTypes)
        {
            var wallet = new Wallet();

            foreach (var cardType in cardTypes)
            {
                var creditCard = CreditCardFactory.GetCreditCard(cardType);
                wallet.CreditCards.Add(creditCard);
            }

            return wallet;
        }
    }
}
