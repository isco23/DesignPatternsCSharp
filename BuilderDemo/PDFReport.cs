using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class PDFReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Report Content";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Report Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Report Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "PDF";
        }
    }
}
