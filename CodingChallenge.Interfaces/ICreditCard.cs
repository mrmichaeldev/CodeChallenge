using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Interfaces
{
    public interface ICreditCard
    {
        ICardType CardType { get; set; }

        decimal Balance { get; set; }
    }
}
