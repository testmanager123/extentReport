using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFBExtentreport.Test
{
    public class SetupClass
    {
        public static ExtentReports extent;

        [OneTimeSetUp]
        protected void Setup()
        {
            extent = new ExtentReports();
            var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

            DirectoryInfo di = Directory.CreateDirectory(dir + "\\Test_Execution_Reports");

            var htmlReporter = new ExtentHtmlReporter(dir + "\\Test_Execution_Reports" + "\\Automation_Report" + ".html");

            extent.AddSystemInfo("Environment", "Journey of Quality");
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        protected void TearDown()
        {
            extent.Flush();
        }
    }
}