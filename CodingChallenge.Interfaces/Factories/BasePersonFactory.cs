using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Interfaces.Factories
{
    public abstract class BasePersonFactory
    {
        protected readonly BaseWalletFactory WalletFactory;

        protected BasePersonFactory(BaseWalletFactory walletFactory)
        {
            WalletFactory = walletFactory;
        }

        public abstract IPerson GetPerson(params ICardType[][] cardTypesList);
    }
}
