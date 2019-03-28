using CalculatorApp.Entities;
using System;
using System.Collections.Generic;

namespace CalculatorApp.BAL.Interface
{
    /// <summary>
    /// Contains business logic to calculate Ohm value
    /// </summary>
    public interface IOhmValueCalculator
    {
        /// <summary>;
        /// Calculates the Ohm value of a resistor based on the band colors.
        /// </summary>;
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>
        /// <returns>Calculated Ohm value</returns>        
        Int64 CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);

        /// <summary>
        /// Load the Resitor model data
        /// </summary>
        /// <returns>Returns the Ring color settings</returns>
        List<ResistorColor> GetRingColorModel();
    }
}
