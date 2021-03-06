﻿using System;
using Base.Interfaces;

namespace Imp.Report
{
    /// <summary>
    /// Sales Report
    /// </summary>
    public class SalesReport : IReport
    {
        /// <summary>
        /// Name of Product
        /// </summary>
        public string ProductName { get; private set; }
        /// <summary>
        /// Average Weekly Sales Revenue
        /// </summary>
        public string AverageWeeklySalesRevenue { get; private set; }
        /// <summary>
        /// Profit Year to Date
        /// </summary>
        public string ProfitYTD { get; private set; }
        /// <summary>
        /// Percentage of Opportunities converted to Sales
        /// </summary>
        public string PercentageOppToSales { get; private set; }
        /// <summary>
        /// Ctor
        /// </summary>
        public SalesReport()
        {
            // Load report from say a JSON file 
            // assuming the report was generated by another component
            ProductName = "PrinterCartridge";
            AverageWeeklySalesRevenue = "36.2 Mn";
            ProfitYTD = "365.1 Mn";
            PercentageOppToSales = "40.2%";
        }
    }
}
