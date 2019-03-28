using System.Collections.Generic;

namespace CalculatorApp.Utils
{
    /// <summary>
    /// Contains helper methods.
    /// </summary>
    public static class ExtensionHelper
    {
        /// <summary>
        /// Checks Whether the input string is empty.
        /// </summary>
        /// <param name="sInput"></param>
        /// <returns>True if the input string is empty or null</returns>
        public static bool IsEmpty(this string sInput)
        {
            return string.IsNullOrEmpty(sInput) || string.IsNullOrWhiteSpace(sInput);
        }

        /// <summary>
        /// Checks Whether the input string has value.
        /// </summary>
        /// <param name="sInput"></param>
        /// <returns>Returns true if the input string has value</returns>
        public static bool HasValue(this string sInput)
        {
            return !IsEmpty(sInput);
        }

        /// <summary>
        /// Helps to enukerate list objects safely - null safety
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lstData"></param>
        /// <returns></returns>
        public static List<T> SafeEnumerate<T>(this List<T> lstData)
        {
            return lstData ?? new List<T>();
        }
    }
}
