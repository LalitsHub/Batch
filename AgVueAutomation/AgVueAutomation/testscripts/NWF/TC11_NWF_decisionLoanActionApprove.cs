using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC11_NWF_decisionLoanActionApprove
    {
        /// <summary>
        /// Test Case : Post Decision Review
        /// Test Steps :
        //Select Admin tab.Then select "Cases"
        //Search with the case number and click on Search button
        //Select "Decision Loan Actions" and then click on Reassign button
        //Enter user name to search and click on search button
        //Select the search user displayed and click on Reassign button.
        //Then click on Finish button then close the case window displayed
        //Search with the case number and click on Search button
        //Select "Decision Loan Actions" task
        //Select Approve for Approver decision >> Click on "Submit" button
        //Select "Submit Credit Request For Processing" for Post decision Review
        //Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC11NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_11>>", "<Post Decision Review>>", "<<Post Decision Review>>", "PASS");

                string idcase = pages.NWFCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectAdminCases();                
                pages.NWFCreditRequestcs.searchCase(idcase);
                pages.NWFCreditRequestcs.clickDecisionLoanActions();
                pages.NWFCreditRequestcs.reassignUser(dtResult[0]["TestData1"].ToString());
                pages.NWFCreditRequestcs.seacrWithCaseId(idcase);
                pages.NWFCreditRequestcs.selectCaseFromInboxHavingText_DecisionLoanActions();

                pages.NWFCreditRequestcs.selectApproverDecision();
                pages.NWFCreditRequestcs.selectPostDecisionReview();
            }
        }
    }
}
