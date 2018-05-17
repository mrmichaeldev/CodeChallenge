using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Interfaces.Factories
{
    public abstract class BaseWalletFactory
    {
        protected readonly BaseCreditCardFactory CreditCardFactory;

        protected BaseWalletFactory(BaseCreditCardFactory creditCardFactory)
        {
            CreditCardFactory = creditCardFactory;
        }

        public abstract IWallet GetWallet(params ICardType[] cardTypes);
    }
}
