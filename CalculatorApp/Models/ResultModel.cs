
namespace CalculatorApp.Models
{
    public class ResultModel : BaseModel
    {
        /// <summary>
        /// Holds the calculated Ohm value
        /// </summary>
        public long OhmValue { get; set; }

        /// <summary>
        /// Holds value if any error
        /// </summary>
        public bool IsError { get; set; }

        /// <summary>
        /// Error Message
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}