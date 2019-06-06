using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC09_NWF_preDecisionReview
    {
        /// <summary>
        /// Test Case : Decision - Pre-Decision Review
        /// Test Steps :
        //Select the Pre-Decision Review Tab
        //Select Approval Authority
        //Select the 'Sending For Decisioning' option for the Pre-Decision Review Decision
        //Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC09NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_09>>", "<<Decision - Pre-Decision Review>>", "<<Decision - Pre-Decision Review>>", "PASS");
                pages.NWFCreditRequestcs.preDecisionReviewNWF(dtResult[0]["TestData1"].ToString(), dtResult[0]["TestData2"].ToString());
            }
        }
    }
}
