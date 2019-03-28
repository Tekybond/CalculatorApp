using CalculatorApp.BAL;
using CalculatorApp.BAL.Interface;
using CalculatorApp.Models;
using System;
using System.Web.Helpers;
using System.Web.Mvc;

namespace CalculatorApp.Controllers
{

    /// <summary>
    /// controls the Index page events
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// holds the OhmValueCalculator reference
        /// </summary>
        private IOhmValueCalculator calc = null;


        /// <summary>
        /// Constructor
        /// </summary>
        public HomeController()
        {
            calc = new OhmValueCalculator();
        }

        #region Public methods
        public ActionResult Index()
        {

            var model = new RingColorModel(calc.GetRingColorModel());
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(RingColorModel model)
        {
            var response = new ResultModel();
            try
            {
                ValidateJsonAntiForgeryToken(model.__RequestVerificationToken);
                if (ModelState.IsValid)
                    response.OhmValue = calc.CalculateOhmValue(model.BandAColor, model.BandBColor, model.BandCColor, model.BandDColor);
            }
            catch (Exception ex)
            {
                response.IsError = true;
                response.ErrorMessage = ex.Message;
            }
            return Json(response);
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Validates the token
        /// </summary>
        /// <param name="requestForgeryFormToken"></param>
        void ValidateJsonAntiForgeryToken(string requestForgeryFormToken)
        {
            var requestForgeryCookie = this.ControllerContext.RequestContext.HttpContext.Request.Cookies[AntiForgeryConfig.CookieName];
            AntiForgery.Validate(requestForgeryCookie.Value, requestForgeryFormToken);
        }

        #endregion
    }
}