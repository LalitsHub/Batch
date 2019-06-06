using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC08_NWF_analyzeCreditRequestCreditAnalysis
    {
        /// <summary>
        /// Test Case : Analyze Credit Request - Asssign Credit Analyst
        /// Test Steps :
        //Select Admin tab.Then select "Cases"
        //Search with the case number and click on Search button
        //Select "AnalyzeCreditRequest" and then click on Reassign button
        //Enter user name to search and click on search button
        //Select the search user displayed and click on Reassign button.
        //Then click on Finish button then close the case window displayed
        //Search with the case number and click on Search button
        //Select "AnalyzeCreditRequest" task
        //Select the Credit Analysis Tab
        //Select Assigned PD
        //Select Assigned LGD
        //Select the Recommmended option in the Analyst Decision
        //Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC08NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_08>>", "<<Analyze Credit Request >>", "<<Analyze Credit Request >>", "PASS");

                string idcase = pages.NWFCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectAdminCases();
                pages.NWFCreditRequestcs.searchCase(idcase);
                pages.NWFCreditRequestcs.clickAnalyzeCreditRequest();
                pages.NWFCreditRequestcs.reassignUser(dtResult[0]["TestData1"].ToString());
                pages.NWFCreditRequestcs.seacrWithCaseId(idcase);

                pages.NWFCreditRequestcs.selectCaseFromInboxHavingText_AnalyzeCreditRequest();
                pages.NWFCreditRequestcs.creditAnalysisNWF(dtResult[0]["TestData2"].ToString(), dtResult[0]["TestData3"].ToString());
            }
        }
    }
}
