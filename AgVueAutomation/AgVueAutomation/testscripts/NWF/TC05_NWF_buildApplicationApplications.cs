using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC05_NWF_buildApplicationApplications
    {
        /// <summary>
        /// Test Case : Build Application - Applications
        /// Test Steps :        
        /// 1.Click on "Application" tab 
        /// 2.Select "Process Application" from Application decision option
        /// 3.Click on "Save" button 
        /// 4.Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC05NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_05>>", "<<Build Application - Applications>>", "<<Build Application - Applications>>", "PASS");                
                pages.NWFCreditRequestcs.addApplication_Decession(dtResult[0]["TestData1"].ToString(), dtResult[0]["TestData2"].ToString());
            }
        }
    }
}
