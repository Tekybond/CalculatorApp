using CalculatorApp.Entities;
using System.Collections.Generic;

namespace CalculatorApp.DAL.Interface
{
    public interface IRepository
    {
        /// <summary>
        /// Loads the Ring color data to the application
        /// </summary>
        /// <returns></returns>
        List<ResistorColor> GetRingColorData();
    }
}
