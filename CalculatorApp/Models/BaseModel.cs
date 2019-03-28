
namespace CalculatorApp.Models
{
    public class BaseModel
    {

        /// <summary>
        /// Used to hold the Anti forgery token 
        /// </summary>
        public string __RequestVerificationToken { get; set; }
    }
}