using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenge.Interfaces;
using CodingChallenge.Interfaces.Factories;
using Ninject;

namespace CodingChallenge.Core.Factories
{
    public class PersonFactory : BasePersonFactory
    {
        [Inject]
        public PersonFactory(BaseWalletFactory walletFactory) : base(walletFactory)
        {
        }

        public override IPerson GetPerson(params ICardType[][] cardTypesList)
        {
            var person = new Person();

            foreach (var cardTypes in cardTypesList)
            {
                var wallet = WalletFactory.GetWallet(cardTypes);
                person.Wallets.Add(wallet);
            }

            return person;
        }
    }
}
