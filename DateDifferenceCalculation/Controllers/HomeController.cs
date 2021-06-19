using DateDifferenceCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DateDifferenceCalculation.Controllers
{
    /// <summary>
    /// HomeController
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index Method
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            UserRequest userDate = new UserRequest();
            return View(userDate);
        }

        /// <summary>
        /// DateDiffCalculation
        /// </summary>
        /// <param name="userDate"></param>
        /// <returns>Date Difference of two Dates</returns>
        [HttpPost]
        public ActionResult DateDiffCalculation(UserRequest userDate)
        {
                Response outPut = new Response();
                outPut.StartDate = userDate.StartDate;
                outPut.EndDate = userDate.EndDate;
                outPut.Difference = DateDiffCalcualtion.Difference(userDate);
                return View(outPut);
        }
    }
}