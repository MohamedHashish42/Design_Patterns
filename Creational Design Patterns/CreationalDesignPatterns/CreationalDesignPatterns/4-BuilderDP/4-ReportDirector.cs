using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.BuilderDP
{
    class ReportDirector
    {

        public static Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();

            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();

            return reportBuilder.GetReport();
        }
    }
}
