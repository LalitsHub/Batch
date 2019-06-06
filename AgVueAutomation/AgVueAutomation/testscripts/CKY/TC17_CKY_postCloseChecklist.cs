using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC17_CKY_postCloseChecklist
    {
        /// <summary>
        /// Test Case : Credit Request Closing - Post Close Checklist
        /// Test Steps :
        /// Select Admin tab. Then select "Cases"
        /// Search with the case number and click on Search button
        /// Select  "Post-Close Tasks" and then click on Reassign button
        /// Enter full name(Service AC) to search and click on search button
        /// Select the search user displayed and click on Reassign button.Then click on Finish button
        /// Close the case window displayed
        /// Search with the case number and click on Search button
        /// Select "Post Close Tasks" task
        /// Select "Post-Close Status" as "Completed" for the "Post-Close Checklist Items"
        /// Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC17CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_17>>", "<<Credit Request Closing - Post Close Checklist>>", "<<Credit Request Closing - Post Close Checklist>>", "PASS");
                //string idcase = pages.CKYCreditRequestcs.fetchCaseID();
                //pages.mainMenu.selectAdminCases();
                //System.Threading.Thread.Sleep(3000);
                //pages.CKYCreditRequestcs.searchCase(idcase);
                pages.CKYCreditRequestcs.clickPostCloseTasks(dtResult[0]["TestData1"].ToString());
                //System.Threading.Thread.Sleep(7000);
                //pages.mainMenu.selectMenuYAN("INBOX", "", "");
                //System.Threading.Thread.Sleep(3000);
                //pages.CKYCreditRequestcs.searchCaseIdWithPostcloseTasks(idcase);
                pages.CKYCreditRequestcs.checkPostCloseChecklist();
            }
        }
    }
}
