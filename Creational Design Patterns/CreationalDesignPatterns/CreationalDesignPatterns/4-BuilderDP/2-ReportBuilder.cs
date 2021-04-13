using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.BuilderDP
{
    abstract class ReportBuilder
    {
        protected Report reportObject;

        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();


        public void CreateNewReport()
        {
            reportObject = new Report();
        }
        public Report GetReport()
        {
            return reportObject;
        }
    }
}
