using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportType();
            return reportBuilder.GetReport();
        }
    }
}
