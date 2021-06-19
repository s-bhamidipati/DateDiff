using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DateDifferenceCalculation.Models
{
    /// <summary>
    /// Response Model
    /// </summary>
    public class Response
    {
        /// <summary>
        /// StartDate
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// EndDate
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// Difference
        /// </summary>
        public int Difference { get; set; }
    }
}