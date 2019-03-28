using CalculatorApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CalculatorApp.Utils;

namespace CalculatorApp.Models
{
    public class RingColorModel : BaseModel
    {
        [Required(ErrorMessage = "Band A Color is Required")]
        [Display(Name = "Band A Color:")]
        public string BandAColor { get; set; }

        [Required(ErrorMessage = "Band B Color is Required")]
        [Display(Name = "Band B Color:")]
        public string BandBColor { get; set; }

        [Required(ErrorMessage = "Band C Color is Required")]
        [Display(Name = "Band C Color:")]
        public string BandCColor { get; set; }

        [Required(ErrorMessage = "Band D Color is Required")]
        [Display(Name = "Band D Color:")]
        public string BandDColor { get; set; }

        #region Transform

        /// <summary>
        /// Holds the Ring colors
        /// </summary>
        private List<ResistorColor> lstColorCodes = null;

        /// <summary>
        /// Default constructor
        /// </summary>
        public RingColorModel()
        {

        }

        /// <summary>
        /// Constructor to initialize the model object
        /// </summary>
        /// <param name="colorCodes"></param>
        public RingColorModel(List<ResistorColor> colorCodes)
        {
            lstColorCodes = colorCodes;
        }

        /// <summary>
        ///  Holds the list of color used to denote Significant
        /// </summary>
        public IEnumerable<KeyValuePair<string, string>> SignificantColors
        {
            get
            {
                return lstColorCodes.SafeEnumerate().Where(s => !SignificantExclusions.Contains(s.ColorName)).Select(item => new KeyValuePair<string, string>(item.ColorCode, item.ColorName.ToString()));
            }
        }

        /// <summary>
        /// Holds the list of color used to denote Multipilier
        /// </summary>
        public IEnumerable<KeyValuePair<string, string>> MultiplierColors
        {
            get
            {
                return lstColorCodes.SafeEnumerate().Where(s => !MultiplierExclusions.Contains(s.ColorName)).Select(item => new KeyValuePair<string, string>(item.ColorCode, item.ColorName.ToString()));
            }
        }

        /// <summary>
        /// Holds the list of color used to denote Tolerance
        /// </summary>
        public IEnumerable<KeyValuePair<string, string>> ToleranceColors
        {
            get
            {
                return lstColorCodes.SafeEnumerate().Where(s => !ToleranceExclusions.Contains(s.ColorName)).Select(item => new KeyValuePair<string, string>(item.ColorCode, item.ColorName.ToString()));
            }
        }

        #region Private Objects
        /// <summary>
        /// Holds the unused colors in Significant value
        /// </summary>
        private List<RingColor> SignificantExclusions
        {
            get
            {
                return new List<RingColor>() { RingColor.None, RingColor.Pink, RingColor.Silver, RingColor.Gold };
            }
        }

        /// <summary>
        ///  Holds the unused colors in Multiplier value
        /// </summary>
        private List<RingColor> MultiplierExclusions
        {
            get
            {
                return new List<RingColor>() { RingColor.None };
            }
        }

        /// <summary>
        ///  Holds the unused colors in Tolerance value
        /// </summary>
        private List<RingColor> ToleranceExclusions
        {
            get
            {
                return new List<RingColor>() { RingColor.Pink, RingColor.Black, RingColor.Orange, RingColor.White };
            }
        }
        #endregion

        #endregion
    }
}
