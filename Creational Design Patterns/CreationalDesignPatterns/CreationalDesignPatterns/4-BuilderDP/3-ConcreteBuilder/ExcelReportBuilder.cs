using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.BuilderDP
{
    class ExcelReportBuilder : ReportBuilder       
    {
        private Report _report;
        public ExcelReportBuilder()
        {
            _report = new Report();
        }
        public override void SetReportContent()
        {
            _report.ReportContent = "Excel Content";
        }
        public override void SetReportFooter()
        {
            _report.ReportFooter = "Excel Footer";
        }
        public override void SetReportHeader()
        {
            _report.ReportHeader = "Excel Header";
        }
        public override void SetReportType()
        {
            _report.ReportType = "Excel";
        }
        public override Report GetReport()
        {
            return _report ;
        }    
    }
}
