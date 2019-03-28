using CalculatorApp.DAL.Interface;
using CalculatorApp.Entities;
using System.Collections.Generic;

namespace CalculatorApp.DAL
{
    public class Repository : IRepository
    {
        /// <summary>
        /// Load the Resitor model data
        /// </summary>
        /// <returns></returns>
        public List<ResistorColor> GetRingColorData()
        {
            List<ResistorColor> lstColorModel;

            lstColorModel = new List<ResistorColor>();
            lstColorModel.Add(new ResistorColor(RingColor.None, "-", null, null, 20f));
            lstColorModel.Add(new ResistorColor(RingColor.Pink, "PK", null, -3, null));
            lstColorModel.Add(new ResistorColor(RingColor.Silver, "SR", null, -2, 10f));
            lstColorModel.Add(new ResistorColor(RingColor.Gold, "GD", null, -1, 5f));
            lstColorModel.Add(new ResistorColor(RingColor.Black, "BK", 0, 0, null));
            lstColorModel.Add(new ResistorColor(RingColor.Brown, "BN", 1, 1, 1f));
            lstColorModel.Add(new ResistorColor(RingColor.Red, "RD", 2, 2, 2));
            lstColorModel.Add(new ResistorColor(RingColor.Orange, "OG", 3, 3, null));
            lstColorModel.Add(new ResistorColor(RingColor.Yellow, "YE", 4, 4, 5f));
            lstColorModel.Add(new ResistorColor(RingColor.Green, "GN", 5, 5, 0.5f));
            lstColorModel.Add(new ResistorColor(RingColor.Blue, "BU", 6, 6, 0.25f));
            lstColorModel.Add(new ResistorColor(RingColor.Violet, "VT", 7, 7, 0.1f));
            lstColorModel.Add(new ResistorColor(RingColor.Gray, "GY", 8, 8, 0.05f));
            lstColorModel.Add(new ResistorColor(RingColor.White, "WH", 9, 9, null));

            return lstColorModel;

        }
    }
}
