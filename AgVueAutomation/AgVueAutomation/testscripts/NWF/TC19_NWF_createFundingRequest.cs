using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC19_NWF_createFundingRequest
    {
        /// <summary>
        /// Test Case : Create Funding Request
        /// Test Steps :
        //        Select Admin tab.Then select "Cases"
        //Search with the case number and click on Search button
        //Select "Create Funding Request" and then click on Reassign button
        //Enter user name to search and click on search button
        //Select the search user displayed and click on Reassign button.
        //Then click on Finish button then close the case window displayed
        //Search with the case number and click on Search button
        //Select "Create Funding Request" task
        //Click on the Review and Book Loan
        //Select FundingNeededBy
        //Select the Loan Booked Checkbox
        //Select the Funding Approved radio Button
        //Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC19NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_19>>", "<<Create Funding Request>>", "<<Create Funding Request>>", "PASS");

                string idcase = pages.NWFCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectAdminCases();
                pages.NWFCreditRequestcs.searchCase(idcase);
                pages.NWFCreditRequestcs.clickCreateFundingRequest();
                pages.NWFCreditRequestcs.reassignUser(dtResult[0]["TestData1"].ToString());

                pages.NWFCreditRequestcs.searchCaseIdWithCreateFundingRequest(idcase, dtResult[0]["TestData2"].ToString(), dtResult[0]["TestData3"].ToString());
            }
        }
    }
}
