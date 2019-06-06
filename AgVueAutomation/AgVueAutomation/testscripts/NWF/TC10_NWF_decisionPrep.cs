using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC10_NWF_decisionPrep
    {
        /// <summary>
        /// Test Case : Decision - Approver Decision
        /// Test Steps :
        //Select Admin tab.Then select "Cases"
        //Search with the case number and click on Search button
        //Select "Decision Prep checkbox" and then click on Reassign button
        //Enter user name to search and click on search button
        //Select the search user displayed and click on Reassign button.
        //Then click on Finish button then close the case window displayed
        //Search with the case number and click on Search button
        //Select "Decision Prep checkbox" task
        //Select Approve for Approver decision
        //Select last approver record and delete the rows -4
        //Select last approver record and delete the rows -3
        //Select last approver record and delete the rows -2
        //Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC10NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_10>>", "<<Decision - Approver Decision>>", "<<Decision - Approver Decision>>", "PASS");

                string idcase = pages.NWFCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectAdminCases();                
                pages.NWFCreditRequestcs.searchCase(idcase);
                pages.NWFCreditRequestcs.clickDecisionPrep();
                pages.NWFCreditRequestcs.reassignUser(dtResult[0]["TestData1"].ToString());               
                pages.NWFCreditRequestcs.seacrWithCaseId(idcase);
                pages.NWFCreditRequestcs.selectCaseFromInboxHavingText_DecisionPrep();

                pages.NWFCreditRequestcs.selectProceedWithDecision();
                
            }
        }
    }
}
