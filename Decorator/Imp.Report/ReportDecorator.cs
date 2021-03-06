﻿using System;
using System.IO;
using System.Text;
using Base.Interfaces;

namespace Imp.Report
{
    /// <summary>
    /// Report generated by an Authorized personnel
    /// </summary>
    public class ReportDecorator : IReport
    {
        /// <summary>
        /// Internal Sales report
        /// </summary>
        private IReport report;

        /// <summary>
        /// Name of Product
        /// </summary>
        public string ProductName { get { return report.ProductName; } }
        /// <summary>
        /// Average Weekly Sales Revenue
        /// </summary>
        public string AverageWeeklySalesRevenue { get { return report.AverageWeeklySalesRevenue; } }
        /// <summary>
        /// Profit Year to Date
        /// </summary>
        public string ProfitYTD { get { return report.ProfitYTD; } }
        /// <summary>
        /// Percentage of Opportunities converted to Sales
        /// </summary>
        public string PercentageOppToSales { get { return report.PercentageOppToSales; } }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decoratee"></param>
        public ReportDecorator(IReport decoratee)
        {
            report = decoratee;
        }
        /// <summary>
        /// Generate Report
        /// </summary>
        /// <returns></returns>
        public virtual string GenerateReport()
        {
            return report.GenerateReport();
        }
        
    }
}
