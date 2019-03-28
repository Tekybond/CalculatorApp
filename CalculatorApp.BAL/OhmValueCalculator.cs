using CalculatorApp.BAL.Interface;
using CalculatorApp.DAL;
using CalculatorApp.DAL.Interface;
using CalculatorApp.Entities;
using CalculatorApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorApp.BAL
{
    public class OhmValueCalculator : IOhmValueCalculator
    {
        /// <summary>
        /// Variable to hold the value of Respository
        /// </summary>
        IRepository _repository = null;

        //Default Constructor
        public OhmValueCalculator()
        {

        }

        /// <summary>
        /// Method used in dependency injection
        /// </summary>
        /// <param name="repository"></param>
        public void Inject(IRepository repository)
        {
            _repository = repository;
        }


        IRepository ObjRepository
        {
            get
            {
                if (_repository == null)
                    _repository = new Repository();
                return _repository;
            }
        }

        #region Methods

        /// <inheritdoc />
        public Int64 CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            //Validate input parameters
            Assertion.Requires(bandAColor.HasValue());
            Assertion.Requires(bandBColor.HasValue());
            Assertion.Requires(bandCColor.HasValue());
            Assertion.Requires(bandDColor.HasValue());

            List<ResistorColor> lstRingColor = null;
            ResistorColor objRingColor = null;
            Int16 multiplier = 0;
            Int64 ohmValue = 0;

            lstRingColor = GetRingColorModel();

            // bandAColor
            objRingColor = lstRingColor.FirstOrDefault(r => r.ColorCode == bandAColor);
            if (objRingColor != null)
            {
                ohmValue = objRingColor.SignificantFigure.HasValue ? Convert.ToInt16(objRingColor.SignificantFigure.Value) * 10 : 1; // color codes None, Pink, Silver, Gold should not impact the calculation as its optional
            }
            else
            {
                throw new Exception("Invalid Band A color"); // all thess validations can be done at the begining of logics to avoid resource utilization
            }

            // bandBColor
            objRingColor = lstRingColor.FirstOrDefault(r => r.ColorCode == bandBColor);
            if (objRingColor != null)
            {
                ohmValue = objRingColor.SignificantFigure.HasValue ? Convert.ToInt16(objRingColor.SignificantFigure.Value) + ohmValue : 1; // color codes None, Pink, Silver, Gold should not impact the calculation as its optional
            }
            else
            {
                throw new Exception("Invalid Band B color");
            }

            // bandCColor
            objRingColor = lstRingColor.FirstOrDefault(r => r.ColorCode == bandCColor);
            if (objRingColor != null)
            {
                multiplier = Convert.ToInt16(objRingColor.SignificantFigure ?? 0);
            }
            else
            {
                throw new Exception("Invalid Band C color");
            }
            // bandDColor
            objRingColor = lstRingColor.FirstOrDefault(r => r.ColorCode == bandDColor);
            if (objRingColor == null)
            {
                throw new Exception("Invalid Band D color");
            }

            return Convert.ToInt64(ohmValue * Math.Pow(10, multiplier));
        }


        /// <inheritdoc />
        public List<ResistorColor> GetRingColorModel()
        {
            return ObjRepository.GetRingColorData();
        }

        #endregion

    }
}
