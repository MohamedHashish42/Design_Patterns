using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.BuilderDP
{

    class PDFReportBuilder : ReportBuilder
    {
        private Report _report;
        public PDFReportBuilder()
        {
            _report = new Report();
        }
        public override void SetReportContent()
        {
            _report.ReportContent = "PDF Content";
        }
        public override void SetReportFooter()
        {
            _report.ReportFooter = "PDF Footer";
        }
        public override void SetReportHeader()
        {
            _report.ReportHeader = "PDF Header";
        }
        public override void SetReportType()
        {
            _report.ReportType = "PDF";
        }
        public override Report GetReport()
        {
            return _report;
        }
    }
}
