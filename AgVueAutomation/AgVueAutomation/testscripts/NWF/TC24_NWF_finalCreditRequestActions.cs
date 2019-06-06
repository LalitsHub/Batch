using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC24_NWF_finalCreditRequestActions
    {
        /// <summary>
        /// Test Case : Final Credit Request Actions
        /// Test Steps :
        //        Select Admin tab.Then select "Cases"
        //Search with the case number and click on Search button
        //Select "Final Credit Request Actions" and then click on Reassign button
        //Enter user name to search and click on search button
        //Select the search user displayed and click on Reassign button.
        //Then click on Finish button then close the case window displayed
        //Search with the case number and click on Search button
        //Select "Final Credit Request Actions" task
        //Click on Upload Documents
        //Select the All AgVUE Documents have been uploaded to DocHub Checkbox
        //Select the All Documents have been uploaded to AgDocs Checkbox
        //Click on generate Loan Narrative Documents button
        //Click on generate Loan Approval Documents button
        //Click on the + Link to Edit Loan Action Checklist
        //Click on the Genarate Documents for Closing Checklist
        //Click on the Genarate Documents for Post-Close Checklist
        //Click on the Save Button
        //Click on "Submit" button

        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC24NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_24>>", "<<Final Credit Request Actions>>", "<<Final Credit Request Actions>>", "PASS");

                string idcase = pages.NWFCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectAdminCases();                
                pages.NWFCreditRequestcs.searchCase(idcase);
                pages.NWFCreditRequestcs.clickfinalCreditRequestActions();
                pages.NWFCreditRequestcs.reassignUser(dtResult[0]["TestData1"].ToString());

                pages.NWFCreditRequestcs.searchCaseIdWithFinalCreditRequestActions(idcase);
            }
        }
    }
}
