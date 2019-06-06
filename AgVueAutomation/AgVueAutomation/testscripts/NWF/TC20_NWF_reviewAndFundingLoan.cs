using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC20_NWF_reviewAndFundingLoant
    {
        /// <summary>
        /// Test Case : Credit Request Closing - Review And Book Loan
        /// Test Steps :
        /// Select Admin tab. Then select "Cases"
        /// Search with the case number and click on Search button
        /// Select  "Review and Book loan" and then click on Reassign button
        /// Enter full name(Service AC) to search and click on search button
        /// Select the search user displayed and click on Reassign button.Then click on Finish button
        /// Close the case window displayed
        /// Search with the case number and click on Search button
        /// Select "Review and Book loan" task
        /// Select "Loan Booked" checkbox
        /// Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC20NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_20>>", "<<Credit Request Closing - Review and Fund Loan>>", "<<Credit Request Closing - Create Funding Request>>", "PASS");

                string idcase = pages.NWFCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectAdminCases();
                pages.NWFCreditRequestcs.searchCase(idcase);
                pages.NWFCreditRequestcs.clickReviewAndFundLoan();
                pages.NWFCreditRequestcs.reassignUser(dtResult[0]["TestData1"].ToString());

                pages.NWFCreditRequestcs.searchCaseIdWithReviewandFundLoan(idcase, dtResult[0]["TestData2"].ToString());
            }
        }
    }
}
