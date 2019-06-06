using AgVueAutomation.lib;
using System.Data;

using OpenQA.Selenium;
using System;

namespace AgVueAutomation.testscripts.NWF
{
    class TC06_NWF_buildLoanPackageLoanActions
    {
        /// <summary>
        /// Test Case : Build loan Package 
        /// Test Steps :
        /// Click on "Loan Actions" tab
        /// Navigate to "Loan Actions" tab > select Credit Analyst type > Select Underwriting type
        /// Navigate to "Loan Package" tab and select "Submit for Analysis" button for Lender decision
        /// Click on "Submit to Analysis" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC06NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_06>>", "<<Build loan Package - Loan Package>>", "<<Build loan Package - Loan Package>>", "PASS");
                pages.NWFCreditRequestcs.addLoanPackageNWF(dtResult[0]["TestData1"].ToString(), dtResult[0]["TestData2"].ToString(), dtResult[0]["TestData3"].ToString());
            }
        }
    }
}
