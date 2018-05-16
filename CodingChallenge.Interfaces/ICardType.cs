using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Interfaces
{
    /// <summary>
    /// In this world, card issuers and interest rates seem to be tightly coupled.
    /// </summary>
    public interface ICardType
    {
        string Issuer { get; }

        decimal InterestRate { get; }
    }
}
