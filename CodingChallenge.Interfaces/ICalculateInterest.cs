using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Interfaces
{
    /// <summary>
    /// Interface segregation principle
    /// This allows for the interest accrument method to be a separate property from the card
    /// I'm imagining a scenario where interest is displayed independent of whether
    /// person, wallet or card is selected.
    /// </summary>
    public interface ICalculateInterest
    {
        decimal CalculateInterest();
    }
}
