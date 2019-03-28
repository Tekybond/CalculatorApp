using System;

namespace CalculatorApp.Utils
{
    /// <summary>
    /// Contains method to validate inputs
    /// </summary>
    public class Assertion
    {
        /// <summary>
        /// Throws argument null exception when the condition is false.
        /// </summary>
        /// <param name="predicate">Valid condition.</param>
        /// <param name="paramName">Paramenter Name.</param>
        /// <remarks>
        public static void Requires(bool predicate)
        {
            if (!predicate)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
