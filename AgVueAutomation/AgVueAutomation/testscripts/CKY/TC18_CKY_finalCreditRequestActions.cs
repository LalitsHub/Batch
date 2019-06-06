using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC18_CKY_finalCreditRequestActions
    {
        /// <summary>
        /// Test Case : Credit Request Closing - Next Day verification
        /// Test Steps :
        /// Select Admin tab. Then select "Cases"
        /// Search with the case number and click on Search button
        /// Select  "Final Credit Request Actions" and then click on Reassign button
        /// Enter full name(Service AC) to search and click on search button
        /// Select the search user displayed and click on Reassign button.Then click on Finish button
        /// Close the case window displayed
        /// Search with the case number and click on Search button
        /// Select "Final Credit Request Actions" task
        /// Navigate to "Upload Documents" tab.Select the checkbox "All AgVUE Documents have been uploaded to DocHub"
        /// Select the checkbox "All Documents have been uploaded to AgDocs"
        /// Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC18CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_18>>", "<<Credit Request Closing - Final Credit Request Actions>>", "<<Credit Request Closing - Final Credit Request Actions>>", "PASS");
                //string idcase = pages.YANCreditRequestcs.fetchCaseID();
                //pages.mainMenu.selectAdminCases();
                //System.Threading.Thread.Sleep(3000);
                //pages.YANCreditRequestcs.searchCase(idcase);
                //pages.YANCreditRequestcs.clickFinalCreditRequestActions(dtResult[0]["TestData1"].ToString());
                //System.Threading.Thread.Sleep(7000);
                //pages.mainMenu.selectMenuYAN("INBOX", "", "");
                //System.Threading.Thread.Sleep(3000);
                pages.CKYCreditRequestcs.finalCreditRequestActions();
            }
        }
    }
}
