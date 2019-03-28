using System;

namespace CalculatorApp.Entities
{
    /// <summary>
    /// Ring color model
    /// </summary>
    public class ResistorColor
    {
        /// <summary>
        /// Holds the name of the color
        /// </summary>
        public RingColor ColorName { get; set; }

        /// <summary>
        /// Holds the color code which will be used internally in calculations
        /// </summary>
        public string ColorCode { get; set; }

        /// <summary>
        /// Holds Significant figures value
        /// </summary>
        public UInt16? SignificantFigure { get; set; }

        /// <summary>
        /// Holds Multiplier value
        /// </summary>
        public Int16? Multiplier { get; set; }

        /// <summary>
        /// Holds Tolerance percentage value
        /// </summary>
        public Single? TolerancePercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="colorName"></param>
        /// <param name="colorCode"></param>
        /// <param name="significantFigure"></param>
        /// <param name="multiplier"></param>
        /// <param name="tolerancePercent"></param>
        public ResistorColor(RingColor colorName, string colorCode, UInt16? significantFigure, Int16? multiplier, Single? tolerancePercent)
        {
            ColorName = colorName;
            ColorCode = colorCode;
            SignificantFigure = significantFigure;
            Multiplier = multiplier;
            TolerancePercent = tolerancePercent;
        }
    }
}
