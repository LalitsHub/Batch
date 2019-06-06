using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC07_NWF_analyzeCreditRequestAssignCreditAnalyst
    {
        /// <summary>
        /// Test Case : Analyze Credit Request
        //Select Admin tab.Then select "Cases"
        //Search with the case number and click on Search button
        //Select "AcceptCreditRequest" and then click on Reassign button
        //Enter user name to search and click on search button
        //Select the search user displayed and click on Reassign button.
        //Then click on Finish button then close the case window displayed
        //Search with the case number and click on Search button
        //Navigate to Accept Analysis Tab and Select AcceptanceDecision as Accepted
        //Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC07NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_07>>", "<<Analyze Credit Request - Assign Credit Analyst>>", "<<Analyze Credit Request - Assign Credit Analyst>>", "PASS");

                string idcase = pages.NWFCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectAdminCases();                
                pages.NWFCreditRequestcs.searchCase(idcase);
                pages.NWFCreditRequestcs.clickAcceptCreditRequest();
                pages.NWFCreditRequestcs.reassignUser(dtResult[0]["TestData1"].ToString());                
                pages.NWFCreditRequestcs.seacrWithCaseId(idcase);

                pages.NWFCreditRequestcs.selectCaseFromInboxHavingText_AcceptCreditRequest();
                pages.NWFCreditRequestcs.verifyAcceptAnalysis();                
            }
        }
    }
}
